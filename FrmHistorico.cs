using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Keyword
{
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = listarUsuario();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dtGridHistorico.DataSource = dt;
        }
        private MySqlDataReader listarUsuario()
        {
            MySqlConnection conn = new Conexao().AbrirConexao();
            string query = "Select * from tab_movimentacao order by data_stamp desc";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandText = query;
            return cmd.ExecuteReader();
        }
    }
}
