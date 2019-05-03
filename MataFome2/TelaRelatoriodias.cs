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
    public partial class TelaRelatoriodias : Form
    {
        public TelaRelatoriodias()
        {
            InitializeComponent();
        }

        private void TelaRelatoriodias_Load(object sender, EventArgs e)
        {
            datafinaldtp.Enabled = false;
            localizarbutton.Enabled = false;
            reportViewer1.Enabled = false;
            datainiciodtp.Focus();
            /*
            DateTime d1 = DateTime.Now.Date;
            d1 = d1.AddDays(-1);
            DateTime d2 = DateTime.Now;
            double total = 0;
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Venda> lista = db.Venda.Where(u => u.DataComparadora >= d1 && u.DataComparadora <= d2);
                foreach (var item in lista)
                {
                    total += item.Total;
                }


            }
            // TODO: esta linha de código carrega dados na tabela 'MataFomeDataSet4.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.DataTable1TableAdapter.Fill(this.MataFomeDataSet4.DataTable1,d1,d2);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Total", total.ToString()));
            this.reportViewer1.RefreshReport();*/
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void datainiciodtp_ValueChanged(object sender, EventArgs e)
        {
            datafinaldtp.Enabled = true;
          
        }

        private void datafinaldtp_ValueChanged(object sender, EventArgs e)
        {
            localizarbutton.Enabled = true;
        }

        private void localizarbutton_Click(object sender, EventArgs e)
        {
            reportViewer1.Enabled = true;
            if (datainiciodtp.Value > datafinaldtp.Value)
            {
                MessageBox.Show("Escollha um intervalo de data válido !");
                return;
            }
              DateTime d1 = datainiciodtp.Value.Date;
              DateTime d2 = datafinaldtp.Value.Date;
              d2 = d2.AddHours(23.59);
            double total = 0;
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Venda> lista = db.Venda.Where(u => u.DataComparadora >= d1 && u.DataComparadora <= d2 && u.Status == "Finalizada");
                foreach (var item in lista)
                {
                    total += item.Total;
                }


            }
            // TODO: esta linha de código carrega dados na tabela 'MataFomeDataSet4.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.DataTable1TableAdapter.Fill(this.MataFomeDataSet4.DataTable1, d1, d2, "Finalizada");
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Total", total.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
