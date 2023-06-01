using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Keyword
{
    public partial class Login : Form
    {
        Thread th;
        public Login()
        {
            InitializeComponent();
            string usuario = txtUsuario.Text;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string idUsuario;


            // Abre a conexão
            MySqlConnection conexao = new Conexao().AbrirConexao();

            try
            {
                // Consulta no banco
                string query = "SELECT COUNT(id) as quantidade, id FROM tab_login WHERE login = @login AND senha = @senha";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@login", usuario);
                command.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idUsuario = reader.GetString(1);
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
                        SessaoUsuario.IniciarSessao(usuario, idUsuario);
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