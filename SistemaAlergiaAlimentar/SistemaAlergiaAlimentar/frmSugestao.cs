using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlergiaAlimentar
{
    public partial class frmSugestao : Form
    {
        public frmSugestao()
        {
            InitializeComponent();
        }

        private void preencheDados(String categoria, String produto)
        {
            txtCategoria.Text = categoria;
            txtProduto.Text = produto;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {



            this.Close();
        }
    }
}
