using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SistemaAlergiaAlimentar
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            InicializaCbUsuario();
            testarConexao();
        }

        public void testarConexao() {
            Dados dados = new Dados();
            if (dados.conectar())
            {
                statusConexao.Text = "Conectado!";
                statusConexao.Image = global::SistemaAlergiaAlimentar.Properties.Resources.OKIco; ;
            }
            else
            {
                statusConexao.Text = "Desconectado!";
                statusConexao.Image = global::SistemaAlergiaAlimentar.Properties.Resources.NoIco;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastroGUI = new frmCadastro();
            cadastroGUI.Show();
            this.Hide();
        }

        private void itemSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobreGUI = new frmSobre();
            sobreGUI.Show();
            this.Hide();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void itemSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa pesquisaGUI = new frmPesquisa();
            pesquisaGUI.Show();
            this.Hide();
        }




        private void InicializaCbUsuario()
        {
            cbUsuario.Text = " - Selecione um Usuário - ";
            Dados dados = new Dados();
            DataTable dtUsuarios = new DataTable();
            dtUsuarios = dados.ObterTodosUsuarios();
            List<string> listUsuarios = dtUsuarios.AsEnumerable()
                                                  .Select(r => r.Field<string>("nome"))
                                                  .ToList();
            string[] nomes = listUsuarios.ToArray();
            cbUsuario.Items.AddRange(nomes);
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            btPesquisar.Enabled = true;
        }
    }
}
