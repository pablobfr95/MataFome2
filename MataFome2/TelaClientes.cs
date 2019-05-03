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
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet5att.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            // this.clientesTableAdapter.Fill(this.mataFomeDataSet5att.Clientes);
            corrigirvendas();
            formatardatagrid();
            popularcliente();
            
        }

        private void formatardatagrid()
        {
            var grade = clientesdgv;
            grade.AutoGenerateColumns = false;
            grade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
           
            //altera o nome das colunas
            
            grade.Columns[0].Width = 45;
            grade.Columns[1].Width = 200;
            grade.Columns[2].Width = 75;
            grade.Columns[3].Width = 50;
            grade.Columns[4].Width = 100;

            //formata as colunas valor, vencimento e pagamento
            grade.Columns[4].DefaultCellStyle.Format = "C2";

            //seleciona a linha inteira
            grade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas    
            grade.MultiSelect = false;
            // exibe nulos formatados
            //grade.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            grade.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //define o alinhamamento à direita
            grade.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grade.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grade.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grade.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        double total;
        int contador;
        private void corrigirvendas()
        {
            
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Cliente> lista = from u in db.Clientes select u;
                int tamanholista = lista.Count();
                foreach (var item in lista)
                {
                    
                    if (item.TotalGasto == null)
                     {
                        total = 0;
                        contador = 0;
                         IEnumerable<Venda> lista2 = db.Venda.Where(u => u.ClienteId == item.Id);
                         foreach (var item2 in lista2)
                         {
                             total += item2.Total;
                             contador++;

                         }
                        string nome = item.NomeCliente.ToString();
                        item.ContadorVendas = contador;
                        item.TotalGasto = total;

                    }

                   //  item.TotalGasto = null;
                    // item.ContadorVendas = null;
                }
                db.SaveChanges();


            }
        }
        private void popularcliente()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Cliente> lista = db.Clientes.OrderByDescending(u => u.ContadorVendas);
                clientesdgv.DataSource = lista.ToList();

            }
        }

        private void clientesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void telcilentelb_Click(object sender, EventArgs e)
        {

        }

        private void clientelb_Click(object sender, EventArgs e)
        {

        }

        private void enderecolb_Click(object sender, EventArgs e)
        {

        }

        private void totalpedidoslb_Click(object sender, EventArgs e)
        {

        }

        private void pontosfdlb_Click(object sender, EventArgs e)
        {

        }

        private void totalgastolb_Click(object sender, EventArgs e)
        {

        }

        private void procurarCliente()
        {
            int id = Convert.ToInt32(clientesdgv.CurrentRow.Cells[0].Value.ToString());
            using (var db = new LanchoneteEntityContainer())
            {
                Cliente c = db.Clientes.FirstOrDefault(u => u.Id == id);
                clientelb.Text = c.NomeCliente.ToString();
                enderecolb.Text = c.Endereco.ToString();
                telcilentelb.Text = c.Telefone.ToString();
                totalgastolb.Text = $"R$: {c.TotalGasto.ToString()}";
                totalpedidoslb.Text = c.ContadorVendas.ToString();
                pontosfdlb.Text = c.PontosFidelidade.ToString();
                bairrolb.Text = c.Bairro.ToString();
                cidadelb.Text = c.Municipio.ToString();
                IEnumerable<Venda> lista = db.Venda.Where(u => u.ClienteId == c.Id);
                if (lista.Count() > 1)
                {
                    Venda v = lista.OrderByDescending(u => u.DataComparadora).Take(1).First();
                    ultimopedidolb.Text = v.DataComparadora.ToShortDateString();
                }
                
            }
        }

        private void clientesdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            procurarCliente();
        }

        private void clientesdgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string index1 = clientesdgv.Columns[e.ColumnIndex].HeaderText.ToString();
            if (index1 == "Pedidos")
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    IEnumerable<Cliente> lista = db.Clientes.OrderByDescending(u => u.ContadorVendas);
                    clientesdgv.DataSource = lista.ToList();
                }
            }
            else if (index1 == "Total Gasto")
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    IEnumerable<Cliente> lista = db.Clientes.OrderByDescending(u => u.TotalGasto);
                    clientesdgv.DataSource = lista.ToList();
                }
            }
            else if (index1 == "Cliente")
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    IEnumerable<Cliente> lista = db.Clientes.OrderBy(u => u.NomeCliente);
                    clientesdgv.DataSource = lista.ToList();
                }
            }
            else if (index1 == "Id")
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    IEnumerable<Cliente> lista = db.Clientes.OrderBy(u => u.Id);
                    clientesdgv.DataSource = lista.ToList();
                }
            }
           
        }

        private void ultimopedidolb_Click(object sender, EventArgs e)
        {

        }

        private void bairrolb_Click(object sender, EventArgs e)
        {

        }

        private void cidadelb_Click(object sender, EventArgs e)
        {

        }

        private void clientesdgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dg = MessageBox.Show(this, "Deseja Abrir o relatório do Cliente ?", "Aviso", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                int tel = Convert.ToInt32(clientesdgv.CurrentRow.Cells[2].Value.ToString());
                TelaRelatoriodoCliente tela = new TelaRelatoriodoCliente(tel);
                tela.ShowDialog();
               
            }
        }
    }
}
