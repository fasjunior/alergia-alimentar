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
        bool alergia = true;
        DataTable dtEndereco = null;

        public frmPesquisa()
        {
            InitializeComponent();
            verificaEstabelecimentoNulo(); 
        }

        #region SelecionarEmNegritoSubstancias
        private void SelecionarSubstancias(List<string> substancias)
        {
            if(substancias != null)
            {
                if (substancias.Contains("Lactose"))
                {
                    cbLactose.Font = new Font(cbLactose.Font, FontStyle.Bold);
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

        #region MarcarSubstanciasProduto
        private void MarcarSubstanciasProduto(List<string> substancias)
        {
            alergia = true;
            if (substancias != null)
            {
                if (substancias.Contains("Lactose"))
                {
                    cbLactose.Checked = true;
                    if(cbLactose.Font.Bold)
                    {
                        cbLactose.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbLactose.Checked = false;
                    cbLactose.ForeColor = Color.Black;
                }

                if (substancias.Contains("Glúten"))
                {
                    cbGluten.Checked = true;
                    if (cbGluten.Font.Bold)
                    {
                        cbGluten.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbGluten.Checked = false;
                    cbGluten.ForeColor = Color.Black;
                }

                if (substancias.Contains("Ovo"))
                {
                    cbOvo.Checked = true;
                    if (cbOvo.Font.Bold)
                    {
                        cbOvo.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbOvo.Checked = false;
                    cbOvo.ForeColor = Color.Black;
                }

                if (substancias.Contains("Crustáceos"))
                {
                    cbFrutosDoMar.Checked = true;
                    if (cbFrutosDoMar.Font.Bold)
                    {
                        cbFrutosDoMar.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbFrutosDoMar.Checked = false;
                    cbFrutosDoMar.ForeColor = Color.Black;
                }

                if (substancias.Contains("Proteina de soja"))
                {
                    cbSoja.Checked = true;
                    if (cbSoja.Font.Bold)
                    {
                        cbSoja.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbSoja.Checked = false;
                    cbSoja.ForeColor = Color.Black;
                }

                if (substancias.Contains("Trigo"))
                {
                    cbTrigo.Checked = true;
                    if (cbTrigo.Font.Bold)
                    {
                        cbTrigo.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbTrigo.Checked = false;
                    cbTrigo.ForeColor = Color.Black;
                }

                if (substancias.Contains("Amendoim"))
                {
                    cbAmendoim.Checked = true;
                    if (cbAmendoim.Font.Bold)
                    {
                        cbAmendoim.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbAmendoim.Checked = false;
                    cbAmendoim.ForeColor = Color.Black;
                }

                if (substancias.Contains("Castanha"))
                {
                    cbCastanha.Checked = true;
                    if (cbCastanha.Font.Bold)
                    {
                        cbCastanha.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbCastanha.Checked = false;
                    cbCastanha.ForeColor = Color.Black;
                }

                if (substancias.Contains("Chocolate"))
                {
                    cbChocolate.Checked = true;
                    if (cbChocolate.Font.Bold)
                    {
                        cbChocolate.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbChocolate.Checked = false;
                    cbChocolate.ForeColor = Color.Black;
                }

                if (substancias.Contains("Corantes"))
                {
                    cbCorantes.Checked = true;
                    if (cbCorantes.Font.Bold)
                    {
                        cbCorantes.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbCorantes.Checked = false;
                    cbCorantes.ForeColor = Color.Black;
                }

                if (substancias.Contains("Frutas cítricas"))
                {
                    cbFrutasCitricas.Checked = true;
                    if (cbFrutasCitricas.Font.Bold)
                    {
                        cbFrutasCitricas.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbFrutasCitricas.Checked = false;
                    cbFrutasCitricas.ForeColor = Color.Black;
                }

                if (substancias.Contains("Gergelim"))
                {
                    cbGergelim.Checked = true;
                    if (cbGergelim.Font.Bold)
                    {
                        cbGergelim.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbGergelim.Checked = false;
                    cbGergelim.ForeColor = Color.Black;
                }

                if (substancias.Contains("Nozes"))
                {
                    cbNozes.Checked = true;
                    if (cbNozes.Font.Bold)
                    {
                        cbNozes.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbNozes.Checked = false;
                    cbNozes.ForeColor = Color.Black;
                }

                if (substancias.Contains("Sementes"))
                {
                    cbSementes.Checked = true;
                    if (cbSementes.Font.Bold)
                    {
                        cbSementes.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbSementes.Checked = false;
                    cbSementes.ForeColor = Color.Black;
                }
            }
        }
        #endregion

        #region PreencherUsuario
        public void PreencherUsuario(int idUsuario, string nmUsuario)
        {
            txtUsuario.Text = nmUsuario.ToUpper();
            dados = new Dados();
            List<string> substancias = dados.ObterSubstanciasDoUsuario(idUsuario);
            SelecionarSubstancias(substancias);
        }
        #endregion

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
            if (cbEstabelecimento.Text == null || cbEstabelecimento.Text == "")
            {
                cbEstabelecimento.Enabled = false;
                cbEstabelecimento.Text = "Produto Indisponível!";
                btEndereco.Enabled = false; //NÃO MEXER
            }
        }

        private void btEndereco_Click(object sender, EventArgs e)
        {
            frmEstabelecimento estabelecimentoGUI = new frmEstabelecimento();
            if(dtEndereco != null && dtEndereco.Rows.Count > 0)
            {
                estabelecimentoGUI.preencherCampos(cbEstabelecimento.Text, dtEndereco.Rows[0]["endereco"].ToString(),
                                                   Convert.ToInt32(dtEndereco.Rows[0]["numero"]),
                                                   dtEndereco.Rows[0]["bairro"].ToString(), Convert.ToInt32(dtEndereco.Rows[0]["cep"]),
                                                   dtEndereco.Rows[0]["cidade"].ToString(),
                                                   dtEndereco.Rows[0]["estado"].ToString());
            }
            
            estabelecimentoGUI.ShowDialog();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text != null  && txtCodigo.Text != "   -   -   -    -")
            {
                //removendo a máscara do código de barras
                txtCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCodBarras = txtCodigo.Text.Replace(" ","").Trim();
                decimal codBarras = Convert.ToDecimal(strCodBarras);

                //colocando novamente a máscara do código de barras
                txtCodigo.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                DataTable dtProduto = dados.ObterProduto(codBarras);
                if (dtProduto != null && dtProduto.Rows.Count > 0)
                {
                    int idFabricante = Convert.ToInt32(dtProduto.Rows[0]["id_fabricante"]);
                    int idCategoria = Convert.ToInt32(dtProduto.Rows[0]["id_categoria"]);
                    string fabricante = dados.ObterFabricante(idFabricante);
                    string produto = dtProduto.Rows[0]["nome"].ToString();
                    string categoria = dados.ObterCategoria(idCategoria);
                    List<string> substancias = dados.ObterSubstanciasDoProduto(codBarras);
                    MarcarSubstanciasProduto(substancias);
                    txtMarca.Text = fabricante;
                    txtProduto.Text = produto;
                    txtTipo.Text = categoria;
                    DataTable dtEstabelecimento = dados.ObterEstabelecimentoProduto(codBarras);
                    if(dtEstabelecimento != null && dtEstabelecimento.Rows.Count > 0)
                    {
                        int idEndereco = Convert.ToInt32(dtEstabelecimento.Rows[0]["id_endereco"]);
                        string estabelecimento = dtEstabelecimento.Rows[0]["nome"].ToString();
                        dtEndereco = dados.ObterEndereco(idEndereco);
                        cbEstabelecimento.Text = estabelecimento;
                        verificaEstabelecimentoNulo();
                    }
                    imprimirStatus(alergia);

                }
                else
                {
                    MessageBox.Show("Código de barras não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Digite um código de barras!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
