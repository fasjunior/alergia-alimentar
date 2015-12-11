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
        int idUsuario = 0;
        decimal codBarras;
        public Boolean close;
        private class Item
        {
            public string Name;
            public decimal Value;
            public Item(string name, decimal value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        private DataTable dtProdutosCategoria;
        public frmSugestao()
        {
            InitializeComponent();
        }

        public void preencheDados(String categoria, String produto, int idUsuario, decimal codBarras)
        {
            txtCategoria.Text = categoria;
            txtProduto.Text = produto;
            this.idUsuario = idUsuario;
            this.codBarras = codBarras;
        }


        public void getDataTable(DataTable dtProCat)
        {
            if(dtProCat != null && dtProCat.Rows.Count > 0)
            {
                btPesquisar.Enabled = false;
                dtProdutosCategoria = dtProCat;
                foreach (DataRow dr in dtProdutosCategoria.Rows)
                {
                    decimal cod_barras = Convert.ToDecimal(dr["cod_barras"]);
                    string nome = dr["nome"].ToString();
                    cbSugestao.Items.Add(new Item(nome, cod_barras));
                    if (cbSugestao.Items.Count != 0)
                    {
                        cbSugestao.Enabled = true;
                        cbSugestao.SelectedIndex = 0;
                    }
                    else
                    {
                        cbSugestao.Enabled = false;
                    }
                }
            }
            else
            {
                btPesquisar.Enabled = false;
                cbSugestao.Enabled = false;
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            string usuario = dados.ObterUsuario(idUsuario);
            
            frmPesquisa pesquisaGUI = new frmPesquisa();
            Item itemSelecionado = (Item)cbSugestao.SelectedItem;
            if (cbSugestao.Items.Count != 0)
            {
                pesquisaGUI.PreencherUsuario(idUsuario, usuario, itemSelecionado.Value);
                pesquisaGUI.ShowDialog();
            }
        }

        private void cbSugestao_SelectedIndexChanged(object sender, EventArgs e)
        {
            btPesquisar.Enabled = true;
        }
    }
}
