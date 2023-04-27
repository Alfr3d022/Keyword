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
            MySqlConnection conexao = new Conexao().AbrirConexao();
            try
            {
                // Consulta no banco
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
                reader.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
            finally
            {
                // Fecha o leitor e a conexão

                new Conexao().FecharConexao(conexao);
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
                MySqlConnection conexao = new Conexao().AbrirConexao();

                try
                {

                    string cmd23 = "INSERT INTO `db_keyword`.`tab_produtos` VALUES (default,@nmproduto,@unidade,@descprodutos,default,@categoria)";

                    MySqlCommand cmd2 = new MySqlCommand(cmd23, conexao);
                    cmd2.Parameters.AddWithValue("@categoria", CategoriaProd);
                    cmd2.Parameters.AddWithValue("@descprodutos", DescProdutos);
                    cmd2.Parameters.AddWithValue("@unidade", Unidade);
                    cmd2.Parameters.AddWithValue("@nmproduto", NomeProd);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Produto Salvo com Sucesso");
                    conexao.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
