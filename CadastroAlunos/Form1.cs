using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CadastroAlunos
{
    public partial class cadastroAlunos : Form
    {
        public cadastroAlunos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                string nomeAluno = txtNome.Text;
                string Curso = txtCurso.Text;
                string dataNascimento = mskdDataNascimento.Text;
                string Telefone = mskdTelefone.Text;



                if (nomeAluno != "" && Curso != "" && dataNascimento != "" )
                {
                    string conexaoBanco = "Server=localHost; Database=cadastroalunos; Uid=root; pwd=''";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                    
                    conexao.Open();

                    DateTime dataMySqlFormat = Convert.ToDateTime(mskdDataNascimento)
                    string dataNascimentoFormat = dataMySqlFormat.ToString("yyyy_MM_dd");
                
                    string consultaAlunos = "SELECT * FROM cadastroAlunos WHERE Nome = @Nome and data_nascimento = @dataNascimento and Curso = @Curso and Telefone = @Telefone ";
                    MySqlCommand comandoSQL = new MySqlCommand(consultaUsuario, conexao);



                    comandoSQL.Parameters.AddWithValue("@usuario", usuarioCadastro);
                    comandoSQL.Parameters.AddWithValue("@senha", senhaCadastro);



                    int registro = Convert.ToInt32(comandoSQL.ExecuteScalar());



                    if (registro > 0)
                    {
                        MessageBox.Show("Esse usuário já existe!");
                    }
                    else
                    {

                        string cadastroSQL = "INSERT INTO usuarios (usuario, senha) values (@usuario, @senha)";
                        MySqlCommand comandoSQLCadastro = new MySqlCommand(cadastroSQL, conexao);

                        comandoSQLCadastro.Parameters.AddWithValue("@Nome", usu);
                        comandoSQLCadastro.Parameters.AddWithValue("@Curso", senhaCadastro);
                        comandoSQLCadastro.Parameters.AddWithValue("@data_nascimento", senhaCadastro);
                        comandoSQLCadastro.Parameters.AddWithValue("@Telefone", senhaCadastro);

                        int insert = Convert.ToInt32(comandoSQLCadastro.ExecuteScalar());

                        string consultaCadastro = "select * from usuarios where usuario = @usuario and senha = @senha";
                        MySqlCommand comandoSQLConsultaCadastro = new MySqlCommand(consultaCadastro, conexao);

                        comandoSQLConsultaCadastro.Parameters.AddWithValue("@usuario", usuarioCadastro);
                        comandoSQLConsultaCadastro.Parameters.AddWithValue("@senha", senhaCadastro);

                        int cregistroCadastro = Convert.ToInt32(comandoSQLConsultaCadastro.ExecuteScalar());

                        if (cregistroCadastro > 0)
                        {
                            MessageBox.Show("Cadastrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar o usuário!");
                        }

                    }

                    conexao.Close();

                }
                else
                {
                    MessageBox.Show("Os campo não pode estar vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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

            string consultaSQL = "SELECT * FROM cadastroAlunos";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(consultaSQL, conexao);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            GrindView.DataSource = dataTable;
            GrindView.AutoResizeColumns();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }


        private void mskdTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskdDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
