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
    public partial class TelaSaida : Form
    {
        public TelaSaida()
        {
            InitializeComponent();
        }

        private void TelaSaida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet7att.Saidas'. Você pode movê-la ou removê-la conforme necessário.
            this.saidasTableAdapter.Fill(this.mataFomeDataSet7att.Saidas);
            inicio();
            datafinaldtp.Enabled = false;
            localizarbtn.Enabled = false;
        }

        private void inicio()
        {
            
            descricaotxt.Clear();
            valortxt.Clear();
           
            salvarbtn.Enabled = false;
            
            idsaidalb.Text = "-";
            dataGridView1.DataSource = "";
            descricaotxt.Focus();
            formatardatagrid();
            datasaidalb.Text = "-";
            datainiciodtp.Enabled = true;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datafinaldtp_ValueChanged(object sender, EventArgs e)
        {
            localizarbtn.Enabled = true;
            localizarbtn.Focus();
        }

        private void datainiciodtp_ValueChanged(object sender, EventArgs e)
        {
            datafinaldtp.Enabled = true;
            datafinaldtp.Focus();
        }

        private void localizarbtn_Click(object sender, EventArgs e)
        {
            DateTime d1 = datainiciodtp.Value.Date;
            DateTime d2 = datainiciodtp.Value.Date;
            d2 = d2.AddHours(23.50);
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Saidas> lista = db.Saidas.Where(u => u.Datasaida >= d1 && u.Datasaida <= d2);
                if (lista != null)
                {
                    dataGridView1.DataSource = lista.ToList();
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Não existe nenhuma saida para  a data selecionada !");
                    return;
                }
                
            }
        }

        private void formatardatagrid()
        {
            var grade = dataGridView1;
            grade.AutoGenerateColumns = false;
            grade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grade.Columns[0].Width = 50;
            grade.Columns[1].Width = 200;
            grade.Columns[2].Width = 75;
            grade.Columns[3].Width = 75;

            //formata as colunas valor, vencimento e pagamento
            grade.Columns[2].DefaultCellStyle.Format = "c";

            //seleciona a linha inteira
            grade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas    
            grade.MultiSelect = false;
            // exibe nulos formatados
            //grade.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            grade.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


        }


        private void salvarbtn_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(valortxt.Text.ToString());
            using (var db = new LanchoneteEntityContainer())
            {
                if (idsaidalb.Text == "-")
                {
                    Saidas s = new Saidas();
                    s.Datasaida = DateTime.Now;
                    s.Descricao = descricaotxt.Text.ToString();
                    s.Valor = valor;
                    try
                    {
                        db.Saidas.Add(s);
                        db.SaveChanges();
                        MessageBox.Show("Saída cadastrada com sucesso !");
                        inicio();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }
                }
                else
                {
                    int id = Convert.ToInt32(idsaidalb.Text.ToString());
                    Saidas s = db.Saidas.FirstOrDefault(u => u.Id == id);
                    s.Descricao = descricaotxt.Text.ToString();
                    s.Valor = valor;
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Saída Atualizada com sucesso !");
                        inicio();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }
                }

            }
        }

        private void idsaidalb_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            using (var db = new LanchoneteEntityContainer())
            {
                Saidas s = db.Saidas.FirstOrDefault(u => u.Id == id);
                descricaotxt.Text = s.Descricao.ToString();
                datasaidalb.Text = s.Datasaida.ToShortDateString();
                idsaidalb.Text = s.Id.ToString();
                valortxt.Text = s.Valor.ToString();
                descricaotxt.Focus();
            }
            salvarbtn.Enabled = true;
        }

        private void valortxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                salvarbtn.Enabled = true;
                salvarbtn.Focus();


            }
        }
    }
}
