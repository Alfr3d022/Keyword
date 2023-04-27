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
        Thread th;
        public Home()
        {
            InitializeComponent();
        }

        private void ptProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirJanela);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void abrirJanela(object obj)
        {
            Application.Run(new FrmCadastrarProdutos());
        }
        private void ptEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
