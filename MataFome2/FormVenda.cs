using MataFome2.Cache;
using MataFome2.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MataFome2
{
    public partial class FormVenda : Form
    {
        ClienteController clicon = new ClienteController(); 

        public FormVenda()
        {
            InitializeComponent();
        }

        private void habilitarcampos()
        {
            nomeclientetxt.Enabled = true;
            enderecoclientetxt.Enabled = true;
            bairroclientetxt.Enabled = true;
            municipioclientetxt.Enabled = true;
            obsclientetxt.Enabled = true;
            comboBox1.Enabled = true;
            qtdeprodutotxt.Enabled = true;
           totallabel.Enabled = true;
            groupBox3.Enabled = true;
            txentregatxt.Enabled = true;
            

        }
        
        private void desabilitarcampos()
        {
            nomeclientetxt.Enabled = false;
            complementotxt.Enabled = false;
            enderecoclientetxt.Enabled = false;
            bairroclientetxt.Enabled = false;
            municipioclientetxt.Enabled = false;
            obsclientetxt.Enabled = false;
            comboBox1.Enabled = false;
            qtdeprodutotxt.Enabled = false;
            totallabel.Enabled = false;
            groupBox3.Enabled = false;
            obsvendatextBox1.Enabled = false;
            formapagamentocomboBox2.Enabled = false;
            finalizarvendabutton.Enabled = false;
            txentregatxt.Enabled = false;
            naodescontocb.Checked = true;
            simdescontocb.Enabled = false;
            txentregacb.Enabled = false;
            outrodescontocb.Enabled = false;
            valordescontotxt.Enabled = false;
            fpvalor1.Enabled = false;
            fpvalor1.Visible = false;
            fpvalor2.Enabled = false;
            fpvalor2.Visible = false;
           formapagamento2attcbb.Visible = false;
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet5att.FormaPagamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.formaPagamentosTableAdapter1.Fill(this.mataFomeDataSet5att.FormaPagamentos);
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet1.FormaPagamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.formaPagamentosTableAdapter.Fill(this.mataFomeDataSet1.FormaPagamentos);
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter1.Fill(this.mataFomeDataSet1.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet.ProdutoVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoVendasTableAdapter.Fill(this.mataFomeDataSet.ProdutoVendas);
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet.ProdutoVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoVendasTableAdapter.Fill(this.mataFomeDataSet.ProdutoVendas);
            formataGridView();
            preencherCombobox();
            button1.Enabled = false;
            desabilitarcampos();
            valorpagotextBox1.Enabled = false;
            toolStripStatusLabel2.Text = $"Usuário: {UsuarioCache.Login.ToString()}";
        }

        private void ListaItensGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formataGridView()
        {
            var grade = ListaItensGridView1;
            grade.AutoGenerateColumns = false;
            grade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            grade.RowsDefaultCellStyle.BackColor = Color.White;
            grade.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
            //altera o nome das colunas
            grade.Columns[0].HeaderText = "Produto";
            grade.Columns[1].HeaderText = "Qtde.";
            grade.Columns[2].HeaderText = "Preço";
            grade.Columns[3].HeaderText = "Total";
            grade.Columns[0].Width = 212;
            grade.Columns[1].Width = 50;
            grade.Columns[2].Width = 75;
            grade.Columns[3].Width = 75;

            //formata as colunas valor, vencimento e pagamento
            grade.Columns[3].DefaultCellStyle.Format = "c";
           
            //seleciona a linha inteira
            grade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas    
            grade.MultiSelect = false;
            // exibe nulos formatados
            //grade.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            grade.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //define o alinhamamento à direita
            grade.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grade.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
        }

        private void preencherCombobox()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Produto> lista = from u in db.Produtos select u;
                comboBox1.DataSource = lista.ToList();

            }
            
        }

        private void preencherComboboxFormadePagamento()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<FormaPagamento> lista = from u in db.FormaPagamentos select u;
                formapagamentocomboBox2.DataSource = lista.ToList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        
        private void button1_Click(object sender, EventArgs e)

        {
            string nome = comboBox1.Text;
            using (var db = new LanchoneteEntityContainer())
            {

                Produto p = db.Produtos.First(u => u.NomeProduto == nome);
                ProdutoVenda pv = new ProdutoVenda();
                pv.ProdutoId = p.Id;
                decimal preco = Convert.ToDecimal(p.PrecoUnitario);
                if (qtdeprodutotxt.Text == "" || qtdeprodutotxt.Text == null)
                {
                    MessageBox.Show(this, "Digite uma quantidade !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    qtdeprodutotxt.Focus();
                    return;
                }
                int quantidade = Convert.ToInt32(qtdeprodutotxt.Text);
                decimal total = preco * quantidade;
                ListaItensGridView1.Rows.Add(p.NomeProduto.ToString(),qtdeprodutotxt.Text, p.PrecoUnitario.ToString(), total);
                CalcularTotal();

            }
            valorpagotextBox1.Enabled = true;
        }

        private void qtdeprodutotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txentregatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcularTotal()
        {
            try
            {
                double valorTotal = 0;
                double taxaentrega = 0;
                if (ListaItensGridView1.Rows.Count < 1)
                {
                    return;
                }
                for (int i = 0; i <= ListaItensGridView1.RowCount -1 ; i++)
                {
                    valorTotal += Convert.ToDouble(ListaItensGridView1.Rows[i].Cells[3].Value);
                    if (txentregacb.Checked == true)
                    {
                        totallabel.Text = $"R$:{(valorTotal).ToString()}";
                    }
                    else if (outrodescontocb.Checked == true)
                    {
                        double desconto = Convert.ToDouble(valordescontotxt.Text.ToString());
                        taxaentrega = Convert.ToDouble(txentregatxt.Text.Substring(4));
                        totallabel.Text = $"R$:{(valorTotal + taxaentrega - desconto).ToString()}";
                    }
                    else
                    {
                        taxaentrega = Convert.ToDouble(txentregatxt.Text.Substring(4));
                        totallabel.Text = $"R$:{(valorTotal + taxaentrega).ToString()}";
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ListaItensGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaItensGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotal();
            if (ListaItensGridView1.Rows.Count < 1)
            {
                finalizarvendabutton.Enabled = false;
                double vtot = 0;
                double txentrega = Convert.ToDouble(txentregatxt.Text.Substring(4));
                if (txentregacb.Checked == true)
                {
                    totallabel.Text = $"R$:{(vtot).ToString()}";
                }
                else
                {
                    totallabel.Text = $"R$:{(vtot + txentrega).ToString()}";
                }
                
                
            }
        }

        private void ListaItensGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularTotal();
        }

        private void telclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void obsclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void enderecoclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bairroclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void municipioclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telclientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                Cliente cli = new Cliente();
                int tel = Convert.ToInt32(telclientetxt.Text);
                cli.Telefone = tel;
                if (clicon.procurarCliente(tel) == true)
                {
                    habilitarcampos();
                    nomeclientetxt.ReadOnly = true;
                    enderecoclientetxt.ReadOnly = true;
                    enderecoclientetxt.ReadOnly = true;
                    bairroclientetxt.ReadOnly = true;
                    municipioclientetxt.ReadOnly = true;
                    txentregatxt.ReadOnly = true;
                    obsclientetxt.ReadOnly = true;
                    nclientetxt.ReadOnly = true;
                    ptntextBox1.ReadOnly = true;
                    complementotxt.ReadOnly = true;
                    comboBox1.Focus();
                    using (var db  = new LanchoneteEntityContainer())
                    {
                        Cliente c = db.Clientes.FirstOrDefault(u => u.Telefone == tel);
                        nomeclientetxt.Text = c.NomeCliente.ToString();
                        enderecoclientetxt.Text = c.Endereco.ToString();
                        bairroclientetxt.Text = c.Bairro.ToString();
                        municipioclientetxt.Text = c.Municipio.ToString();
                        nclientetxt.Text = c.Numero.ToString();
                        txentregatxt.Text = $"R$: {c.TaxaEntrega.ToString()}";
                        ptntextBox1.Text = c.PontosFidelidade.ToString();
                        if (c.Complemento == null)
                        {
                            complementotxt.Text = "";
                        }
                        else
                        {
                            complementotxt.Text = c.Complemento.ToString();
                        }
                        if (c.Observacao == null)
                        {
                            obsclientetxt.Text = "";
                        }
                        else
                        {
                            obsclientetxt.Text = c.Observacao.ToString();
                        }

                        IList<ProdutosFidelidade> lista = db.ProdutosFidelidades.Where(u => u.QtdePontos <= c.PontosFidelidade).ToList();
                        
                        if (lista.Count > 0)
                        {
                            MessageBox.Show("Este cliente já pode trocar seus pontos de fidelidade por algum produto !");
                          
                        }

                        IEnumerable<Venda> lista3 = db.Venda.Where(u => u.ClienteId == c.Id).OrderByDescending(t => t.Id);
                        int qtlista = lista3.Count();
                        if (qtlista < 1)
                        {
                            return;
                        }
                        Venda v = lista3.Take(1).Single();
                        if (v != null)
                        {
                            DialogResult dg = MessageBox.Show(this, "Deseja Repetir o último pedido ?", "Aviso", MessageBoxButtons.YesNo);
                            if (dg == DialogResult.Yes)
                            {
                                IEnumerable<ProdutoVenda> pd = db.ProdutoVendas.Where(u => u.VendaId == v.Id);
                               
                                foreach (var item in pd)
                                {
                                    Produto p = db.Produtos.FirstOrDefault(u => u.Id == item.ProdutoId);
                                    ListaItensGridView1.Rows.Add(p.NomeProduto, item.Quantidade, p.PrecoUnitario, item.PrecoVenda);
                                }
                                double totalapresentado = Convert.ToDouble(totallabel.Text.Substring(3));
                                if (totalapresentado != v.Total)
                                {
                                    MessageBox.Show("Você aplicou algum tipo de desconto, verifique qual foi o desconto !");
                                    if ((totalapresentado - v.Total) == c.TaxaEntrega)
                                    {
                                        DialogResult dg2 = MessageBox.Show(this, "O Desconto aplicado foi a taxa de entrega, Deseja Aplicar Novamente ?", "Aviso", MessageBoxButtons.YesNo);
                                        if (dg2 == DialogResult.Yes)
                                        {
                                            naodescontocb.Checked = false;
                                            simdescontocb.Enabled = true;
                                            simdescontocb.Checked = true;
                                            txentregacb.Enabled = true;
                                            txentregacb.Checked = true;
                                            
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show($"O Total da Venda Anterior foi : R$ {v.Total.ToString()}");
                                        MessageBox.Show($"O desconto anterior foi de :R$ {totalapresentado - v.Total}");
                                        DialogResult dg3 = MessageBox.Show(this,"Deseja aplicar o mesmo desconto ?","Aviso", MessageBoxButtons.YesNo);
                                        if (dg3 == DialogResult.Yes)
                                        {
                                         naodescontocb.Checked = false;
                                          simdescontocb.Enabled = true;
                                         simdescontocb.Checked = true;
                                         outrodescontocb.Enabled = true;
                                            outrodescontocb.Checked = true;
                                         valordescontotxt.Enabled = true;
                                          valordescontotxt.Text = (totalapresentado - v.Total).ToString();
                                            valordescontotxt.Focus();
                                         
                                        }
                                    }

                                }

                                valorpagotextBox1.Enabled = true;
                                button1.Enabled = true;

                            }
                        }



                    }
                }
                else
                {
                  DialogResult d = MessageBox.Show(this, "Telefone não cadastrado, deseja Cadastrar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == System.Windows.Forms.DialogResult.Yes)
                    {
                        TelaCadastroUsuario tela = new TelaCadastroUsuario();
                        tela.ShowDialog();
                        
                    }
                }

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void totallabel_Click(object sender, EventArgs e)
        {

        }

        private void valorpagotextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trocolabel12_Click(object sender, EventArgs e)
        {

        }

        private void Calculartroco()
        {
            string vtotal = totallabel.Text.Substring(3);
            double total = Convert.ToDouble(vtotal);
            string valorpagoletras = valorpagotextBox1.Text.ToString();
            if (valorpagoletras == null || valorpagoletras == "")
            {
                MessageBox.Show("Digite um valor para ser calculado o troco !");
                
                return;
               
            }
            double valorpago = Convert.ToDouble(valorpagoletras);
            double troco = valorpago - total;
            trocolabel12.Text = $"R$: {troco.ToString()}";
        }

        private void CalcularTroco2()
        {
            string vtotal = totallabel.Text.Substring(3);
            double total = Convert.ToDouble(vtotal);
            double vpago = Convert.ToDouble(fpvalor1.Text.ToString());
            if (vpago >= total)
            {
                double troco = vpago - total;
                fplabel10.Text = Formapagamentocache.Forma1;
                valorpagotextBox1.Text = vpago.ToString();
                trocolabel12.Text = $"R$: {troco.ToString()}";
                formapagamento2attcbb.Enabled = false;
                fpvalor2.Clear();
                fpvalor2.Enabled = false;
                finalizarvendabutton.Enabled = true;
                finalizarvendabutton.Focus();
                
                
            }
            else
            {
                double restante = total - vpago;
                formapagamento2attcbb.Enabled = true;
                
                formapagamento2attcbb.Focus();
                valorpagotextBox1.Clear();   
            }
   
            
        }

        private void CalcularTroco3()
        {
            string vtotal = totallabel.Text.Substring(3);
            double total = Convert.ToDouble(vtotal);
            double pag1 = Convert.ToDouble(fpvalor1.Text.ToString());
            double pag2 = Convert.ToDouble(fpvalor2.Text.ToString());
            if ((pag1 + pag2) < total)
            {
                MessageBox.Show("Não é possivel finalizar uma venda com o valor Pago menor que o valor Total !");
                return;
            }
            double restante = total - pag1;
            
            double troco = pag2 - restante;
            trocolabel12.Text = $"R$: {troco.ToString()}";
            finalizarvendabutton.Enabled = true;
            valorpagotextBox1.Clear();
            finalizarvendabutton.Focus();






        }
        private void valorpagotextBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void valorpagotextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if (valorpagotextBox1.Text == "" || valorpagotextBox1 == null)
                {
                    MessageBox.Show("Digite um valor para ser calculado o troco !");
                    return;
                }
                Calculartroco();
                double vpago = Convert.ToDouble(valorpagotextBox1.Text.ToString());
                double total = Convert.ToDouble(totallabel.Text.Substring(3));
                if (vpago > total || vpago == total)
                {
                    formapagamentocomboBox2.Enabled = true;
                    obsvendatextBox1.Enabled = true;
                    formapagamentocomboBox2_SelectedIndexChanged(sender, e);
                    formapagamentocomboBox2.Focus();
                    
                }
                else
                {
                    MessageBox.Show("Valor pago é menor que o valor do pedido !");
                    valorpagotextBox1.Focus();
                    formapagamentocomboBox2.Enabled = false;
                    obsvendatextBox1.Enabled = false;
                    finalizarvendabutton.Enabled = false;
                    return;
                }
               
                
            }


        }
        
        private void imprimir()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;        

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Recibo);

            printDocument.Print();

            printDialog.Dispose();
            this.Show();
            return;
           
        }
        
        private void Recibo(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 8, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up
           
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 30;
            var data = DateTime.Now.ToLongDateString().ToString();

            graphic.DrawString("    Mata Fome Petisco".PadLeft(4), new Font("Courier New", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("CNPJ:33.219.881/0001-95 ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 18;
            graphic.DrawString("Contato:99189-1794 / 99312-1226", new Font("Courier New", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 18;
            graphic.DrawString(data, new Font("Courier New", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 18;
            graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Pedido: {VendaCache.Idvenda}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            string top = "Item".PadRight(22) + "Qtde".PadRight(8) + "Preço";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            for (int i = 0; i < ListaItensGridView1.RowCount; i++)
            {
                string produto = ListaItensGridView1.Rows[i].Cells[0].Value.ToString();
                int letras = produto.Length;
                int qtdelinhas = letras / 18;

                int rest = letras % 19;
                

                if (qtdelinhas <= 1)
                {
                    string quantidade = ListaItensGridView1.Rows[i].Cells[1].Value.ToString();
                    string total = ListaItensGridView1.Rows[i].Cells[3].Value.ToString();
                    string linha = produto.PadRight(25) + quantidade.PadRight(5) + "R$: " + total;
                    graphic.DrawString(linha, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;

                }
                else if (qtdelinhas == 2)
                {
                    string linha1 = produto.Substring(0, 19).ToString();
                    string linha2 = produto.Substring(19, rest).ToString();
                    string quantidade = ListaItensGridView1.Rows[i].Cells[1].Value.ToString();
                    string total = ListaItensGridView1.Rows[i].Cells[3].Value.ToString();
                    string linhafinal = linha1.PadRight(25) + quantidade.PadRight(5) + "R$: " + total;
                    graphic.DrawString(linhafinal, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha2, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                }
                else if (qtdelinhas == 3)
                {
                    string linha1 = produto.Substring(0, 19).ToString();
                    string linha2 = produto.Substring(19, 19).ToString();
                    string linha3 = produto.Substring(38, rest).ToString();
                    string quantidade = ListaItensGridView1.Rows[i].Cells[1].Value.ToString();
                    string total = ListaItensGridView1.Rows[i].Cells[3].Value.ToString();
                    string linhafinal = linha1.PadRight(23) + quantidade.PadRight(5) + "R$:" + total;
                    graphic.DrawString(linhafinal, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha2, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha3, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                }
                else if (qtdelinhas == 4)
                {
                    string linha1 = produto.Substring(0, 19).ToString();
                    string linha2 = produto.Substring(19, 19).ToString();
                    string linha3 = produto.Substring(38, 19).ToString();
                    string linha4 = produto.Substring(57, rest).ToString();
                    string quantidade = ListaItensGridView1.Rows[i].Cells[1].Value.ToString();
                    string total = ListaItensGridView1.Rows[i].Cells[3].Value.ToString();
                    string linhafinal = linha1.PadRight(23) + quantidade.PadRight(5) + "R$:" + total;
                    graphic.DrawString(linhafinal, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha2, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha3, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha4, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                }
                else if (qtdelinhas == 5)
                {
                    string linha1 = produto.Substring(0, 19).ToString();
                    string linha2 = produto.Substring(19, 19).ToString();
                    string linha3 = produto.Substring(38, 19).ToString();
                    string linha4 = produto.Substring(57, 19).ToString();
                    string linha5 = produto.Substring(76, rest).ToString();
                    string quantidade = ListaItensGridView1.Rows[i].Cells[1].Value.ToString();
                    string total = ListaItensGridView1.Rows[i].Cells[3].Value.ToString();
                    string linhafinal = linha1.PadRight(23) + quantidade.PadRight(5) + "R$:" + total;
                    graphic.DrawString(linhafinal, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha2, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha3, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha4, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha5, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;

                }
                else
                {
                    string linha1 = produto.Substring(0, 19).ToString();
                    string linha2 = produto.Substring(19, 19).ToString();
                    string linha3 = produto.Substring(38, 19).ToString();
                    string linha4 = produto.Substring(57, 19).ToString();
                    string linha5 = produto.Substring(76, 19).ToString();
                    string linha6 = produto.Substring(95, 15).ToString() + "...";
                    string quantidade = ListaItensGridView1.Rows[i].Cells[1].Value.ToString();
                    string total = ListaItensGridView1.Rows[i].Cells[3].Value.ToString();
                    string linhafinal = linha1.PadRight(23) + quantidade.PadRight(5) + "R$:" + total;
                    graphic.DrawString(linhafinal, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha2, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha3, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha4, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha5, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(linha6, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight;
                }


            }
            if (outrodescontocb.Checked == true)
            {
                graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString("Desconto".PadRight(30)+$"R$: {valordescontotxt.Text.ToString()}", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            if (txentregacb.Checked == true)
            {
                graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString("Sem Taxa de Entrega !", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            
            graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            string observacao = obsvendatextBox1.Text.ToString();
            int qtdeletras = observacao.Length;
            if (qtdeletras <= 20)
            {
                graphic.DrawString($"Obs.:  {observacao.ToString()} ", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else if (qtdeletras > 20 && qtdeletras < 40)
            {
                int rest = qtdeletras % 20;
                string linha1 = observacao.Substring(0, 20);
                string linha2 = observacao.Substring(20,rest);
                graphic.DrawString($"Obs.: {linha1}", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"      {linha2}", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else if (qtdeletras < 1)
            {
                graphic.DrawString($"Obs.: Nenhuma", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else
            {
                int rest = qtdeletras % 20;
                string linha1 = observacao.Substring(0, 20);
                string linha2 = observacao.Substring(20, 20);
                
                graphic.DrawString($"Obs.: {linha1}", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"      {linha2}...", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                
            }
            
            graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;
            string formapagamento = fplabel10.Text.ToString();
            int letras3 = formapagamento.Length;
            int resto2 = letras3 % 13;
            int rest3 = letras3 % 15;
            if (letras3 <= 13)
            {
                graphic.DrawString($"Forma de Pag.: {formapagamento}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else if (letras3 > 13 && letras3 < 26 )
            {

                graphic.DrawString($"Forma de Pag.: {formapagamento.Substring(0,13)}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"{formapagamento.Substring(13,resto2)}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else if (letras3 >= 26 && letras3 < 39 )
            {
                graphic.DrawString($"Forma de Pag.: {formapagamento.Substring(0, 13)}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"{formapagamento.Substring(13)}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else
            {
                graphic.DrawString($"Forma de Pag.: {formapagamento.Substring(0, 13)}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"{formapagamento.Substring(13,23)}...", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
           
            string total2 = $"Total: R$ {totallabel.Text.Substring(3)}";
            string valorpago = valorpagotextBox1.Text.ToString();
            graphic.DrawString(total2, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            if (valorpago == null || valorpago == "")
            {
                double v1 = Convert.ToDouble(fpvalor1.Text.ToString());
                double v2 = Convert.ToDouble(fpvalor2.Text.ToString());
                string formaoriginal = fplabel10.Text.ToString();
                int posquebra = formaoriginal.IndexOf("/");
                string forma1 = formaoriginal.Substring(0, posquebra);
                string forma2 = formaoriginal.Substring(posquebra + 1);

                string vpago1 = $"Valor pago em {forma1}:R$ {v1}";
                if (vpago1.Length > 28)
                {
                    graphic.DrawString(vpago1.Substring(0,28), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5;
                    graphic.DrawString(vpago1.Substring(28), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5;
                }
                else
                {
                    graphic.DrawString(vpago1, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5;
                }
               
                string vpago2 = $"Valor pago em {forma2}:R$ {v2}";
                if (vpago2.Length > 28)
                {
                    graphic.DrawString(vpago2.Substring(0, 28), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5;
                    graphic.DrawString(vpago2.Substring(28), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5;
                }
                else
                {
                    graphic.DrawString(vpago2, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5;
                }
                string troco = trocolabel12.Text.ToString();
               
                graphic.DrawString($"Troco:{troco}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else
            {
                string vpago = $"Valor Pago: R$ {Convert.ToDouble(valorpagotextBox1.Text.ToString())}";
                string troco = trocolabel12.Text.ToString();
                graphic.DrawString(vpago, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"Troco:{troco}", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            string cliente = nomeclientetxt.Text.ToString();
            int tamcliente = cliente.Length;
            int resttam = tamcliente % 23;
            if (tamcliente < 23)
            {
                graphic.DrawString($"Cliente: {nomeclientetxt.Text.ToString().ToUpper().Substring(0, resttam)}", new Font("Courier New", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else if (tamcliente >= 23 && tamcliente < 46)
            {
                graphic.DrawString($"Cliente: {nomeclientetxt.Text.ToString().ToUpper().Substring(0, 23)}", new Font("Courier New", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString("         " + nomeclientetxt.Text.ToString().ToUpper().Substring(23, resttam), new Font("Courier New", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else
            {
                graphic.DrawString($"Cliente: {nomeclientetxt.Text.ToString().ToUpper().Substring(0, 23)}", new Font("Courier New", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString("         " + nomeclientetxt.Text.ToString().ToUpper().Substring(23, 23) + "...", new Font("Courier New", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            
            string endcli = enderecoclientetxt.Text.ToUpper().ToString();
            int resto = endcli.Length % 23;
            if (endcli.Length > 23 && endcli.Length < 46)
            {
                string linhaend = endcli.Substring(0, 23);
                string linha2end = endcli.Substring(23, resto) + "...";
                graphic.DrawString($"Endereço: {linhaend}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString(linha2end + " - Numero: " + nclientetxt.Text.ToString(), new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else if (endcli.Length <= 23)
            {
                graphic.DrawString($"Endereço: {endcli}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString(" - Numero: " + nclientetxt.Text.ToString(), new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else
            {
                string linhaend = endcli.Substring(0, 23);
                string linha2end = endcli.Substring(23, 23) + "...";
                graphic.DrawString($"Endereço: {linhaend}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString(linha2end + " - Numero: " + nclientetxt.Text.ToString(), new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;

            }
            string comple = complementotxt.Text.ToString();
            int letrascomple = comple.Length;
            int restcomple = letrascomple % 20;
            if (letrascomple <= 20)
            {
                graphic.DrawString($"Complemento: {comple}", new Font("Courier New", 8,FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else if (letrascomple > 20 && letrascomple <40)
            {
                graphic.DrawString($"Complemento: {comple.Substring(0,20)}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"{comple.Substring(20, restcomple)}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else
            {
                graphic.DrawString($"Complemento: {comple.Substring(0, 20)}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"{comple.Substring(20,20)}...", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
           
            string obs = obsclientetxt.Text.ToString();
            int restobs = obs.Length % 23;
            if (obs.Length < 23)
            {
                graphic.DrawString($"Observação: {obs.ToLower()}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else if (obs.Length >= 23 && obs.Length < 46)
            {
                graphic.DrawString($"Observação: {obs.ToLower().Substring(0,23)}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"{obs.ToLower().Substring(23, restobs)}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
            else
            {
                graphic.DrawString($"Observação: {obs.ToLower().Substring(0, 23)}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString($"{obs.ToLower().Substring(23,23)} + ....", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;

            }
            graphic.DrawString($"Bairro: {bairroclientetxt.Text.ToUpper().ToString()}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Municipio: {municipioclientetxt.Text.ToUpper().ToString()}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Telefone: {telclientetxt.Text.ToString()}", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;
            graphic.DrawString("OBRIGADO PELA PREFERÊNCIA !!", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("======================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("ESTE DOCUMENTO NÃO VALE COMO CUPOM FISCAL !", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;



        }
        
        private void criarPDF()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string sistema = "Delivery";
            string diretorio = "Recibo Venda";
            string Mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dir = $"{Mydocument}/{sistema}/{diretorio}/{ano}/{mes}/{dia}";
            bool existe = Directory.Exists(dir);
            if (existe == false)
            {
                Directory.CreateDirectory(dir);
            }
            

            string file = $"Pedido nº{VendaCache.Idvenda}.pdf";

            PrintDocument pDoc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true,
                    PrintFileName = System.IO.Path.Combine(dir, file),
                }
            };

            pDoc.PrintPage += new PrintPageEventHandler(Recibo);
            pDoc.Print();
        }

        private void finalizarvendabutton_Click(object sender, EventArgs e)
        {
            string troco = trocolabel12.Text.Substring(4);
            double dtroco = Convert.ToDouble(troco);
            string dpago1 = valorpagotextBox1.Text.ToString();
            double dpago = 0;
            if (dpago1 == null || dpago1 == "")
            {
                double paga1 = Convert.ToDouble(fpvalor1.Text.ToString());
                double paga2 = Convert.ToDouble(fpvalor2.Text.ToString());

                dpago = paga1 + paga2;
            }
            else
            {
                dpago = Convert.ToDouble(dpago1);
            }
            string vtot = totallabel.Text.Substring(3);
            double tot = Convert.ToDouble(vtot);
            double txentrega = Convert.ToDouble(txentregatxt.Text.Substring(3));
            if (tot < 0)
            {
                MessageBox.Show("Não se pode finalizar com um valor total negativo !");
                comboBox1.Focus();
                return;

            }
            if (ListaItensGridView1.Rows.Count < 1)
            {
                MessageBox.Show("escolha pelo menos um produto para poder realizar o pedido !");
                return;
            }
            if ((dpago - dtroco) != tot )
            {
                MessageBox.Show("Calculo do troco está errado, atualize novamente o troco apertando enter no valor pago para o programa atualizar !");
                return;
            }
            
            using (var db = new LanchoneteEntityContainer())
            {
                int hora = Convert.ToInt32(DateTime.Now.Hour.ToString());
                DateTime date = DateTime.Now;
                DateTime date2 = date.AddDays(-1);
                string dataanterior = date2.ToShortDateString().ToString();
                Venda v = new Venda();
                    string vtotal = totallabel.Text.Substring(3);
                    double total = Convert.ToDouble(vtotal);
                    int tel = Convert.ToInt32(telclientetxt.Text);
                    Cliente c = db.Clientes.FirstOrDefault(u => u.Telefone == tel);
                    FormaPagamento fp = db.FormaPagamentos.FirstOrDefault(u => u.Descricao == fplabel10.Text);
                    v.ClienteId = c.Id;
                if (hora < 3)
                {
                    v.DataVenda = dataanterior;
                    v.DataComparadora = date2;
                }
                else
                {
                    v.DataVenda = DateTime.Now.ToShortDateString().ToString();
                    v.DataComparadora = date;

                }
                if (fp != null)
                {
                    v.FormaPagamentoId = fp.Id;

                }
                else
                {
                    string formaoriginal = fplabel10.Text.ToString();
                    int pos = formaoriginal.IndexOf("/");
                    string forma = formaoriginal.Substring(0, pos);
                    FormaPagamento fp4 = db.FormaPagamentos.FirstOrDefault(u => u.Descricao == forma);
                    v.FormaPagamentoId = fp4.Id;
                }


                    if (obsvendatextBox1.Text == "" || obsvendatextBox1.Text == null)
                    {
                    v.ObservacaoVenda = "Nenhum";
                    }
                    else
                    {
                    v.ObservacaoVenda = obsvendatextBox1.Text;
                    }
                    v.OperadorCaixaId = OperadorCache.Operador;
                    v.Situacao = "1 - Pedido em Preparação";
                    v.Status = "Finalizada";
                v.TaxaEntregaVenda = c.TaxaEntrega;
                v.Total = total;
                    OperadorCache.Venda += total;
                if (c.ContadorVendas == null)
                {
                    c.ContadorVendas = 0;
                }
                c.PontosFidelidade++;
               
                if (c.TotalGasto == null)
                {
                    c.TotalGasto = 0;
                }
               
                try
                {
                    db.Venda.Add(v);
                    db.SaveChanges();
                    Venda v2 = db.Venda.OrderByDescending(u => u.Id).First();
                    VendaCache.Idvenda = v2.Id;
                    
                    if (fpvalor2.Enabled == true)
                    {
                        string formaoriginal = fplabel10.Text.ToString();
                        int pos = formaoriginal.IndexOf("/");
                        string forma1 = formaoriginal.Substring(0, pos);
                        string forma2 = formaoriginal.Substring(pos+1);
                        FormaPagamento fp2 = db.FormaPagamentos.FirstOrDefault(u => u.Descricao == forma1);
                        FormaPagamento fp3 = db.FormaPagamentos.FirstOrDefault(u => u.Descricao == forma2);
                        for (int i = 0; i < 2; i++)
                        {
                            if (i == 0)
                            {
                                PagamentoVenda pg = new PagamentoVenda();
                                pg.Descricao = fp2.Descricao;
                                pg.VendaId = v2.Id;
                                pg.FormaPagamentoId = fp2.Id;
                                db.PagamentoVenda.Add(pg);
                                db.SaveChanges();
                            }
                            else
                            {
                                PagamentoVenda pg = new PagamentoVenda();
                                pg.Descricao = fp3.Descricao;
                                pg.VendaId = v2.Id;
                                pg.FormaPagamentoId = fp3.Id;
                                db.PagamentoVenda.Add(pg);
                                db.SaveChanges();
                            }
                        }

                    }
                    else
                    {
                        PagamentoVenda pg = new PagamentoVenda();
                        pg.Descricao = fp.Descricao;
                        pg.VendaId = v2.Id;
                        pg.FormaPagamentoId = fp.Id;
                        db.PagamentoVenda.Add(pg);
                        db.SaveChanges();
                    }
                    
                    for (
                        int i = 0; i < ListaItensGridView1.RowCount; i++)
                    {

                        string prd = ListaItensGridView1.Rows[i].Cells[0].Value.ToString();
                        ProdutoVenda pv = new ProdutoVenda();
                        Produto p = db.Produtos.FirstOrDefault(u => u.NomeProduto == prd);
                        pv.ProdutoId = p.Id;
                        pv.VendaId = v.Id;
                        pv.Quantidade = Convert.ToInt32(ListaItensGridView1.Rows[i].Cells[1].Value);
                        pv.PrecoVenda = Convert.ToDouble(ListaItensGridView1.Rows[i].Cells[3].Value);

                        db.ProdutoVendas.Add(pv);
                        c.TotalGasto = c.TotalGasto + total;
                        c.ContadorVendas++;
                        db.SaveChanges();

                    }
                    
                    this.Activate();
                        criarPDF();
                    this.Activate();
                    DialogResult dg = MessageBox.Show(this, "Deseja imprimir o comprovante da venda !", "Aviso", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        this.Activate();
                        imprimir();
                        this.Activate();
                    }
                    DialogResult dg2 = MessageBox.Show(this, "Deseja reimprimir o comprovante da venda !", "Aviso", MessageBoxButtons.YesNo);
                    if (dg2 == DialogResult.Yes)
                    {
                        this.Activate();
                        imprimir();
                        this.Activate();
                    }
                    this.Activate();
                    this.Show();
                        MessageBox.Show("Venda Realizada com sucesso !");
                    
                        this.Close();
                        return;
                    
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Erro: {ex.Message.ToString()} ");
                    return;
                }
                
            }
      
        }

        private void formapagamentocomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                int id = Convert.ToInt32(formapagamentocomboBox2.SelectedValue.ToString());
                FormaPagamento fp = db.FormaPagamentos.FirstOrDefault(u => u.Id == id);
                Formapagamentocache.Forma1 = fp.Descricao.ToString();
            }
            if (formapagamento2attcbb.Visible == false)
            {
                fplabel10.Text = formapagamentocomboBox2.Text.ToString();
                finalizarvendabutton.Enabled = true;
                finalizarvendabutton.Focus();
            }
            if (formapagamento2attcbb.Visible == true)
            {
                fpvalor1.Enabled = true;
                fpvalor1.Focus();
            }
            
        }

        private void fplabel10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void obsvendatextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtdeprodutotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08  && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13 && comboBox1.SelectedItem != null)
            {
                button1_Click(sender, e);
                comboBox1.Focus();
                
            }

            
        }

        private void nclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptntextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txentregacb_CheckedChanged(object sender, EventArgs e)
        {
            if (txentregacb.Checked == true)
            {
                naodescontocb.Enabled = false;
                outrodescontocb.Enabled = false;
                valordescontotxt.Enabled = false;
                outrodescontocb.Checked = false;
                valordescontotxt.Clear();
                CalcularTotal();
            }
            else
            {
                outrodescontocb.Enabled = true;
                CalcularTotal();
            }
            
        }

        private void valordescontotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void outrodescontocb_CheckedChanged(object sender, EventArgs e)
        {
            if (outrodescontocb.Checked == true)
            {

                txentregacb.Checked = false;
                txentregacb.Enabled = false;
                valordescontotxt.Enabled = true;
                valordescontotxt.Focus();
                
            }
            else
            {
                txentregacb.Enabled = true;
                valordescontotxt.Clear();
                valordescontotxt.Enabled = false;
                CalcularTotal();
            }
        }

        private void naodescontocb_CheckedChanged(object sender, EventArgs e)
        {
            if (naodescontocb.Checked == false)
            {
                simdescontocb.Enabled = true;
                simdescontocb.Focus();
                CalcularTotal();
            }
            else
            {
               
                simdescontocb.Enabled = false;
                outrodescontocb.Enabled = false;
                txentregacb.Enabled = false;
                valordescontotxt.Clear();
                valorpagotextBox1.Enabled = false;
                txentregacb.Checked = false;
                outrodescontocb.Checked = false;
                CalcularTotal();
            }
        }

        private void simdescontocb_CheckedChanged(object sender, EventArgs e)
        {
            if (simdescontocb.Checked == false)
            {
                naodescontocb.Enabled = true;
                outrodescontocb.Checked = false;
                txentregacb.Checked = false;
                outrodescontocb.Enabled = false;
                txentregacb.Enabled = false;
                valordescontotxt.Clear();
                valorpagotextBox1.Enabled = false;
                naodescontocb.Focus();
                CalcularTotal();
            }
            else
            {
                
                naodescontocb.Enabled = false;
                outrodescontocb.Enabled = true;
                txentregacb.Enabled = true;
                CalcularTotal();
            }
        }

        private void valordescontotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (valordescontotxt.Text.Count() < 1)
                {
                    return;
                }
                CalcularTotal();
            }
        }

        private void complementotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fpvalor2_TextChanged(object sender, EventArgs e)
        {
            finalizarvendabutton.Enabled = false;
        }

        private void fpvalor1_TextChanged(object sender, EventArgs e)
        {
            finalizarvendabutton.Enabled = false;
        }

        private void formapagamento2comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void valorpagotextBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show(this, "Deseja acrescentar mais de uma forma de pagamento ?", "Aviso", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                fpvalor1.Visible = true;
                fpvalor1.Enabled = false;
                fpvalor2.Visible = true;
                fpvalor2.Enabled = false;

                formapagamentocomboBox2.Enabled = true;
                formapagamento2attcbb.Visible = true;
                formapagamento2attcbb.Enabled = false;
                valorpagotextBox1.Enabled = false;
                valorpagotextBox1.Clear();
            }
        }
        
        private void formapagamento2attcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formapagamentocache.Forma2 = formapagamento2attcbb.SelectedText.ToString();
            string texto = formapagamentocomboBox2.Text.ToString() + "/" + formapagamento2attcbb.Text.ToString();
            if (texto.Length > 28)
            {
                fplabel10.Text = texto.Substring(0, 28) + "...";
            }
            else
            {
                fplabel10.Text = texto;
                
            }
            fpvalor2.Enabled = true;
            fpvalor2.Focus();
        }

        private void fpvalor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                CalcularTroco2();
            }
        }

        private void fpvalor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                CalcularTroco3();
            }
        }
    }
    
}
