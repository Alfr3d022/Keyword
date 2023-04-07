using MySql.Data.MySqlClient;
namespace Keyword
{
    public partial class Form1 : Form
    {
        public Form1()
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

        }
    }
}