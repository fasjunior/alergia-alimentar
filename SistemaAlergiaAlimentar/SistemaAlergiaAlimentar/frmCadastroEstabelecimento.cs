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
    public partial class frmCadastroEstabelecimento : Form
    {
        public frmCadastroEstabelecimento()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            cadastrarEndereço();
            this.Close();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCodBarras = txtCodigo.Text.Replace(" ", "").Trim();
                txtMarca.Text = "";
                txtProduto.Text = "";
                txtTipo.Text = "";
                if (strCodBarras.Length == 14)
                {
                    preencheProduto();
                }
            }
            catch
            {

            }
        }

        #region preencheProduto
        public void preencheProduto()
        {
            DataTable dtProduto = new DataTable();
            Dados dados = new Dados();
            if (txtCodigo.Text != null && txtCodigo.Text != "   -   -   -    -")
            {
                txtCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCodBarras = txtCodigo.Text.Replace(" ", "").Trim();
                decimal txtCodBarras = Convert.ToDecimal(strCodBarras);
                dtProduto = dados.ObterProduto(txtCodBarras);
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

        #region cadastrarEndereco
        private void cadastrarEndereço()
        {
            if (txtNome.Text != "" && txtCEP.Text != "  ,   -  " && txtEndereco.Text != "" && txtNumero.Text != "" && txtUF.Text != "" && txtCidade.Text != "" && txtBairro.Text != "")
            {
                Dados dados = new Dados();
                txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCEP = txtCEP.Text.Replace(" ", "").Trim();
                txtCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCodBarras = txtCodigo.Text.Replace(" ", "").Trim();
                decimal codBarras = Convert.ToDecimal(strCodBarras);
                dados.cadastrar_endereco(Convert.ToInt32(strCEP), txtEndereco.Text, Convert.ToInt32(txtNumero.Text), txtUF.Text, txtCidade.Text, txtBairro.Text);
                dados.cadastrar_estabelecimento(txtEndereco.Text, Convert.ToInt32(strCEP), Convert.ToInt32(txtNumero.Text), txtNome.Text);
                dados.cadastrar_produto_estabelecimento(txtNome.Text, codBarras);
            }
        }
        #endregion
    }
}
