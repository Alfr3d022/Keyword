using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyword
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ptProdutos_Click(object sender, EventArgs e)
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

        private void ptEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
