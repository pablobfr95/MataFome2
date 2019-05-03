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
    public partial class TelaPedidos : Form
    {
        public TelaPedidos()
        {
            InitializeComponent();
           
        }

        private void desabilitarcampos()
        {
            idlbtxt.Enabled = false;
            clientelbtxt.Enabled = false;
            formapaglbtxt.Enabled = false;
            situacaocbb.Enabled = false;
            obslbtxt.Enabled = false;
            label8.Enabled = false;
            operadorlbtxt.Enabled = false;
            pedidosdataGridView1.Enabled = false;
            produtosdataGridView2.Enabled = false;
            salvarbutton.Enabled = false;
        }

        private void habilitarcampos()
        {
            idlbtxt.Enabled = true;
            clientelbtxt.Enabled = true;
            formapaglbtxt.Enabled = true;
            situacaocbb.Enabled = true;
            obslbtxt.Enabled = true;
            label8.Enabled = true;
            operadorlbtxt.Enabled = true;
            pedidosdataGridView1.Enabled = true;
            produtosdataGridView2.Enabled = true;
            if (situacao2cbb2.SelectedIndex == 2)
            {
                salvarbutton.Enabled = false;
            }
            else
            {
                salvarbutton.Enabled = true;
            }
            if (situacao2cbb2.SelectedIndex == 0)
            {
                situacaocbb.SelectedIndex = 0;
            }
            else if (situacao2cbb2.SelectedIndex == 1)
            {
                situacaocbb.SelectedIndex = 1;
            }
            else
            {
                situacaocbb.SelectedIndex = 2;
            }
        }

        private void limparCampos()
        {
            idlbtxt.Text = "-";
            clientelbtxt.Text = "-";
            formapaglbtxt.Text = "-";
            obslbtxt.Text = "-";
            label8.Text = "-";
            operadorlbtxt.Text = "-";
            produtosdataGridView2.Rows.Clear();
            situacaocbb.SelectedItem = null;
            situacaocbb.Items.Clear();

        }

        private void TelaPedidos_Load(object sender, EventArgs e)
        {
            formatarprodutodatagrid();
            ontemnaocheckBox2.Focus();
            ontemnaocheckBox2.Checked = true;
            popularsituacaocbb2();
            desabilitarcampos();
        }
        
        private void popularpedidodatagrid()
        {

            if (ontemnaocheckBox2.Checked == true)
            {
                string data = DateTime.Now.ToShortDateString().ToString();
                using (var db = new LanchoneteEntityContainer())
                {
                    string sit2 = situacao2cbb2.Items[situacao2cbb2.SelectedIndex].ToString();
                    IEnumerable<Venda> lista = from u in db.Venda where u.DataVenda == data && u.Situacao == sit2 && u.Status == "Finalizada" select u;
                    pedidosdataGridView1.DataSource = lista.ToList();
                }
            }
            else
            {
                DateTime date = DateTime.Now;
                DateTime date2 = date.AddDays(-1);
                string dataanterior = date2.ToShortDateString().ToString();
                using (var db = new LanchoneteEntityContainer())
                {
                    string sit2 = situacao2cbb2.Items[situacao2cbb2.SelectedIndex].ToString();
                    IEnumerable<Venda> lista = from u in db.Venda where u.DataVenda == dataanterior && u.Situacao == sit2 select u;
                    pedidosdataGridView1.DataSource = lista.ToList();
                }

            }
        }

        private void pedidosdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientelbtxt_Click(object sender, EventArgs e)
        {

        }

        private void formapaglbtxt_Click(object sender, EventArgs e)
        {

        }

        private void produtosdataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formatarprodutodatagrid()
        {
            var grade = produtosdataGridView2;
            grade.AutoGenerateColumns = false;
            grade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera o nome das colunas
            grade.Columns.Add("produto", "Produto");
            grade.Columns.Add("quantidade", "Qtde.");
            grade.Columns.Add("preco", "Preço");
            grade.Columns[0].Width = 160;
            grade.Columns[1].Width = 40;
            grade.Columns[2].Width = 75;
           //formata as colunas valor, vencimento e pagamento
            grade.Columns[2].DefaultCellStyle.Format = "c";
            //não permite seleção de multiplas linhas    
            grade.MultiSelect = false;
            // exibe nulos formatados
            //grade.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            grade.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //define o alinhamamento à direita
            grade.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           

        }

        private void popularprodutos(int idvenda)
        {
            produtosdataGridView2.Rows.Clear();
            using (var db = new LanchoneteEntityContainer())
            {
                IList<ProdutoVenda> lista3 = db.ProdutoVendas.Where(u => u.VendaId == idvenda).ToList();
                foreach (var item in lista3)
                {
                    int idpv = item.Id;
                    ProdutoVenda pv = db.ProdutoVendas.FirstOrDefault(u => u.Id == idpv);
                    int idprod = pv.ProdutoId;
                    Produto p = db.Produtos.FirstOrDefault(u => u.Id == idprod);
                    produtosdataGridView2.Rows.Add(p.NomeProduto.ToString(), pv.Quantidade.ToString(), pv.PrecoVenda.ToString());
                }
            }
        }

        private void popularsituacaocbb2()
        {
            string sit1 = "1 - Pedido em Preparação";
            string sit2 = "2 - Saiu para entrega";
            string sit3 = "3 - Entregue";
            situacao2cbb2.Items.Add(sit1);
            situacao2cbb2.Items.Add(sit2);
            situacao2cbb2.Items.Add(sit3);
        }

        private void popularsituacaocbb()
        {
            string sit1 = "1 - Pedido em Preparação";
            string sit2 = "2 - Saiu para entrega";
            string sit3 = "3 - Entregue";
            situacaocbb.Items.Add(sit1);
            situacaocbb.Items.Add(sit2);
            situacaocbb.Items.Add(sit3);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void obslbtxt_Click(object sender, EventArgs e)
        {

        }

        private void operadorlbtxt_Click(object sender, EventArgs e)
        {

        }

        private void idlbtxt_Click(object sender, EventArgs e)
        {

        }

        private void salvarbutton_Click(object sender, EventArgs e)
        {
            if (produtosdataGridView2.Rows.Count <= 0)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }
           
            using (var db = new LanchoneteEntityContainer())
            {
                int id = Convert.ToInt32(idlbtxt.Text.ToString());
                Venda v = db.Venda.FirstOrDefault(u => u.Id == id);
                string sitnovo = situacaocbb.Items[situacaocbb.SelectedIndex].ToString();
                v.Situacao = sitnovo;
                db.SaveChanges();
                MessageBox.Show(this, "Pedido Atualizado com Sucesso !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                desabilitarcampos();
                this.Close();
                return;
                
            }
        }

        private void procurarVenda(int id)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                Venda v = db.Venda.FirstOrDefault(u => u.Id == id);
                idlbtxt.Text = v.Id.ToString();
                Cliente c = db.Clientes.FirstOrDefault(u => u.Id == v.ClienteId);
                clientelbtxt.Text = c.NomeCliente.ToString();
                FormaPagamento fp = db.FormaPagamentos.FirstOrDefault(u => u.Id == v.FormaPagamentoId);
                formapaglbtxt.Text = fp.Descricao.ToString();
                OperadorCaixa op = db.OperadorCaixas.FirstOrDefault(u => u.Id == v.OperadorCaixaId);
                operadorlbtxt.Text = op.Nome.ToString();
                obslbtxt.Text = v.ObservacaoVenda.ToString();
                label8.Text = $"R$: {v.Total}";
                situacaocbb.SelectedIndex = 0;

            }
        }
        
        private void pedidosdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(pedidosdataGridView1.CurrentRow.Cells[0].Value.ToString());
            procurarVenda(id);
            popularprodutos(id);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void situacao2cbb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void localizarbutton1_Click(object sender, EventArgs e)
        {
            if (ontemnaocheckBox2.Checked == false && ontemsimcheckBox1.Checked == false)
            {
                MessageBox.Show("Marque se os pedidos são do dia anterior !");
                ontemnaocheckBox2.Focus();
                return;
            }
            if (situacao2cbb2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um status de pedido");
                situacao2cbb2.Focus();
                return;
            }
           
            limparCampos();
            popularsituacaocbb();
            habilitarcampos();
            popularpedidodatagrid();
        }
        
        private void ontemsimcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ontemsimcheckBox1.Checked == true)
            {
                ontemnaocheckBox2.Enabled = false;
            }
            else
            {
                ontemnaocheckBox2.Enabled = true;
            }
            //            produtosdataGridView2.Rows.Clear();
            desabilitarcampos();
            
        }

        private void ontemnaocheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ontemnaocheckBox2.Checked == true)
            {
                ontemsimcheckBox1.Enabled = false;
            }
            else
            {
                ontemsimcheckBox1.Enabled = true;
            }
            desabilitarcampos();
        }
    }
}
