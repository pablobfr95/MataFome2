using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MataFome2
{
    public partial class TelaMotoqueiro : Form
    {
        public TelaMotoqueiro()
        {
            InitializeComponent();
        }

        private void cadmotobtn_Click(object sender, EventArgs e)
        {
            TelaCadastroMotoqueiro tela = new TelaCadastroMotoqueiro();
            tela.ShowDialog();
        }

        private void motoevendabtn_Click(object sender, EventArgs e)
        {
            TelaMotoqueiroVenda tela = new TelaMotoqueiroVenda();
            tela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaRelatorioMotoqueiros tela = new TelaRelatorioMotoqueiros();
            tela.ShowDialog();
        }
    }
}
