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
        private DataTable dtProdutosCategoria;
        public frmSugestao()
        {
            InitializeComponent();
        }

        public void preencheDados(String categoria, String produto)
        {
            txtCategoria.Text = categoria;
            txtProduto.Text = produto;
        }

        public void getDataTable(DataTable dtProCat)
        {
            dtProdutosCategoria = dtProCat;
            foreach (DataRow dr in dtProdutosCategoria.Rows)
            {
                // Console.WriteLine(dr["nome"]);

                preencheComboBox(dr["nome"]);
            }

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void preencheComboBox(Object objeto)
        {
            cbSugestao.Items.Add(objeto);
        }




    }
}
