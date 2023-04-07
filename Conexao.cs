using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Keyword
{
    internal class Conexao
    {
        string connectionString = "Server=26.125.84.95;Database=mydatabase;Uid=root;Pwd=usbw;";

        public MySqlConnection AbrirConexao()
        {
            MySqlConnection conexao = new MySqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }
        public void FecharConexao(MySqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
            else
            {
                Console.WriteLine("A conexão já está fechada");
            }
        }






    }
}
