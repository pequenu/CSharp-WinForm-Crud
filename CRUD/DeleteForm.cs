using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class DeleteForm : Form
    {
        private string conexao = "Host=localhost;Port=porta;Username=usuario;Password=senha;Database=loja";

        public DeleteForm()
        {
            InitializeComponent();
            btnDeletar.Enabled = false;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Insira um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM produtos WHERE id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Produto encontrado! Você pode deletá-lo agora.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnDeletar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Produto com este ID não foi encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnDeletar.Enabled = false;
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    string query = "DELETE FROM produtos WHERE id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produto deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnDeletar.Enabled = false;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao deletar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            btnVerificar.Enabled = true;
            btnDeletar.Enabled = false;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
