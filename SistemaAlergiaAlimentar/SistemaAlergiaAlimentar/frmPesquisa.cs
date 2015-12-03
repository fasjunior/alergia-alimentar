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
        Dados dados = null;

        public frmPesquisa()
        {
            InitializeComponent();
            imprimirStatus(true);
            verificaEstabelecimentoNulo(); 
        }

        #region SelecionarSubstancias
        private void SelecionarSubstancias(List<string> substancias)
        {
            if(substancias != null)
            {
                if (substancias.Contains("Lactose"))
                {
                    cbLeite.Font = new Font(cbLeite.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Glúten"))
                {
                    cbGluten.Font = new Font(cbGluten.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Ovo"))
                {
                    cbOvo.Font = new Font(cbOvo.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Crustáceos"))
                {
                    cbFrutosDoMar.Font = new Font(cbFrutosDoMar.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Proteina de soja"))
                {
                    cbSoja.Font = new Font(cbSoja.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Trigo"))
                {
                    cbTrigo.Font = new Font(cbTrigo.Font, FontStyle.Bold);
                }
            }
        }
        #endregion

        public void PreencherUsuario(int idUsuario, string nmUsuario)
        {
            txtUsuario.Text = nmUsuario.ToUpper();
            dados = new Dados();
            List<string> substancias = dados.ObterSubstanciasDoUsuario(idUsuario);
            SelecionarSubstancias(substancias);
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

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text != null  && txtCodigo.Text != "   -   -   -   -")
            {

            }
            else
            {
                MessageBox.Show("Digite um código de barras!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
