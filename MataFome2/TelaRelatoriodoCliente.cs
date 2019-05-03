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
    public partial class TelaRelatoriodoCliente : Form
    {
        int telefone;
        double total;
        string nome;
        int pedidos;
        public TelaRelatoriodoCliente(int tel)
        {
            telefone = tel;
            InitializeComponent();
        }

        private void TelaRelatoriodoCliente_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'MataFomeDataSet5att.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            
            using (var db = new LanchoneteEntityContainer())
            {
                Cliente c = db.Clientes.FirstOrDefault(u => u.Telefone == telefone);
                nome = c.NomeCliente.ToString();
                IEnumerable<Venda> lista = db.Venda.Where(u => u.ClienteId == c.Id);
                foreach (var item in lista)
                {
                    total += item.Total;
                }

                pedidos = lista.Count();
            }
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NomeCliente",nome));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Total","R$:" + total.ToString()));
              this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TotalPedidos", pedidos.ToString()));
            this.DataTable1TableAdapter.Fill(this.MataFomeDataSet5att.DataTable1, telefone);
            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
