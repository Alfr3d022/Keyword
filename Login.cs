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
            // Abre a conexão
            MySqlConnection conexao = new Conexao().AbrirConexao();

            // Cria o comando SQL
            string query = "SELECT * FROM tab_produtos";
            MySqlCommand command = new MySqlCommand(query, conexao);

            // Executa a consulta e lê os resultados
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader.GetString(1));
            }

            // Fecha o leitor e a conexão
            reader.Close();
            new Conexao().FecharConexao(conexao);


            this.Close();
            th = new Thread(abrirJanela);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new Home());
        }
    }
}