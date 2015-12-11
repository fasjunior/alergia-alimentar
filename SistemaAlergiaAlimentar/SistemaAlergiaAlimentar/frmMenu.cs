using System;
using System.Collections.Generic;
using System.Collections;
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

        public frmMenu()
        {
            InitializeComponent();
            statusDataHora.Text = DateTime.Now.ToString();
            timer1.Start();
            if (testarConexao())
            {
                InicializaCbUsuario();
            }
            else
            {
                MessageBox.Show("Erro ao conectar o banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        public bool testarConexao()
        {
            Dados dados = new Dados();
            if (dados.conectar())
            {
                statusConexao.Text = "Conectado!";
                statusConexao.Image = global::SistemaAlergiaAlimentar.Properties.Resources.OKIco;
                return true;
            }
            else
            {
                statusConexao.Text = "Desconectado!";
                statusConexao.Image = global::SistemaAlergiaAlimentar.Properties.Resources.NoIco;
                return false;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastroGUI = new frmCadastro();
            cadastroGUI.ShowDialog();
            InicializaCbUsuario();
        }

        private void itemSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobreGUI = new frmSobre();
            sobreGUI.ShowDialog();
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
            Item itemSelecionado = (Item)cbUsuario.SelectedItem;
            pesquisaGUI.PreencherUsuario(itemSelecionado.Value, itemSelecionado.Name);
            pesquisaGUI.ShowDialog();
        }


        private void InicializaCbUsuario()
        {
            cbUsuario.Items.Clear();
            Dados dados = new Dados();
            DataTable dtUsuarios = new DataTable();
            dtUsuarios = dados.ObterTodosUsuarios();

            foreach (DataRow dr in dtUsuarios.Rows)
            {
                int id = Convert.ToInt32(dr["id_usuario"]);
                string nome = dr["nome"].ToString();
                cbUsuario.Items.Add(new Item(nome, id));
            }
            cbUsuario.SelectedIndex = 0;
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            btPesquisar.Enabled = true;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusDataHora.Text = DateTime.Now.ToString();
        }


        private void cadastrarEstabelecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEstabelecimento cadastroEstabelecimentoGUI = new frmCadastroEstabelecimento();
            cadastroEstabelecimentoGUI.ShowDialog();
        }

        private void cadastrarProdutoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProdutoGUI = new frmCadastroProduto();
            cadastroProdutoGUI.ShowDialog();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cadastroGUI = new frmCadastro();
            cadastroGUI.ShowDialog();
            InicializaCbUsuario();
        }

        private void cadastrarProdutosDoEstabelecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEstabelecimentoProduto frmCadastroEstabelecimentoProdutoGUI = new frmCadastroEstabelecimentoProduto();
            frmCadastroEstabelecimentoProdutoGUI.ShowDialog();
        }

    }
}
