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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string conexao = "Host=localhost;Port=porta;Username=usuario;Password=senha;Database=loja";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    string query = "INSERT INTO produtos (nome, descricao, valor, estoque) VALUES (@nome, @descricao, @valor, @estoque)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("descricao", txtDesc.Text);
                        cmd.Parameters.AddWithValue("valor", decimal.Parse(txtValor.Text));
                        cmd.Parameters.AddWithValue("estoque", (int)qntEstoque.Value);

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                MessageBox.Show("Produto registrado com sucesso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
