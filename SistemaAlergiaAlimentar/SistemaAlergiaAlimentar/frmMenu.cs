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
            if(testarConexao())
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
            AtualizarCbUsario();
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
            cbUsuario.Text = " - Selecione um Usuário - ";
            Dados dados = new Dados();
            DataTable dtUsuarios = new DataTable();
            dtUsuarios = dados.ObterTodosUsuarios();

            foreach (DataRow dr in dtUsuarios.Rows)
            {
                int id = Convert.ToInt32(dr["id_usuario"]);
                string nome = dr["nome"].ToString();
                cbUsuario.Items.Add(new Item(nome, id));
            }

        }

        private void AtualizarCbUsario()
        {
            Dados dados = new Dados();
            DataTable dtUsuarios = new DataTable();
            dtUsuarios = dados.ObterTodosUsuarios();
            int id =0;
            string nome=null;

            foreach (DataRow dr in dtUsuarios.Rows)
            {
                id = Convert.ToInt32(dr["id_usuario"]);
                nome = dr["nome"].ToString();
            }
            cbUsuario.Items.Add(new Item(nome, id));

        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            btPesquisar.Enabled = true;
        }
    }
}
