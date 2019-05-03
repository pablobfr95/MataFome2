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
    public partial class TelaRelatorioSaida : Form
    {
        public TelaRelatorioSaida()
        {
            InitializeComponent();
        }

        private void TelaRelatorioSaida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'MataFomeDataSet7att.Saidas1'. Você pode movê-la ou removê-la conforme necessário.
            //

            //this.Saidas1TableAdapter.Fill(this.MataFomeDataSet7att.Saidas1);
            datafinaldtp.Enabled = false;
            localizarbutton.Enabled = false;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void localizarbutton_Click(object sender, EventArgs e)
        {
            double total = 0;
            DateTime d1 = datainiciodtp.Value.Date;
            DateTime d2 = datafinaldtp.Value.Date;
            d2 = d2.AddHours(23.59);
            if (d1 > d2)
            {
                MessageBox.Show("Escolha um intervalo de datas válido !");
                return;
            }
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Saidas> lista = db.Saidas.Where(u => u.Datasaida >= d1 && u.Datasaida <= d2);
                foreach (var item in lista)
                {
                    total += item.Valor;
                }

            }

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Total", "R$:" + total.ToString()));
            this.Saidas1TableAdapter.Fill(this.MataFomeDataSet7att.Saidas1,d1,d2);
            this.reportViewer1.RefreshReport();
        }

        private void datafinaldtp_ValueChanged(object sender, EventArgs e)
        {
            localizarbutton.Enabled = true;
            localizarbutton.Focus();
        }

        private void datainiciodtp_ValueChanged(object sender, EventArgs e)
        {
            datafinaldtp.Enabled = true;
            datafinaldtp.Focus();
        }
    }
}
