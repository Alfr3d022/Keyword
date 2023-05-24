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
    public partial class Movimentacao : Form
    {
        Thread th;

        public Movimentacao()
        {
            InitializeComponent();
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

        private void btnEfetuarMov_Click(object sender, EventArgs e)
        {
            Login login = new Login();  

            int codProduto = Convert.ToInt32(txtCodProduto.Text);
            int qtdProduto = Convert.ToInt32(txtQuantidade.Text);
            string tipoMov = cbTipoMovimentacao.Text;

            MySqlConnection conexao = new Conexao().AbrirConexao();

            if (tipoMov == "Entrada")
            {
                try{
                    string query = "INSERT INTO `db_keyword`.`tab_movimentacao` VALUES (default,@tipoMov,@qtdProduto,default,@login,@id)";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@id", codProduto);
                    command.Parameters.AddWithValue("@tipoMov", tipoMov);
                    command.Parameters.AddWithValue("@qtdProduto", qtdProduto);
                    command.Parameters.AddWithValue("@login", "Teste");

                    command.ExecuteNonQuery();
                    MessageBox.Show("Produto adicionado com Sucesso!");
                    conexao.Close();
                } 
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    return;
                }

            }
            else if (tipoMov == "Saída")
            {
                try
                {
                    string query = "INSERT INTO `db_keyword`.`tab_movimentacao` VALUES (default,@tipoMov,@qtdProduto,default,@login,@id)";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@id", codProduto);
                    command.Parameters.AddWithValue("@tipoMov", tipoMov);
                    command.Parameters.AddWithValue("@qtdProduto", qtdProduto);
                    command.Parameters.AddWithValue("@login", "Teste");

                    command.ExecuteNonQuery();
                    MessageBox.Show("Produto removido com Sucesso!");
                    conexao.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    return;
                }
            }

        }
    }
}
