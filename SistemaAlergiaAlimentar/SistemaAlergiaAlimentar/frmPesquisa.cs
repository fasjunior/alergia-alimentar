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
        DataTable dtProdutosCategoria = null;
        int idUsuario = 0;

        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        public frmPesquisa()
        {
            InitializeComponent();
            verificarEstabelecimentoNulo();
            statusAlergia.Text = "";
        }

        #region SelecionarEmNegritoSubstancias
        private void SelecionarSubstancias(List<string> substancias)
        {
            if(substancias != null)
            {
                if (substancias.Contains("Amendoim"))
                {
                    cbAmendoim.Font = new Font(cbAmendoim.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Castanha"))
                {
                    cbCastanha.Font = new Font(cbCastanha.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Chocolate"))
                {
                    cbChocolate.Font = new Font(cbChocolate.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Corantes"))
                {
                    cbCorantes.Font = new Font(cbCorantes.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Frutas Cítricas"))
                {
                    cbFrutasCitricas.Font = new Font(cbFrutasCitricas.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Frutos do Mar"))
                {
                    cbFrutosDoMar.Font = new Font(cbFrutosDoMar.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Gergelim"))
                {
                    cbGergelim.Font = new Font(cbGergelim.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Glúten"))
                {
                    cbGluten.Font = new Font(cbGluten.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Lactose"))
                {
                    cbLactose.Font = new Font(cbLactose.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Nozes"))
                {
                    cbNozes.Font = new Font(cbNozes.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Ovo"))
                {
                    cbOvo.Font = new Font(cbOvo.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Peixe"))
                {
                    cbPeixe.Font = new Font(cbPeixe.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Sementes"))
                {
                    cbSementes.Font = new Font(cbSementes.Font, FontStyle.Bold);
                }
                if (substancias.Contains("Soja"))
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
                if (substancias.Contains("Frutas Cítricas"))
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
                if (substancias.Contains("Frutos do Mar"))
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
                if (substancias.Contains("Lactose"))
                {
                    cbLactose.Checked = true;
                    if (cbLactose.Font.Bold)
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
                if (substancias.Contains("Peixe"))
                {
                    cbPeixe.Checked = true;
                    if (cbPeixe.Font.Bold)
                    {
                        cbPeixe.ForeColor = Color.Red;
                        alergia = false;
                    }
                }
                else
                {
                    cbPeixe.Checked = false;
                    cbPeixe.ForeColor = Color.Black;
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
                if (substancias.Contains("Soja"))
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
            }
        }
        #endregion

        #region PreencherUsuario
        public void PreencherUsuario(int idUsuario, string nmUsuario)
        {
            txtUsuario.Text = nmUsuario;
            this.idUsuario = idUsuario;
            dados = new Dados();
            List<string> substancias = dados.ObterSubstanciasDoUsuario(idUsuario);
            SelecionarSubstancias(substancias);
        }
        #endregion

        #region PreencherUsuario
        public void PreencherUsuario(int idUsuario, string nmUsuario, decimal codBarras)
        {
            txtUsuario.Text = nmUsuario;
            this.idUsuario = idUsuario;
            dados = new Dados();
            List<string> substancias = dados.ObterSubstanciasDoUsuario(idUsuario);
            SelecionarSubstancias(substancias);
            PreencherProduto(codBarras);
            txtCodigo.Text = codBarras.ToString();
            txtCodigo.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtCodigo.Enabled = false;
            btPesquisar.Enabled = false;
        }
        #endregion

        #region PreencherProduto
        private bool PreencherProduto(decimal codBarras)
        {
            DataTable dtProduto = dados.ObterProduto(codBarras);
            btEndereco.Enabled = false;
            cbEstabelecimento.Items.Clear();
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
                dtProdutosCategoria = dados.ObterProdutosDaCategoria(idCategoria);
                if (dtEstabelecimento != null && dtEstabelecimento.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtEstabelecimento.Rows)
                    {
                        int id = Convert.ToInt32(dr["id_estabelecimento"]);
                        string nome = dr["nome"].ToString();
                        cbEstabelecimento.Items.Add(new Item(nome, id));
                    }
                    cbEstabelecimento.Enabled = true;
                    cbEstabelecimento.Text = " - Selecione um estabelecimento - ";
                }
                imprimirStatus(alergia);

                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region imprimirStatus
        public void imprimirStatus(bool alergico)
        {
            if (alergico == false)
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
        #endregion

        #region verficarEstabelecimentoNulo()
        public void verificarEstabelecimentoNulo()
        {
            if (cbEstabelecimento.Text == null || cbEstabelecimento.Text == "")
            {
                cbEstabelecimento.Enabled = false;
                cbEstabelecimento.Text = "Produto Indisponível!";
                btEndereco.Enabled = false;
            }
            else
            {
                cbEstabelecimento.Enabled = true;
                btEndereco.Enabled = true;
            }
        }
        #endregion

     
        private void btEndereco_Click(object sender, EventArgs e)
        {
            frmEstabelecimento estabelecimentoGUI = new frmEstabelecimento();
            if (cbEstabelecimento != null && cbEstabelecimento.Items.Count > 0)
            {
                dados = new Dados();
                Item itemSelecionado = (Item)cbEstabelecimento.SelectedItem;
                int idEndereco = dados.ObterIdEnderecoDoEstabelecimento(itemSelecionado.Value);
                DataTable dtEndereco = dados.ObterEndereco(idEndereco);
                string estabelecimento = itemSelecionado.Name;
                if (dtEndereco != null && dtEndereco.Rows.Count > 0)
                {
                    estabelecimentoGUI.preencherCampos(estabelecimento, dtEndereco.Rows[0]["endereco"].ToString(),
                                                       Convert.ToInt32(dtEndereco.Rows[0]["numero"]),
                                                       dtEndereco.Rows[0]["bairro"].ToString(), Convert.ToInt32(dtEndereco.Rows[0]["cep"]),
                                                       dtEndereco.Rows[0]["cidade"].ToString(),
                                                       dtEndereco.Rows[0]["estado"].ToString());
                }
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
                if(PreencherProduto(codBarras))
                {
                    if (alergia == false)
                    {
                        DialogResult qSimilares = MessageBox.Show("Deseja sugestão de produtos similares que não lhe causem alergia?", "Podemos sugerir outro produto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (qSimilares == DialogResult.Yes)
                        {
                            frmSugestao sugestaoGUI = new frmSugestao();
                            sugestaoGUI.preencheDados(txtTipo.Text, txtProduto.Text, idUsuario);
                            dtProdutosCategoria.PrimaryKey = new DataColumn[] { dtProdutosCategoria.Columns["cod_barras"] };
                            dtProdutosCategoria.Rows.Remove(dtProdutosCategoria.Rows.Find(codBarras));
                            sugestaoGUI.getDataTable(dtProdutosCategoria);
                            sugestaoGUI.ShowDialog();
                        }
                    }
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

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEstabelecimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            btEndereco.Enabled = true;
        }
    }
}
