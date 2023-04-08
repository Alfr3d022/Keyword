using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Keyword
{
    public partial class Login : Form
    {
        Thread th;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            /*

            // Abre a conexão
            MySqlConnection conexao = new Conexao().AbrirConexao();

            // Insere no banco
            string insere = "INSERT INTO tab_login (id, login, senha) " +
                "VALUES(null,'"+usuario+"','"+senha+"')";
            MySqlCommand command = new MySqlCommand(insere, conexao);

            command.ExecuteNonQuery();*/

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Abre a conexão
            MySqlConnection conexao = new Conexao().AbrirConexao();

            try
            {
                // Consulta no banco
                string query = "SELECT COUNT(id) as quantidade FROM tab_login WHERE login = @login AND senha = @senha";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@login", usuario);
                command.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0) == "0")
                    {
                        epLogin.SetError(txtUsuario, "Login ou senha incorretos");
                        //registro
                    }
                    else
                    {
                        this.Close();
                        th = new Thread(abrirJanela);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                }

                reader.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());

            }
            finally
            {
                // Fecha o leitor e a conexão

                new Conexao().FecharConexao(conexao);
            }
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new Home());
        }
    }
}