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
    public partial class TelaCadastroFormaPagamento : Form
    {
        public TelaCadastroFormaPagamento()
        {
            InitializeComponent();
        }

        private void TelaCadastroFormaPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet1.FormaPagamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.formaPagamentosTableAdapter.Fill(this.mataFomeDataSet1.FormaPagamentos);
            popularGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nomeformatextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarbutton1_Click(object sender, EventArgs e)
        {
            if (nomeformatextBox1.Text == "" || nomeformatextBox1 == null)
            {
                MessageBox.Show(this, "Digite algum nome para a Forma de Pagamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomeformatextBox1.Focus();
                return;
            }

            FormaPagamento f = new FormaPagamento();
            f.Descricao = nomeformatextBox1.Text.Trim().ToLower().ToString();

            using (var db = new LanchoneteEntityContainer())
            {
                try
                {
                    db.FormaPagamentos.Add(f);
                    db.SaveChanges();
                    nomeformatextBox1.Clear();
                    popularGrid();
                    MessageBox.Show("Forma de Pagamento cadastrada com sucesso !");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message.ToString()}");
                }
            }


        }

        private void attbutton2_Click(object sender, EventArgs e)
        {
            if (nomeformatextBox1.Text == "" || nomeformatextBox1 == null)
            {
                MessageBox.Show(this, "Digite algum nome para a Forma de Pagamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomeformatextBox1.Focus();
                return;
            }

            using (var db = new LanchoneteEntityContainer())
            {

                int nId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                FormaPagamento p = db.FormaPagamentos.FirstOrDefault(u => u.Id == nId);

                p.Descricao = nomeformatextBox1.Text.Trim().ToString().ToLower();
                try
                {
                    db.SaveChanges();
                    popularGrid();
                    nomeformatextBox1.Clear();
                    MessageBox.Show("Forma de Pagamento atualizada com sucesso !");
                    popularGrid();
                    attbutton2.Enabled = false;
                    salvarbutton1.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message.ToString()}");
                    return;
                }
            }

        }

        private void popularGrid()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<FormaPagamento> lista = from u in db.FormaPagamentos select u;
                dataGridView1.DataSource = lista.ToList();
            }
        }

        private void procuraforma(int id)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                FormaPagamento p = db.FormaPagamentos.FirstOrDefault(u => u.Id == id);
                nomeformatextBox1.Text = p.Descricao.ToString();
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            procuraforma(id);
            salvarbutton1.Enabled = false;
            attbutton2.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
