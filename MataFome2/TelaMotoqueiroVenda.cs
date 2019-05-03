using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MataFome2
{
    public partial class TelaMotoqueiroVenda : Form
    {
        public TelaMotoqueiroVenda()
        {
            InitializeComponent();
        }

        private void TelaMotoqueiroVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet6Att.Motoqueiros'. Você pode movê-la ou removê-la conforme necessário.
            this.motoqueirosTableAdapter.Fill(this.mataFomeDataSet6Att.Motoqueiros);
            pedidosdataGridView1.Enabled = false;
            produtosdataGridView2.Enabled = false;
            inicio();
            formatarprodutodatagrid();
        }

        private void inicio()
        {
            motoqueiroscbb.Enabled = false;
            salvarbutton.Enabled = false;
            ontemnaocheckBox2.Checked = true;
            naopedidomotocbx.Checked = true;
            pedidosdataGridView1.DataSource = "";
            if (produtosdataGridView2.Rows.Count > -1)
            {
                produtosdataGridView2.Rows.Clear();
            }
        }

        private void popularmotocbb()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Motoqueiros> lista = from u in db.Motoqueiros select u;
                motoqueiroscbb.DataSource = lista.ToList();
                motoqueiroscbb.Refresh();

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

        private void pedidosdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (naopedidomotocbx.Checked == false && simpedidomotocbx.Checked == false)
            {
                MessageBox.Show("Marque se deseja selecionar somente os pedidos sem motoqueiros !");
                naopedidomotocbx.Focus();
                return;
            }
            popularpedidodatagrid();
            pedidosdataGridView1.Enabled = true;

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

        private void popularpedidodatagrid()
        {

            if (ontemnaocheckBox2.Checked == true)
            {
                if (naopedidomotocbx.Checked == true)
                {
                    string data = DateTime.Now.ToShortDateString().ToString();
                    using (var db = new LanchoneteEntityContainer())
                    {

                        IEnumerable<Venda> lista = from u in db.Venda where u.DataVenda == data select u;
                        pedidosdataGridView1.DataSource = lista.ToList();
                    }
                }
                else
                {
                    string data = DateTime.Now.ToShortDateString().ToString();
                    using (var db = new LanchoneteEntityContainer())
                    {

                        IEnumerable<Venda> lista = from u in db.Venda where u.DataVenda == data && u.MotoqueiroId == null select u;
                        pedidosdataGridView1.DataSource = lista.ToList();
                    }
                }
                
            }
            else
            {
                if (naopedidomotocbx.Checked == true)
                {
                    DateTime date = DateTime.Now;
                    DateTime date2 = date.AddDays(-1);
                    string dataanterior = date2.ToShortDateString().ToString();
                    using (var db = new LanchoneteEntityContainer())
                    {

                        IEnumerable<Venda> lista = from u in db.Venda where u.DataVenda == dataanterior select u;
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

                        IEnumerable<Venda> lista = from u in db.Venda where u.DataVenda == dataanterior && u.MotoqueiroId == null select u;
                        pedidosdataGridView1.DataSource = lista.ToList();
                    }
                }
                

            }
        }

        private void ontemnaocheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ontemnaocheckBox2.Checked == true)
            {
                ontemsimcheckBox1.Checked = false;
                ontemsimcheckBox1.Enabled = false;
            }
            else
            {
                ontemsimcheckBox1.Enabled = true;
            }
        }

        private void ontemsimcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ontemsimcheckBox1.Checked == true)
            {
                ontemnaocheckBox2.Checked = false;
                ontemnaocheckBox2.Enabled = false;
            }
            else
            {
                ontemnaocheckBox2.Enabled = true;
            }
        }

        private void idlbtxt_Click(object sender, EventArgs e)
        {

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

        private void produtosdataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void motoqueiroscbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motoqueiroscbb.SelectedIndex > -1)
            {
                salvarbutton.Enabled = true;
            }
           
        }

        private void salvarbutton_Click(object sender, EventArgs e)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                int id = Convert.ToInt32(idlbtxt.Text.ToString());
                Venda v = db.Venda.FirstOrDefault(u => u.Id == id);
                int idmoto = Convert.ToInt32(motoqueiroscbb.SelectedValue.ToString());
                v.MotoqueiroId = idmoto;
                if (motolb.Text != "-")
                {
                    Motoqueiros m2 = db.Motoqueiros.FirstOrDefault(u => u.Nome == motolb.Text.ToString());
                    m2.ValorTotalRecebido -= m2.ValorEntrega;
                    Motoqueiros m = db.Motoqueiros.FirstOrDefault(u => u.Id == idmoto);
                    m.ValorTotalRecebido += m.ValorEntrega;
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Venda Atualizada com sucesso !");
                        MessageBox.Show($"Foi retirado o valor da entrega {v.Id.ToString()} do motoqueiro(a) {m2.Nome.ToString()}, valor de : R$ {m2.ValorEntrega.ToString("C", CultureInfo.CurrentCulture)}" +
                            $" - Valor total Recebido atualizado: R$ {m2.ValorTotalRecebido.ToString("C", CultureInfo.CurrentCulture)}");
                        MessageBox.Show($"Total de valor já recebido pelo motoqueiro(a) {m.Nome.ToString().ToUpper()} : R$ {m.ValorTotalRecebido.ToString("C", CultureInfo.CurrentCulture)}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }
                }
                else
                {
                    Motoqueiros m = db.Motoqueiros.FirstOrDefault(u => u.Id == idmoto);
                    m.ValorTotalRecebido += m.ValorEntrega;
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Venda Atualizada com sucesso !");
                        MessageBox.Show($"Total de valor já recebido pelo {m.Nome.ToString().ToUpper()} : R$ {m.ValorTotalRecebido.ToString("C", CultureInfo.CurrentCulture)}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }
                }
                inicio();
            }
        }

        private void pedidosdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(pedidosdataGridView1.CurrentRow.Cells[0].Value.ToString());
            procurarVenda(id);
            popularprodutos(id);
            motoqueiroscbb.Enabled = true;
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
                bairrolb.Text = c.Bairro.ToString();
                Motoqueiros m = db.Motoqueiros.FirstOrDefault(u => u.Id == v.MotoqueiroId);
                if (m != null)
                {
                    MessageBox.Show("Esse pedido já possui um motoqueiro !");
                    motolb.Text = m.Nome.ToString();
                }
                else
                {
                    motolb.Text = "-";
                }
               
                
            }
        }

        private void bairrolb_Click(object sender, EventArgs e)
        {

        }

        private void motolb_Click(object sender, EventArgs e)
        {

        }

        private void naopedidomotocbx_CheckedChanged(object sender, EventArgs e)
        {
            if (naopedidomotocbx.Checked == true)
            {
                simpedidomotocbx.Checked = false;
                simpedidomotocbx.Enabled = false;
            }
            else
            {
                simpedidomotocbx.Enabled = true;
            }
        }

        private void simpedidomotocbx_CheckedChanged(object sender, EventArgs e)
        {
            if (simpedidomotocbx.Checked == true)
            {
                naopedidomotocbx.Checked = false;
                naopedidomotocbx.Enabled = false;
            }
            else
            {
                naopedidomotocbx.Enabled = true;
            }
        }
    }
}
