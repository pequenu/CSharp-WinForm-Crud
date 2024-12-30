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
    public partial class UpdateForm : Form
    {
        private string conexao = "Host=localhost;Port=porta;Username=usuario;Password=senha;Database=loja";

        public UpdateForm()
        {
            InitializeComponent();
            txtNome.Enabled = false;
            txtDesc.Enabled = false;
            txtValor.Enabled = false;
            qntEstoque.Enabled = false;
            btnAtualizar.Enabled = false;
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

                    string query = "SELECT * FROM produtos WHERE id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNome.Text = reader["nome"].ToString();
                                txtDesc.Text = reader["descricao"].ToString();
                                txtValor.Text = reader["valor"].ToString();
                                qntEstoque.Text = reader["estoque"].ToString();

                                txtNome.Enabled = true;
                                txtDesc.Enabled = true;
                                txtValor.Enabled = true;
                                qntEstoque.Enabled = true;

                                btnAtualizar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Produto com este ID não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    string query = "UPDATE produtos SET nome = @nome, descricao = @descricao, valor = @valor, estoque = @estoque WHERE id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("descricao", txtDesc.Text);
                        cmd.Parameters.AddWithValue("valor", decimal.Parse(txtValor.Text));
                        cmd.Parameters.AddWithValue("estoque", (int)qntEstoque.Value);
                        cmd.Parameters.AddWithValue("id", int.Parse(txtId.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != '.' && e.KeyChar != ',' && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtNome.Clear();

            txtDesc.Enabled = false;
            txtDesc.Clear();

            txtValor.Enabled = false;
            txtValor.Clear();

            qntEstoque.Enabled = false;
            qntEstoque.Value = 0;

            btnAtualizar.Enabled = false;
        }
    }
}
