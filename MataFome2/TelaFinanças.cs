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
    public partial class TelaFinanças : Form
    {
        public TelaFinanças()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaOperadorCaixa tela = new TelaOperadorCaixa();
            tela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaSaida tela = new TelaSaida();
            tela.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaRelatorioSaida tela = new TelaRelatorioSaida();
            tela.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaEntradaeSaida tela = new TelaEntradaeSaida();
            tela.ShowDialog();
        }
    }
}
