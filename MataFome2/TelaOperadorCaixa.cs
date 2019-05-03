using MataFome2.Cache;
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
    public partial class TelaOperadorCaixa : Form
    {
        public TelaOperadorCaixa()
        {
            InitializeComponent();
        }

        private void TelaOperadorCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet2.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.mataFomeDataSet2.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet2.OperadorCaixas'. Você pode movê-la ou removê-la conforme necessário.
            this.operadorCaixasTableAdapter.Fill(this.mataFomeDataSet2.OperadorCaixas);

            imprimirbutton2.Enabled = false;
        }

        private void localizarbutton1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Checked == false)
            {
                MessageBox.Show("Selecione uma data");
                return;
            }
            if (operadorcomboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Usuário");
                return;
            }

            string data1 = dateTimePicker1.Value.ToShortDateString().ToString();
            int idusu = Convert.ToInt32(operadorcomboBox1.SelectedValue.ToString());
            using (var db = new LanchoneteEntityContainer())
            {
                OperadorCaixa op = db.OperadorCaixas.FirstOrDefault(u => u.DataCaixa == data1 && u.UsuarioId == idusu);
                if (op == null)
                {
                    MessageBox.Show("Não existe operador de Caixa Para o Usuário Selecionado e a Data Selecionada !");
                    return;
                }
                if (op.Id == OperadorCache.Operador)
                {
                    nomeusuariolabel2.Text = OperadorCache.Nome.ToString();
                    valoroperadorlabel4.Text = $"R$: {OperadorCache.Venda.ToString()}";
                    dataoperadorlabel6.Text = OperadorCache.DataCaixa.ToString();
                    imprimirbutton2.Enabled = true;
                }
                else
                {
                    nomeusuariolabel2.Text = op.Nome.ToString();
                    valoroperadorlabel4.Text = $"R$: {op.Venda.ToString()}";
                    dataoperadorlabel6.Text = op.DataCaixa.ToString();
                    imprimirbutton2.Enabled = true;

                }


                
            }
           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void operadorcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nomeusuariolabel2_Click(object sender, EventArgs e)
        {

        }

        private void valoroperadorlabel4_Click(object sender, EventArgs e)
        {

        }

        private void dataoperadorlabel6_Click(object sender, EventArgs e)
        {

        }

        private void imprimirbutton2_Click(object sender, EventArgs e)
        {
            criarPDF();
            imprimir();
        }

        private void Recibo(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 11, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 30;
            var data = DateTime.Now.ToLongDateString().ToString();

            graphic.DrawString("    Mata Fome Petisco".PadLeft(4), new Font("Courier New", 13, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("CNPJ: 33.219.881/0001-95", new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 18;
            graphic.DrawString("Contato:99189-1794 / 99312-1226", new Font("Courier New", 11), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 18;
            graphic.DrawString(data, new Font("Courier New", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 18;
            graphic.DrawString("===================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Usuário: {nomeusuariolabel2.Text.ToString()}", new Font("Courier New", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString($"Valor do caixa:R$: {valoroperadorlabel4.Text.ToString()}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString($"Data do caixa: {dataoperadorlabel6.Text.ToString()}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("===================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;
            graphic.DrawString("Operador:_________________________", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString($"Assinatura: {nomeusuariolabel2.Text.ToString()}".PadLeft(25), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;
            graphic.DrawString("Usuário:_________________________", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString($"Assinatura: {UsuarioCache.Login.ToString()}".PadLeft(25), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("===================================", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("===================================", font, new SolidBrush(Color.Black), startX, startY + offset);

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

        private void criarPDF()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string sistema = "Delivery";
            string diretorio = "Recibo Operador";
            string Mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dir = $"{Mydocument}/{sistema}/{diretorio}/{ano}/{mes}/{dia}";
            bool existe = Directory.Exists(dir);
            if (existe == false)
            {
                Directory.CreateDirectory(dir);
            }
            string file = $"RECIBO CAIXA {nomeusuariolabel2.Text.ToString().ToUpper()}.pdf";
            
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


    }
}
