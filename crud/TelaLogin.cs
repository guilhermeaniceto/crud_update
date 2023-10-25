using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        private void CarregarBancoDeDados()
        {
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=db_crud;uid=root;pwd=etec");
            meuSql.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Aluno", meuSql);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAluno.DataSource = dt;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            CarregarBancoDeDados();
            pnlEditar.Visible = false;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoSql = new MySqlConnection("server=localhost;database=db_crud;uid=root;pwd=etec");
            conexaoSql.Open();
            MySqlCommand comandoEditar = new MySqlCommand($"UPDATE Aluno SET nome = '{txtbNome.Text}', idade = {txtbIdade.Text} Where id = {txtbId.Text};", conexaoSql);
            comandoEditar.ExecuteNonQuery();

            txtbIdade.Enabled = false;
            txtbNome.Enabled = false;

            txtbId.Text = "";
            txtbIdade.Text = "";
            txtbNome.Text = "";

            MessageBox.Show("Dados atualizados!");
            pnlEditar.Visible = false;
            CarregarBancoDeDados();
        }

        private void dgvAluno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtbIdade.Enabled = true;
            txtbNome.Enabled = true;
            pnlEditar.Visible = true;

            txtbId.Text = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbNome.Text = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbIdade.Text = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
        
        }


    }
}
