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
    public partial class Registro : Form
    {
        Thread th;
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            try
            {
                using (MySqlConnection conexao = Conexao.Instance.ObterConexao())
                {
                    string query = "INSERT INTO `db_keyword`.`tab_login` VALUES (default,@login,@senha)";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@login", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Cadastro criado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());

            }
        }

        private void txtLogar_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(abrirLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void abrirLogin()
        {
            Application.Run(new Login());
        }
    }
}
