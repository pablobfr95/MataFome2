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
    public partial class TelaCadastroMotoqueiro : Form
    {
        public TelaCadastroMotoqueiro()
        {
            InitializeComponent();
        }

        private void TelaCadastroMotoqueiro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet6Att.Motoqueiros'. Você pode movê-la ou removê-la conforme necessário.
            this.motoqueirosTableAdapter.Fill(this.mataFomeDataSet6Att.Motoqueiros);
            inicio();
            formatardatagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void telefonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nometxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void entregatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalrecebidolb_Click(object sender, EventArgs e)
        {

        }

        private void salvarbtn_Click(object sender, EventArgs e)
        {
            if (nometxt.Text == "" || nometxt.Text == null)
            {
                MessageBox.Show("Digite um nome para o Motoqueiro !");
                nometxt.Focus();
                return;
            }
            if (telefonetxt.Text == "" || telefonetxt.Text == null)
            {
                MessageBox.Show("Digite um telefone para o Motoqueiro !");
                telefonetxt.Focus();
                return;
            }
            if (entregatxt.Text == "" || telefonetxt.Text == null)
            {
                MessageBox.Show("Digite um valor de Entrega para o Motoqueiro !");
                entregatxt.Focus();
                return;
            }
            if (telefonetxt.Text.Length < 7)
            {
                MessageBox.Show("Digite um telefone válido !");
                telefonetxt.Focus();
                return;
            }
            Motoqueiros m = new Motoqueiros();
            m.Nome = nometxt.Text.ToString().Trim();
            m.Telefone = Convert.ToInt32(telefonetxt.Text);
            m.ValorEntrega = Convert.ToDouble(entregatxt.Text);
            m.ValorTotalRecebido = 0;

            using (var db = new LanchoneteEntityContainer())
            {
                try
                {
                    db.Motoqueiros.Add(m);
                    db.SaveChanges();
                    MessageBox.Show("Motoqueiro Cadastrado com Sucesso !");
                    inicio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    throw;
                }
            }
        }

        private void atualizarbtn_Click(object sender, EventArgs e)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                if (nometxt.Text == "" || nometxt.Text == null)
                {
                    MessageBox.Show("Digite um nome para o Motoqueiro !");
                    nometxt.Focus();
                    return;
                }
                if (telefonetxt.Text == "" || telefonetxt.Text == null)
                {
                    MessageBox.Show("Digite um telefone para o Motoqueiro !");
                    telefonetxt.Focus();
                    return;
                }
                if (entregatxt.Text == "" || telefonetxt.Text == null)
                {
                    MessageBox.Show("Digite um valor de Entrega para o Motoqueiro !");
                    entregatxt.Focus();
                    return;
                }
                if (telefonetxt.Text.Length < 7)
                {
                    MessageBox.Show("Digite um telefone válido !");
                    telefonetxt.Focus();
                    return;
                }

                int tel = Convert.ToInt32(telefonetxt.Text.ToString());
                Motoqueiros m = db.Motoqueiros.FirstOrDefault(u => u.Telefone == tel);
                m.Nome = nometxt.Text.ToString();
                m.ValorEntrega = Convert.ToDouble(entregatxt.Text.ToString());
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Cliente Atualizado com sucesso !");
                    inicio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    throw;
                }
            }

        }

        private void inicio()
        {
            salvarbtn.Enabled = false;
            atualizarbtn.Enabled = false;
            entregatxt.Clear();
            entregatxt.Enabled = false;
            nometxt.Clear();
            nometxt.Enabled = false;
            telefonetxt.Clear();
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Motoqueiros> lista = from u in db.Motoqueiros select u;
                if (lista.Count() > 0)
                {
                    dataGridView1.DataSource = lista.ToList();
                    dataGridView1.Refresh();
                }
            }
            telefonetxt.Focus();
            telefonetxt.ReadOnly = false;
            telefonetxt.Enabled = true;
            dataGridView1.Enabled = true;

        }

        private void formatardatagrid()
        {
            var grade = dataGridView1;
            grade.AutoGenerateColumns = false;
            grade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera o nome das colunas
            
            grade.Columns[0].Width = 30;
            grade.Columns[1].Width = 100;
            grade.Columns[2].Width = 100;
            grade.Columns[3].Width = 100;
            grade.Columns[4].Width = 75;

            //formata as colunas valor, vencimento e pagamento
            grade.Columns[3].DefaultCellStyle.Format = "c";
            grade.Columns[4].DefaultCellStyle.Format = "c";
            
            //não permite seleção de multiplas linhas    
            grade.MultiSelect = false;
            // exibe nulos formatados
            //grade.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            grade.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //define o alinhamamento à direita
            grade.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grade.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grade.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
        }

        private void telefonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                int tel = Convert.ToInt32(telefonetxt.Text.ToString());
                using (var db = new LanchoneteEntityContainer())
                {
                    Motoqueiros m = db.Motoqueiros.FirstOrDefault(u => u.Telefone == tel);
                    if (m != null)
                    {
                        nometxt.Text = m.Nome.ToString();
                        entregatxt.Text = m.ValorEntrega.ToString();
                        totalrecebidolb.Text = $"R$: {m.ValorTotalRecebido.ToString()}";
                        telefonetxt.ReadOnly = true;
                        atualizarbtn.Enabled = true;
                        nometxt.Enabled = true;
                        entregatxt.Enabled = true;
                        nometxt.Focus();
                    }
                    else
                    {
                        dataGridView1.Enabled = false;
                        nometxt.Enabled = true;
                        entregatxt.Enabled = true;
                        salvarbtn.Enabled = true;
                        nometxt.Focus();
                    }





                }
            }
        }

        private void entregatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 13)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void nometxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nometxt.Clear();
            telefonetxt.Clear();
            entregatxt.Clear();

            procurarmotoqueiro();
            salvarbtn.Enabled = false;
            telefonetxt.ReadOnly = true;
            atualizarbtn.Enabled = true;
            nometxt.Enabled = true;
            entregatxt.Enabled = true;
        }

        private void procurarmotoqueiro()
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            using (var db = new LanchoneteEntityContainer())
            {
                Motoqueiros m = db.Motoqueiros.FirstOrDefault(u => u.Id == id);
                telefonetxt.Text = m.Telefone.ToString();
                nometxt.Text = m.Nome.ToString();
                entregatxt.Text = m.ValorEntrega.ToString();
                totalrecebidolb.Text = $"R$: {m.ValorTotalRecebido.ToString()}";

            }
        }
    }
}
