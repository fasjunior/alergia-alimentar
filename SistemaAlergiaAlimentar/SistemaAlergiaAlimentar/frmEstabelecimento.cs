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
    public partial class frmEstabelecimento : Form
    {
        public frmEstabelecimento()
        {
            InitializeComponent();
        }

        public void preencherCampos(string nome, string endereco, int numero, string bairro, int cep, string cidade, string uf)
        {
            label1.Select();
            txtNome.Text = nome;
            txtEndereco.Text = endereco;
            txtNumero.Text = numero.ToString();
            txtBairro.Text = bairro;
            txtCEP.Text = cep.ToString();
            txtCidade.Text = cidade;
            txtUF.Text = uf;
        }

        public void zerarCampos()
        {
            label1.Select();
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
        }
    }
}
