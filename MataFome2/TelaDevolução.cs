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
    public partial class TelaDevolução : Form
    {
        public TelaDevolução()
        {
            InitializeComponent();
        }

        private void TelaDevolução_Load(object sender, EventArgs e)
        {
            formatarprodutodatagrid();
            desabilitarcampos();
            devolverbutton.Enabled = false;
            ontemnaocheckBox2.Checked = true;
            ontemnaocheckBox2.Focus();
            ontemsimcheckBox1.Enabled = false;
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
            

        }

        private void salvarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idlbtxt.Text.ToString());
            using (var db = new LanchoneteEntityContainer())
            {
                Venda v = db.Venda.FirstOrDefault(u => u.Id == id);
                Cliente c = db.Clientes.FirstOrDefault(u => u.Id == v.ClienteId);
                OperadorCaixa op = db.OperadorCaixas.FirstOrDefault(u => u.Id == v.OperadorCaixaId);
                if (OperadorCache.Operador == op.Id)
                {
                    OperadorCache.Venda = OperadorCache.Venda - v.Total;
                }
                else
                {
                    op.Venda -= v.Total;    
                }
                c.PontosFidelidade--;
                v.Status = "Devolvida";
                double devol = v.Total;
                try
                {
                    db.SaveChanges();
                    MessageBox.Show($"Venda Devolvida com sucesso !");
                    OperadorCache.Venda = OperadorCache.Venda - devol;
                    popularpedidodatagrid();
                    desabilitarcampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }


            }
        }

        private void desabilitarcampos()
        {
            idlbtxt.Enabled = false;
            clientelbtxt.Enabled = false;
            formapaglbtxt.Enabled = false;
            obslbtxt.Enabled = false;
            label8.Enabled = false;
            operadorlbtxt.Enabled = false;
            pedidosdataGridView1.Enabled = false;
            produtosdataGridView2.Enabled = false;
            devolverbutton.Enabled = false;
        }

        private void habilitarcampos()
        {
            idlbtxt.Enabled = true;
            clientelbtxt.Enabled = true;
            formapaglbtxt.Enabled = true;
            obslbtxt.Enabled = true;
            label8.Enabled = true;
            operadorlbtxt.Enabled = true;
            pedidosdataGridView1.Enabled = true;
            produtosdataGridView2.Enabled = true;
            
        }

        private void clientelbtxt_Click(object sender, EventArgs e)
        {

        }

        private void formapaglbtxt_Click(object sender, EventArgs e)
        {

        }

        private void obslbtxt_Click(object sender, EventArgs e)
        {

        }

        private void operadorlbtxt_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pedidosdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void produtosdataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void situacaolb_Click(object sender, EventArgs e)
        {

        }

        private void idlbtxt_Click(object sender, EventArgs e)
        {

        }

        private void popularpedidodatagrid()
        {

            if (ontemnaocheckBox2.Checked == true)
            {
                string data = DateTime.Now.ToShortDateString().ToString();
                using (var db = new LanchoneteEntityContainer())
                {
                    IEnumerable<Venda> lista = from u in db.Venda where u.DataVenda == data && u.Situacao == "3 - Entregue" && u.Status == "Finalizada" select u;
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
                    IEnumerable<Venda> lista = from u in db.Venda where u.DataVenda == dataanterior && u.Situacao == "3 - Entregue" && u.Status == "Finalizada" select u;
                    pedidosdataGridView1.DataSource = lista.ToList();
                }

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
                situacaolb.Text = v.Situacao.ToString();
                statuslb.Text = v.Status.ToString();
            }
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

        private void pedidosdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(pedidosdataGridView1.CurrentRow.Cells[0].Value.ToString());
            procurarVenda(id);
            popularprodutos(id);
            devolverbutton.Enabled = true;
            
        }

        private void statuslb_Click(object sender, EventArgs e)
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
            popularpedidodatagrid();
            habilitarcampos();
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
            
        }
    }
}
