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
    public partial class frmCadastro : Form
    {
        Dados dados = null;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dados = new Dados();
            dados.cadastrar_usuario(txtNome.Text);
            cadastrar_subst_usuario();
            this.Close();
        }

        public void cadastrar_subst_usuario()
        {
            if (cbAmendoim.Checked)
            {
                dados.cadastrar_substancia(cbAmendoim.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbAmendoim.Text);
            }
            if (cbCastanha.Checked)
            {
                dados.cadastrar_substancia(cbCastanha.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbCastanha.Text);
            }
            if (cbChocolate.Checked)
            {
                dados.cadastrar_substancia(cbChocolate.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbChocolate.Text);
            }
            if (cbCorantes.Checked)
            {
                dados.cadastrar_substancia(cbCorantes.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbCorantes.Text);
            }
            if (cbFrutasCitricas.Checked)
            {
                dados.cadastrar_substancia(cbFrutasCitricas.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbFrutasCitricas.Text);
            }
            if (cbFrutosDoMar.Checked)
            {
                dados.cadastrar_substancia(cbFrutosDoMar.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbFrutosDoMar.Text);
            }
            if (cbGergelim.Checked)
            {
                dados.cadastrar_substancia(cbGergelim.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbGergelim.Text);
            }
            if (cbGluten.Checked)
            {
                dados.cadastrar_substancia(cbGluten.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbGluten.Text);
            }
            if (cbLactose.Checked)
            {
                dados.cadastrar_substancia(cbLactose.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbLactose.Text);
            }
            if (cbNozes.Checked)
            {
                dados.cadastrar_substancia(cbNozes.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbNozes.Text);
            }
            if (cbOvo.Checked)
            {
                dados.cadastrar_substancia(cbOvo.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbOvo.Text);
            }
            if (cbPeixe.Checked)
            {
                dados.cadastrar_substancia(cbPeixe.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbPeixe.Text);
            }
            if (cbSementes.Checked)
            {
                dados.cadastrar_substancia(cbSementes.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbSementes.Text);
            }
            if (cbSoja.Checked)
            {
                dados.cadastrar_substancia(cbSoja.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbSoja.Text);
            }
            if (cbTrigo.Checked)
            {
                dados.cadastrar_substancia(cbTrigo.Text);
                dados.cadastrar_usuario_substancia(txtNome.Text, cbTrigo.Text);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
