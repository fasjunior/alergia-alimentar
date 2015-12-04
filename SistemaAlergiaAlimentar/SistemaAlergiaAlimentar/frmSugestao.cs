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
    public partial class frmSugestao : Form
    {
        public frmSugestao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            if(dados.conectar())
            {
                MessageBox.Show("Conectou");
            }
            else
            {
                MessageBox.Show("Não Conectou");
            }
        }
    }
}
