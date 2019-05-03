using MataFome2.Cache;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbtnfornecedor_Click(object sender, EventArgs e)
        {
            FormVenda tela = new FormVenda();
            tela.ShowDialog();
            
        }

        private void tsbtnclientes_Click(object sender, EventArgs e)
        {
            TelaCadastroUsuario tela = new TelaCadastroUsuario();
            tela.ShowDialog();
        }

        private void tsbtnprodutos_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto tela = new TelaCadastroProduto();
            tela.ShowDialog();
        }

        private void tsbtnFormaPagamento_Click(object sender, EventArgs e)
        {
            TelaCadastroFormaPagamento tela = new TelaCadastroFormaPagamento();
            tela.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                OperadorCaixa op = db.OperadorCaixas.FirstOrDefault(u => u.Id == OperadorCache.Operador);
                op.Venda = OperadorCache.Venda;

                db.SaveChanges();
            }
            MessageBox.Show("Adeus !");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (UsuarioCache.NivelUsuario < 2)
            {
                tsbtnFormaPagamento.Enabled = false;
                opcaixatsbtn.Enabled = false;
                tsbtnprodutos.Enabled = false;
                tsbtnusuarios.Enabled = false;
                tsbtnrelusu.Enabled = false;
                devolucaotsbtn.Enabled = false;
                
                
                

            }
        }

        private void tsbtnusuarios_Click(object sender, EventArgs e)
        {
            TelaCadUsu tela = new TelaCadUsu();
            tela.ShowDialog();
        }

        private void tsbtnVerificarPedido_Click(object sender, EventArgs e)
        {
            TelaPedidos tela = new TelaPedidos();
            tela.ShowDialog();
        }

        private void opcaixatsbtn_Click(object sender, EventArgs e)
        {
            TelaFinanças tela = new TelaFinanças();
            tela.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void tsbtnrelusu_Click(object sender, EventArgs e)
        {
            TelaRelatoriodias tela = new TelaRelatoriodias();
            tela.ShowDialog();
        }

        
        private void devolucaotsbtn_Click(object sender, EventArgs e)
        {
            TelaDevolução tela = new TelaDevolução();
            tela.Show();
        }

        
      
        private void tsbtnFidelidade_Click(object sender, EventArgs e)
        {
            TelaPontosFidelidade tela = new TelaPontosFidelidade();
            tela.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TelaTrocarPontos tela = new TelaTrocarPontos();
            tela.ShowDialog();
        }

        private void tsbtnlistacliente_Click(object sender, EventArgs e)
        {
            TelaClientes tela = new TelaClientes();
            tela.ShowDialog();
        }

        private void tsbtnmoto_Click(object sender, EventArgs e)
        {
            TelaMotoqueiro tela = new TelaMotoqueiro();
            tela.ShowDialog();
        }
    }
}
