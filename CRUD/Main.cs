using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Main : Form
    {
        private void AjustarHeaders()
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (!string.IsNullOrEmpty(column.HeaderText))
                {
                    column.HeaderText = char.ToUpper(column.HeaderText[0]) + column.HeaderText.Substring(1).ToLower();
                }
            }
        }

        private void CarregarDados()
        {
            string conexao = "Host=localhost;Port=porta;Username=usuario;Password=senha;Database=loja";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    string query = "SELECT * FROM produtos";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                    AjustarHeaders();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Main()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();

            createForm.FormClosed += (s, args) => CarregarDados();
            createForm.ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();

            updateForm.FormClosed += (s, args) => CarregarDados();
            updateForm.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();

            deleteForm.FormClosed += (s, args) => CarregarDados();
            deleteForm.ShowDialog();
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub: pequenu \nDiscord: pequenuh", "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
