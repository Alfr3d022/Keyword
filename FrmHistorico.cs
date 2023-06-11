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
        Thread th;
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            dtGridMov.DataSource = listarUsuario();
        }
        private DataTable listarUsuario()
        {
            using (MySqlConnection conexao = Conexao.Instance.ObterConexao())
            {
                string query = "select tp.cd_produto as 'Cód. produto',tp.nm_produto as 'Nome produto', tm.quantidade as 'Qtd. movimentação', tp.un as 'Unidade', tm.obs_mov as 'Obs. movimentação',  tm.usuario as 'Modificado por' ,tm.data_stamp as 'Data mov.' from tab_movimentacao tm join tab_produtos tp on tp.cd_produto = tm.id_produto order by tm.data_stamp desc";
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                    }
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader.GetValue(i);
                        }

                        dt.Rows.Add(row);
                    }

                    return dt;
                }
            }
        }

        private void pbVoltarHome_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(voltarHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void voltarHome()
        {
            Application.Run(new Home());
        }
    }
}
