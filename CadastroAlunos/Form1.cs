
using MySql.Data.MySqlClient;

using System.Data;

namespace CadastroAlunos
{
    public partial class cadastroAlunos : Form
    {
        public cadastroAlunos()
        {
            InitializeComponent();
        }


        private void groupBox2_Enter(object sender, EventArgs e) { }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                string nomeAluno = txtNome.Text;
                string Curso = txtCurso.Text;
                string dataNascimento = mskdDataNascimento.Text;
                string Telefone = mskdTelefone.Text;

                DateTime dataMySqlFormat = Convert.ToDateTime(dataNascimento);
                string dataNascimentoFormat = dataMySqlFormat.ToString("yyyy-MM-dd");

                string conexaoBanco = "Server=localHost; Database=cadastroalunos; Uid=root; pwd=''";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                conexao.Open();

                string insert = "INSERT INTO cadastroalunos (Nome, data_nascimento, Curso, Telefone) values (@Nome, @dataNascimento, @Curso, @Telefone)";
                MySqlCommand insertAluno = new MySqlCommand(insert, conexao);


                insertAluno.Parameters.AddWithValue("@Nome", nomeAluno);
                insertAluno.Parameters.AddWithValue("@dataNascimento", dataNascimentoFormat);
                insertAluno.Parameters.AddWithValue("@Curso", Curso);
                insertAluno.Parameters.AddWithValue("@Telefone", Telefone);

                int contLinhas = Convert.ToInt32(insertAluno.ExecuteNonQuery());



                if (contLinhas > 0)
                {
                    MessageBox.Show("Usuário cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexao.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            string conexaoBanco = "Server=localHost; Database=cadastroalunos; Uid=root; pwd=''";
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();

            string consultaSQL = "SELECT * FROM cadastroalunos";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(consultaSQL, conexao);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            GrindView.DataSource = dataTable;
            GrindView.AutoResizeColumns();

            conexao.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                string nomeAluno = txtNome.Text;
                string Curso = txtCurso.Text;
                string dataNascimento = mskdDataNascimento.Text;
                string Telefone = mskdTelefone.Text;
                int idAlunoSelected = Convert.ToInt32(GrindView.CurrentRow.Cells[0].Value.ToString());

                DateTime dataMySqlFormat = Convert.ToDateTime(dataNascimento);
                string dataNascimentoFormat = dataMySqlFormat.ToString("yyyy-MM-dd");

                string conexaoBanco = "Server=localHost; Database=cadastroalunos; Uid=root; pwd=''";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                conexao.Open();



                string update = "UPDATE cadastroalunos SET Nome = @nome, data_nascimento = @dataNascimento, Curso = @Curso, Telefone = @Telefone WHERE id = @id";
                MySqlCommand updateAluno = new MySqlCommand(update, conexao);


                updateAluno.Parameters.AddWithValue("@Nome", nomeAluno);
                updateAluno.Parameters.AddWithValue("@dataNascimento", dataNascimentoFormat);
                updateAluno.Parameters.AddWithValue("@Curso", Curso);
                updateAluno.Parameters.AddWithValue("@Telefone", Telefone);
                updateAluno.Parameters.AddWithValue("@id", idAlunoSelected);
                    
                int contLinhas = updateAluno.ExecuteNonQuery();



                if (contLinhas > 0)
                {
                    MessageBox.Show("Dados atualizados!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível editar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexao.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                string nomeAluno = txtNome.Text;
                string Curso = txtCurso.Text;
                string dataNascimento = mskdDataNascimento.Text;
                string Telefone = mskdTelefone.Text;

                DateTime dataMySqlFormat = Convert.ToDateTime(dataNascimento);
                string dataNascimentoFormat = dataMySqlFormat.ToString("yyyy-MM-dd");

                string conexaoBanco = "Server=localHost; Database=cadastroalunos; Uid=root; pwd=''";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                conexao.Open();

                string insert = "INSERT INTO cadastroalunos (Nome, data_nascimento, Curso, Telefone) values (@Nome, @dataNascimento, @Curso, @Telefone)";
                MySqlCommand insertAluno = new MySqlCommand(insert, conexao);


                insertAluno.Parameters.AddWithValue("@Nome", nomeAluno);
                insertAluno.Parameters.AddWithValue("@dataNascimento", dataNascimentoFormat);
                insertAluno.Parameters.AddWithValue("@Curso", Curso);
                insertAluno.Parameters.AddWithValue("@Telefone", Telefone);

                int contLinhas = Convert.ToInt32(insertAluno.ExecuteNonQuery());



                if (contLinhas > 0)
                {
                    MessageBox.Show("Usuário cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexao.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCurso.Text = "";
            txtNome.Text = "";
            mskdTelefone.Text = "";
            mskdDataNascimento.Text = "";
        }


        private void mskdTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskdDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GrindView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
