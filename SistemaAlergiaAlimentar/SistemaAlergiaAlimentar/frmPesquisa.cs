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
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
            imprimirStatus(true);
            verificaEstabelecimentoNulo(); 
        }

        public void imprimirStatus(bool alergico)
        {
            if (alergico==false)
            {
                statusAlergia.Text = "Não ingerir! Este alimento lhe causará alergia!";
                statusAlergia.Image = global::SistemaAlergiaAlimentar.Properties.Resources.NoIco; ;
            }
            else
            {
                statusAlergia.Text = "Pode ingerir! Este alimento não lhe causará alergia!";
                statusAlergia.Image = global::SistemaAlergiaAlimentar.Properties.Resources.OKIco;
            }
        }

        public void verificaEstabelecimentoNulo()
        {
            if (cbEstabelecimento.Items.Count.Equals(0))
            {
                cbEstabelecimento.Enabled = false;
                cbEstabelecimento.Text = "Produto Indisponível!";
                //btEndereco.Enabled = false; NÃO MEXER
            }
        }

        private void btEndereco_Click(object sender, EventArgs e)
        {
            frmEstabelecimento estabelecimentoGUI = new frmEstabelecimento();
            //estabelecimentoGUI.preencherCampos("Bompreço", "Rua A", 4589, "Centro", 49010280, "Aracaju", "SE");
            estabelecimentoGUI.Show();
        }
    }
}
