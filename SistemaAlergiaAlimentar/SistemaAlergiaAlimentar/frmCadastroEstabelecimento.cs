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
            if (txtNome.Text != "" && txtCEP.Text != "  ,   -  " && txtEndereco.Text != "" && txtNumero.Text != "" && txtUF.Text != "" && txtCidade.Text != "" && txtBairro.Text != "")
            {
                if(cadastrarEndereço())
                {
                    MessageBox.Show("Estabelecimento cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Estabelecimento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region cadastrarEndereco
        private bool cadastrarEndereço()
        {
            try
            {
                Dados dados = new Dados();
                txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string strCEP = txtCEP.Text.Replace(" ", "").Trim();
                dados.cadastrar_endereco(Convert.ToInt32(strCEP), txtEndereco.Text, Convert.ToInt32(txtNumero.Text.Trim()), txtUF.Text, txtCidade.Text, txtBairro.Text);
                if(!dados.cadastrar_estabelecimento(txtEndereco.Text, Convert.ToInt32(strCEP), Convert.ToInt32(txtNumero.Text), txtNome.Text))
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
