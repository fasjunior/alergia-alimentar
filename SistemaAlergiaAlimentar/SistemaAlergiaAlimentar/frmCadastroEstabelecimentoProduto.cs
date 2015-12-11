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
    public partial class frmCadastroEstabelecimentoProduto : Form
    {
        public frmCadastroEstabelecimentoProduto()
        {
            InitializeComponent();
            //preencheEstabelecimento();
            cbEstabelecimento.Enabled = false;
            btSalvar.Enabled = false;
        }

        #region obterCodigoBarras
        private decimal obterCodigoBarras()
        {
            txtCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string strCodBarras = txtCodigo.Text.Replace(" ", "").Trim();
            decimal txtCodBarras = Convert.ToDecimal(strCodBarras);
            return txtCodBarras;
        }
        #endregion

        #region obterCodigoBarrasText
        private string obterCodigoBarrasText()
        {
            return obterCodigoBarras().ToString();
        }
        #endregion

        #region Item
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
        #endregion

        #region verificarCodBarras
        private Boolean verificarCodBarras(string codBarras)
        {
            Dados dados = new Dados();
            DataTable dtCategorias = new DataTable();
            dtCategorias = dados.ObterTodosProdutos();
            Boolean status = false;
            foreach (DataRow dr in dtCategorias.Rows)
            {
                codBarras = dr["cod_barras"].ToString();
                if (obterCodigoBarras().ToString() == codBarras)
                {
                    status = true;
                }
            }
            return status;
        }

        #endregion

        #region preencheProduto
        public void preencheProduto()
        {
            DataTable dtProduto = new DataTable();
            Dados dados = new Dados();
            if (txtCodigo.Text != null && txtCodigo.Text != "   -   -   -    -")
            {
                dtProduto = dados.ObterProduto(obterCodigoBarras());
                int idFabricante = Convert.ToInt32(dtProduto.Rows[0]["id_fabricante"]);
                int idCategoria = Convert.ToInt32(dtProduto.Rows[0]["id_categoria"]);
                string fabricante = dados.ObterFabricante(idFabricante);
                string produto = dtProduto.Rows[0]["nome"].ToString();
                string categoria = dados.ObterCategoria(idCategoria);
                txtMarca.Text = fabricante;
                txtProduto.Text = produto;
                txtTipo.Text = categoria;
            }
        }
        #endregion

        #region preencherEstabelecimento
        private void preencheEstabelecimento()
        {
            if (!cbEstabelecimento.Enabled)
                cbEstabelecimento.Enabled = true;
            cbEstabelecimento.Items.Clear();
            Dados dados = new Dados();
            DataTable dtEstabelecimentos = new DataTable();
            dtEstabelecimentos = dados.ObterTodosEstabelecimentos(obterCodigoBarras());
            int id = 0;
            string nome = null;
            foreach (DataRow dr in dtEstabelecimentos.Rows)
            {
                id = Convert.ToInt32(dr["id_estabelecimento"]);
                nome = dr["nome"].ToString();
                cbEstabelecimento.Items.Add(new Item(nome, id));
            }
            if (cbEstabelecimento.Items.Count != 0)
            {
                cbEstabelecimento.SelectedIndex = 0;
            }
        }
        #endregion

        #region cadastroEstabelecimento
        private bool cadastroEstabelecimento()
        {
            try
            {
                Dados dados = new Dados();
                Item itemSelecionado = (Item)cbEstabelecimento.SelectedItem;
                dados.cadastrar_produto_estabelecimento(itemSelecionado.Value, obterCodigoBarras());
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtMarca.Text = "";
                txtProduto.Text = "";
                txtTipo.Text = "";
                txtCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCodBarras = txtCodigo.Text.Replace(" ", "").Trim();
                if (strCodBarras.Length == 14)
                {
                    DataTable dtProduto = new DataTable();
                    Dados dados = new Dados();
                    if (txtCodigo.Text != null && txtCodigo.Text != "   -   -   -    -")
                    {
                        btSalvar.Enabled = true;
                        if (verificarCodBarras(strCodBarras) == false)
                        {
                            btSalvar.Enabled = false;
                            cbEstabelecimento.Items.Clear();
                            cbEstabelecimento.Enabled = false;
                            MessageBox.Show("Código de barras não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            preencheProduto();
                            preencheEstabelecimento();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (cadastroEstabelecimento() == true)
            {
                MessageBox.Show("Produto adicionado ao estabelecimento com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btEndereco_Click(object sender, EventArgs e)
        {
            frmEstabelecimento estabelecimentoGUI = new frmEstabelecimento();
            if (cbEstabelecimento != null && cbEstabelecimento.Items.Count > 0)
            {
                Dados dados = new Dados();
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
    }
}
