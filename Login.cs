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

        private void abrirJanela(object obj)
        {
            Application.Run(new Home());
        }


        private void btnLogar1_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string idUsuario;

            
                // Abre a conexão

            try
            {
                using (MySqlConnection conexao = Conexao.Instance.ObterConexao())
                {
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
                }
                    // Consulta no banco
                  
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());

            }
        }
    }
}