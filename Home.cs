﻿using MySql.Data.MySqlClient;
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
            th = new Thread(abrirJanelaProdutos);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void abrirJanelaProdutos(object obj)
        {
            Application.Run(new FrmCadastrarProdutos());
        }
        private void ptEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirJanelaMovimentacao);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void abrirJanelaMovimentacao() 
        {
            Application.Run(new Movimentacao());

        }
    }
}
