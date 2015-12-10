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
    public partial class frmCadastroProduto : Form
    {

        public frmCadastroProduto()
        {
            InitializeComponent();
            preencheCategoria();
            preencheFabricante();
        }

        #region item
        private class Item
        {
            public string Name;
            public decimal Value;
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

        #region cadastrarProduto
        private Boolean cadastrarProduto()
        {
            Dados dados = new Dados();
            DataTable dtProduto = new DataTable();
            dtProduto = dados.ObterTodosProdutos();
            string nome = null;
            int id;
            int[] status = {0 , 0};
            decimal codBarras = 0;
            Boolean cadastro = true, retorno = false;
            if (txtNome.Text != null && txtCodigo.Text != "   -   -   -    -" && cbFabricante.Text != " - Selecione um Fabricante - " && cbFabricante.Text != "" && cbCategoria.Text != " - Selecione uma Categoria - " && cbCategoria.Text != "")
            {
                txtCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCodBarras = txtCodigo.Text.Replace(" ", "").Trim();
                decimal txtCodBarras = Convert.ToDecimal(strCodBarras);
                foreach (DataRow dr in dtProduto.Rows)
                {
                    nome = dr["nome"].ToString();
                    id = Convert.ToInt32(dr["id_fabricante"]);
                    codBarras = Convert.ToDecimal(dr["cod_barras"]);
                    if (txtCodBarras == codBarras)
                    {
                        cadastro = false;
                        status[0] = 1;
                    }
                    else if (txtNome.Text == nome && dados.ObterFabricante(id) == cbFabricante.Text)
                    {
                        cadastro = false;
                        status[1] = 1;
                    }

                }
                if (cadastro == true)
                {
                    dados.cadastrar_produto(txtCodBarras, cadastrarFabricante(), cadastrarCategoria(), txtNome.Text);
                    cadastrarSubstancias(txtCodBarras);
                    retorno = true;
                }
                else
                {
                    if (status[0] == 1 && status[1] == 0)
                    {
                        MessageBox.Show("Código de barras já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (status[0] == 0 && status[1] == 1)
                    {
                        MessageBox.Show("Produto já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Produto e código de barras já cadastrados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return retorno;
        }
        #endregion

        #region cadastrarCategoria
        private string cadastrarCategoria()
        {
            Dados dados = new Dados();
            DataTable dtCategorias = new DataTable();
            dtCategorias = dados.ObterTodasCategorias();
            string nome = null;
            Boolean cadastro = true;
            foreach (DataRow dr in dtCategorias.Rows)
            {
                nome = dr["nome"].ToString();
                if (cbCategoria.Text == nome)
                {
                    cadastro = false;
                }
            }
            if (cadastro == true)
            {
                    dados.cadastrar_categoria(cbCategoria.Text);
            }
            return cbCategoria.Text; ;
        }
        #endregion

        #region cadastrarFabricante
        private string cadastrarFabricante()
        {
            Dados dados = new Dados();
            DataTable dtFabricantes = new DataTable();
            dtFabricantes = dados.ObterTodosFabricantes();
            string nome = null;
            Boolean cadastro = true;
            foreach (DataRow dr in dtFabricantes.Rows)
            {
                nome = dr["nome"].ToString();
                if (cbFabricante.Text == nome)
                {
                    cadastro = false;
                }
            }
            if (cadastro == true)
            {
                    dados.cadastrar_fabricante(cbFabricante.Text);
            }
            return cbFabricante.Text;
        }
        #endregion

        #region cadastrarSubstancias
        private void cadastrarSubstancias(decimal codBarras)
        {
            Dados dados = new Dados();
            if (cbAmendoim.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbAmendoim.Text);
            }
            if (cbCastanha.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbCastanha.Text);
            }
            if (cbChocolate.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbChocolate.Text);
            }
            if (cbCorantes.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbCorantes.Text);
            }
            if (cbFrutasCitricas.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbFrutasCitricas.Text);
            }
            if (cbFrutosDoMar.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbFrutosDoMar.Text);
            }
            if (cbGergelim.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbGergelim.Text);
            }
            if (cbGluten.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbGluten.Text);
            }
            if (cbLactose.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbLactose.Text);
            }
            if (cbNozes.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbNozes.Text);
            }
            if (cbOvo.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbOvo.Text);
            }
            if (cbPeixe.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbPeixe.Text);
            }
            if (cbSementes.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbSementes.Text);
            }
            if (cbSoja.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbSoja.Text);
            }
            if (cbTrigo.Checked)
            {
                dados.cadastrar_produto_substancia(codBarras, cbTrigo.Text);
            }
        }
        #endregion

        #region preencherCategoria
        private void preencheCategoria()
        {
            cbCategoria.Text = " - Selecione uma Categoria - ";
            Dados dados = new Dados();
            DataTable dtCategorias = new DataTable();
            dtCategorias = dados.ObterTodasCategorias();
            int id = 0;
            string nome = null;
            foreach (DataRow dr in dtCategorias.Rows)
            {
                id = Convert.ToInt32(dr["id_categoria"]);
                nome = dr["nome"].ToString();
                cbCategoria.Items.Add(new Item(nome, id));
            }
            
        }
        #endregion

        #region preencherFabricante
        private void preencheFabricante()
        {
            cbFabricante.Text = " - Selecione um Fabricante - ";
            Dados dados = new Dados();
            DataTable dtFabricante = new DataTable();
            dtFabricante = dados.ObterTodosFabricantes();
            int id = 0;
            string nome = null;
            foreach (DataRow dr in dtFabricante.Rows)
            {
                id = Convert.ToInt32(dr["id_fabricante"]);
                nome = dr["nome"].ToString();
                cbFabricante.Items.Add(new Item(nome, id));
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
                if (txtCodigo.Text == codBarras)
                {
                    status = true;
                }
            }
            return status;
        }
        #endregion

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cadastrarProduto())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
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

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCodBarras = txtCodigo.Text.Replace(" ", "").Trim();
                if (strCodBarras.Length == 14)
                {
                    DataTable dtProduto = new DataTable();
                    Dados dados = new Dados();
                    if (txtCodigo.Text != null && txtCodigo.Text != "   -   -   -    -")
                    {
                        if (verificarCodBarras(strCodBarras) == true)
                        {
                            btSalvar.Enabled = false;
                            MessageBox.Show("Código de barras já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            btSalvar.Enabled = true;
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}
