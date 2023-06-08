using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Keyword
{
    public class Conexao
    {
        private static Conexao instance = null;
        private string connectionString = "Server=26.234.6.176;Database=db_keyword;Uid=externo;Pwd=;";

        private Conexao() { }

        public static Conexao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Conexao();
                }
                return instance;
            }
        }

        public MySqlConnection ObterConexao()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(connectionString);
                conexao.Open();
                return conexao;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }

}
