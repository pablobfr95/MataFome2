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
    public partial class TelaPontosFidelidade : Form
    {
        public TelaPontosFidelidade()
        {
            InitializeComponent();
        }

        private void TelaPontosFidelidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet4.ProdutosFidelidades'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosFidelidadesTableAdapter.Fill(this.mataFomeDataSet4.ProdutosFidelidades);

            populardatagrid();
            salvarbutton1.Enabled = true;
            attbuton.Enabled = false;

        }

        private void populardatagrid()
        {
            var grade = dataGridView1;
            grade.Columns[0].Width = 212;
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<ProdutosFidelidade> lista = db.ProdutosFidelidades.OrderBy(u => u.QtdePontos);
                dataGridView1.DataSource = lista.ToList();

            }
        }

        private void descricaoprodutotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (descricaoprodutotxt.Text == "" || descricaoprodutotxt.Text == null)
            {
                MessageBox.Show("Digite uma descrição para o Produto !");
                return;
            }
            if (qtdepontostxt.Text == "" || qtdepontostxt.Text == null)
            {
                MessageBox.Show("Digite uma quantidade para o Produto !");
                return;
            }
            ProdutosFidelidade p = new ProdutosFidelidade();
            p.DescricaoProduto = descricaoprodutotxt.Text.ToString();
            p.QtdePontos = Convert.ToInt32(qtdepontostxt.Text.ToString());
            using (var db = new LanchoneteEntityContainer())
            {
                try
                {
                    db.ProdutosFidelidades.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Produto Cadastrado com sucesso !");
                    populardatagrid();
                    qtdepontostxt.Text = "";
                    descricaoprodutotxt.Text = "";
                    return;
                    
                }
                catch (Exception)
                {

                    throw;
                }

            }


        }

        private void qtdepontostxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                string descricao = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ProdutosFidelidade p = db.ProdutosFidelidades.FirstOrDefault(u => u.DescricaoProduto == descricao);
                descricaoprodutotxt.Text = p.DescricaoProduto.ToString();
                qtdepontostxt.Text = p.QtdePontos.ToString();
                salvarbutton1.Enabled = false;
                attbuton.Enabled = true;
 
            }
        }

        private void attbuton_Click(object sender, EventArgs e)
        {
            if (descricaoprodutotxt.Text == "" || descricaoprodutotxt.Text == null)
            {
                MessageBox.Show("Digite uma descrição para o Produto !");
                return;
            }
            if (qtdepontostxt.Text == "" || qtdepontostxt.Text == null)
            {
                MessageBox.Show("Digite uma quantidade para o Produto !");
                return;
            }

            
            using (var db = new LanchoneteEntityContainer())
            {
                string descricao = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ProdutosFidelidade p = db.ProdutosFidelidades.FirstOrDefault(u => u.DescricaoProduto == descricao);
                p.DescricaoProduto = descricaoprodutotxt.Text.ToString();
                p.QtdePontos = Convert.ToInt32(qtdepontostxt.Text);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Produto Atualizado com sucesso !");
                    salvarbutton1.Enabled = true;
                    attbuton.Enabled = false;
                    dataGridView1.Enabled = false;
                    dataGridView1.Enabled = true;
                    populardatagrid();
                    descricaoprodutotxt.Text = "";
                    qtdepontostxt.Text = "";
                    return;
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }

        private void qtdepontostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
