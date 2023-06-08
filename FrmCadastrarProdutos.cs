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
    public partial class FrmCadastrarProdutos : Form
    {
        Thread th;

        public FrmCadastrarProdutos()
        {
            InitializeComponent();
        }

        private void FrmCadastrarProdutos_Load(object sender, EventArgs e)
        {
            AutoCompleteGet();

        }
        private void AutoCompleteGet()
        {
            
            try
            {
                using (MySqlConnection conexao = Conexao.Instance.ObterConexao())
                {
                    string query = "select distinct categoria_prod as categorias from tab_produtos";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    MySqlDataReader reader = command.ExecuteReader();
                    List<string> valores = new List<string>();
                    while (reader.Read())
                    {
                        valores.Add(reader.GetString("categorias"));
                    }
                    string[] categoriaProd = valores.ToArray();
                    var autoCompleteTxtCategoria = new AutoCompleteStringCollection();
                    autoCompleteTxtCategoria.AddRange(categoriaProd);
                    txtCategoriaProd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtCategoriaProd.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtCategoriaProd.AutoCompleteCustomSource = autoCompleteTxtCategoria;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string CategoriaProd = txtCategoriaProd.Text;
            string DescProdutos = txtDescProdutos.Text;
            string Unidade = cbUnidade.Text;
            string NomeProd = txtNomeProd.Text;                     
            try
            {
                string cmd23 = "INSERT INTO `db_keyword`.`tab_produtos` VALUES (default,@nmproduto,@unidade,@descprodutos,default,@categoria)";

                using (MySqlConnection conexao = Conexao.Instance.ObterConexao())
                {

                    MySqlCommand cmd2 = new MySqlCommand(cmd23, conexao);
                    cmd2.Parameters.AddWithValue("@categoria", CategoriaProd);
                    cmd2.Parameters.AddWithValue("@descprodutos", DescProdutos);
                    cmd2.Parameters.AddWithValue("@unidade", Unidade);
                    cmd2.Parameters.AddWithValue("@nmproduto", NomeProd);
                    cmd2.ExecuteNonQuery();
                }                    
                MessageBox.Show("Produto Salvo com Sucesso");                   
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return;
            }            
        }
        private void pbVoltarHome_Click_1(object sender, EventArgs e)
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
