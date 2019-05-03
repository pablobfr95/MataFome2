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
    public partial class TelaEntradaeSaida : Form
    {
        public TelaEntradaeSaida()
        {
            InitializeComponent();
        }

        private void TelaEntradaeSaida_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            datainicioentradalb.Text = "-";
            datafinalentradalb.Text = "-";
            qtdeentradalb.Text = "-";
            valorfinalentradalb.Text = "-";
            datainiciosaidalb.Text = "-";
            datafinalsaidalb.Text = "-";
            qtdesaidalb.Text = "-";
            valorfinalsaidalb.Text = "-";
            valorentradaslb.Text = "-";
            valorsaidaslb.Text = "-";
            lucrolb.Text = "-";
        }

        private void localizarbutton_Click(object sender, EventArgs e)
        {
            double totalentrada = 0;
            double totalsaida = 0;
            DateTime d1 = datainiciodtp.Value.Date;
            DateTime d2 = datafinaldtp.Value.Date;
            d2 = d2.AddHours(23.59);
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Venda> lista = db.Venda.Where(u => u.DataComparadora >= d1 && u.DataComparadora <= d2);
                foreach (var item in lista)
                {
                    totalentrada += item.Total;
                }
                IEnumerable<Saidas> lista2 = db.Saidas.Where(u => u.Datasaida >= d1 && u.Datasaida <= d2);
                foreach (var item in lista2)
                {
                    totalsaida += item.Valor;
                }
                int qtdentrada = lista.Count();
                int qtdsaida = lista2.Count();
                
                datainicioentradalb.Text = d1.ToShortDateString();
                datafinalentradalb.Text = d2.ToShortDateString();
                qtdeentradalb.Text = qtdentrada.ToString();
                valorfinalentradalb.Text = totalentrada.ToString("C", CultureInfo.CurrentCulture);
                datainiciosaidalb.Text = d1.ToShortDateString();
                datafinalsaidalb.Text = d2.ToShortDateString();
                qtdesaidalb.Text = qtdsaida.ToString();
                valorfinalsaidalb.Text = totalsaida.ToString("C", CultureInfo.CurrentCulture);
                valorentradaslb.Text = valorfinalentradalb.Text;
                valorsaidaslb.Text = valorfinalsaidalb.Text;
                double lucro = totalentrada - totalsaida;
                if (lucro < 0)
                {
                    situacaolb.Text = "Prejuizo";
                }
                else
                {
                    situacaolb.Text = "Lucro";
                }
                lucrolb.Text = lucro.ToString("C", CultureInfo.CurrentCulture);
            }



        }

        private void datafinaldtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datainiciodtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void situacaolb_Click(object sender, EventArgs e)
        {

        }
    }
}
