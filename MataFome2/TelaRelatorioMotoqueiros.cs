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
    public partial class TelaRelatorioMotoqueiros : Form
    {
        public TelaRelatorioMotoqueiros()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TelaRelatorioMotoqueiros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'MataFomeDataSet6Att.Motoqueiros'. Você pode movê-la ou removê-la conforme necessário.
            this.motoqueirosTableAdapter.Fill(this.MataFomeDataSet6Att.Motoqueiros);
            // TODO: esta linha de código carrega dados na tabela 'MataFomeDataSet6Att.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            //this.DataTable1TableAdapter.Fill(this.MataFomeDataSet6Att.DataTable1);
            inicio();
            this.reportViewer1.RefreshReport();
        }

        private void inicio()
        {
            datainiciodtp.Focus();
            datafimdtp.Enabled = false;
            motocbb.Enabled = false;
            localizarbtn.Enabled = false;
            reportViewer1.Enabled = false;
        }


        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void motocbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            localizarbtn.Enabled = true;
            localizarbtn.Focus();
        }

        private void datafimdtp_ValueChanged(object sender, EventArgs e)
        {
            motocbb.Enabled = true;
            motocbb.Focus();
        }

        private void datainiciodtp_ValueChanged(object sender, EventArgs e)
        {
            datafimdtp.Enabled = true;
            datafimdtp.Focus();
        }

        private void localizarbtn_Click(object sender, EventArgs e)
        {
            reportViewer1.Enabled = true;
            if (datainiciodtp.Value > datafimdtp.Value)
            {
                MessageBox.Show("Escolha um intervalo de data válido !");
                return;
            }
            DateTime d1 = datainiciodtp.Value.Date;
            DateTime d2 = datafimdtp.Value.Date;
            d2 = d2.AddHours(23.59);
            double total = 0;
            using (var db = new LanchoneteEntityContainer())
            {
                int id = Convert.ToInt32(motocbb.SelectedValue.ToString());
                Motoqueiros m = db.Motoqueiros.FirstOrDefault(u => u.Id == id);
                IEnumerable<Venda> lista = db.Venda.Where(u => u.DataComparadora >= d1 && u.DataComparadora <= d2 && u.MotoqueiroId == m.Id);
                foreach (var item in lista)
                {
                    total += item.Total;
                }
                int qtd = lista.Count();
                double totalmoto = 0;
                double comissao = Convert.ToDouble(m.ValorEntrega.ToString());
                for (int i = 0; i < qtd; i++)
                {
                    totalmoto += comissao;
                }
                this.DataTable1TableAdapter.Fill(this.MataFomeDataSet6Att.DataTable1, id, d1, d2);
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TotalVenda", total.ToString("C", CultureInfo.CurrentCulture)));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Totalmoto", totalmoto.ToString("C", CultureInfo.CurrentCulture)));
                this.reportViewer1.RefreshReport();


            }
        }
    }
}