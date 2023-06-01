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
            string txtObs = rTextDescricao.Text;

            MySqlConnection conexao = new Conexao().AbrirConexao();


            if (ValidaCampos())
            {
                try
                {
                    string query = "INSERT INTO `db_keyword`.`tab_movimentacao` VALUES (default,@tipoMov,@qtdProduto,default,@login,@id,@obs)";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@id", codProduto);
                    command.Parameters.AddWithValue("@tipoMov", tipoMov);
                    command.Parameters.AddWithValue("@qtdProduto", qtdProduto);
                    command.Parameters.AddWithValue("@login", SessaoUsuario.Usuario);
                    command.Parameters.AddWithValue("@obs", txtObs);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produto adicionado com Sucesso!");
                    conexao.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    return;
                } 
            }
            else
            {
                MessageBox.Show("Produto inválido, por favor use um produto criado");
            }



        }
        //Metodo para validar todos os campos, porém, só fiz para o produto, tem que fazer para os outros txts
        public bool ValidaCampos()
        {
            bool Valido = false;
            string cdProduto = txtCodProduto.Text;
            string query = "SELECT COUNT(*) FROM tab_produtos WHERE cd_produto = @codProduto";
            //Valida txt produto com o banco
            using (MySqlConnection conn = new Conexao().AbrirConexao())
            {
                
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codProduto", cdProduto);

                    object resutaldo = cmd.ExecuteScalar();
                    if (resutaldo != null)
                    {
                        int count = Convert.ToInt32(resutaldo);
                        if (count > 0)
                            Valido = true;
                    }
                }
            }
            return Valido;
        }
    }
}
