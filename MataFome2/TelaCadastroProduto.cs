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
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
        }


        private void popularGrid()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Produto> lista = from u in db.Produtos select u;
                dataGridView1.DataSource = lista.ToList();
            }
        }

        private void limparCampos()
        {
            precotxt.Text = "";
            nometxt.Text = "";
            salvarbutton.Enabled = true;
            attbutton1.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nometxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void precotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarbutton_Click(object sender, EventArgs e)
        {
            if (nometxt.Text == "" || nometxt.Text == null)
            {
                MessageBox.Show(this, "Digite algum nome para o Nome do Produto !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nometxt.Focus();
                return;
            }

            if (precotxt.Text == "" || precotxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Preço para o Produto !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                precotxt.Focus();
                return;
            }

            Produto p = new Produto();
            p.NomeProduto = nometxt.Text.Trim().ToString();
            p.PrecoUnitario = Convert.ToDouble(precotxt.Text.Trim().ToString());

            try
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    db.Produtos.Add(p);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message.ToString()}");
                return;
                
            }
            popularGrid();
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter1.Fill(this.mataFomeDataSet1.Produtos);
            popularGrid();
            formatargrid();
            limparCampos();

        }
        
        private void attbutton1_Click(object sender, EventArgs e)
        {
            if (nometxt.Text == "" || nometxt.Text == null)
            {
                MessageBox.Show(this, "Digite um nome para o Produto !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (precotxt.Text == "" || precotxt.Text == null)
            {
                MessageBox.Show(this, "Digite um preço para o Produto !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var db = new LanchoneteEntityContainer())
            {

                int nId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Produto p = db.Produtos.FirstOrDefault(u => u.Id == nId);

                p.NomeProduto = nometxt.Text.Trim().ToString();
                p.PrecoUnitario = Convert.ToDouble(precotxt.Text.ToString().Trim());
                try
                {
                    db.SaveChanges();
                    popularGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message.ToString()}");
                    return;
                }

                limparCampos();
            }


        }

        private void formatargrid()
        {
            var grid = dataGridView1;
            grid.AutoGenerateColumns = false;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            grid.RowsDefaultCellStyle.BackColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
            //altera o nome das colunas
            grid.Columns[0].Width = 20;
            grid.Columns[1].Width = 212;
            grid.Columns[2].Width = 50;
            
            //formata as colunas valor, vencimento e pagamento
            grid.Columns[2].DefaultCellStyle.Format = "c";

            //seleciona a linha inteira
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas    
            grid.MultiSelect = false;
            // exibe nulos formatados
            //permite que o texto maior que célula não seja truncado
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
        }
        
        private void procuraproduto(int id)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                Produto p = db.Produtos.FirstOrDefault(u => u.Id == id);
                nometxt.Text = p.NomeProduto.ToString();
                precotxt.Text = p.PrecoUnitario.ToString();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            procuraproduto(id);
            salvarbutton.Enabled = false;
            attbutton1.Enabled = true;
        }

        private void precotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 45)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
