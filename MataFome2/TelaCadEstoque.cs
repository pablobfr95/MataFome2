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
    public partial class TelaCadEstoque : Form
    {
        public TelaCadEstoque()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salvarbtn_Click(object sender, EventArgs e)
        {
            if (nometextbox1.Text == "" || nometextbox1.Text == null)
            {
                MessageBox.Show("Digite algum nome para o produto !");
                nometextbox1.Focus();
                return;
            }
            if (qtdetextbox.Text == "" || qtdetextbox.Text == null)
            {
                MessageBox.Show($"Digite uma quantiadade para o produto {nometextbox1.Text.ToString()}");
                qtdetextbox.Focus();
                return;
            }

            if (medidacbb.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma medida !");
                medidacbb.Focus();
                return;
            }

            if (qtdetextbox.ReadOnly == true)
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    int id = Convert.ToInt32(produtosestoquesdataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Estoque es = db.Estoques.FirstOrDefault(u => u.Id == id);
                    es.Nome = nometextbox1.Text.ToString();
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Produto Atualizado com sucesso !");
                        limparcampos();
                        return;
                        


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    Estoque es = new Estoque();
                    es.Nome = nometextbox1.Text.ToString();
                    es.Medida = medidacbb.SelectedItem.ToString();
                    es.Quantidade = Convert.ToInt32(qtdetextbox.Text.ToString());
                    try
                    {
                        db.Estoques.Add(es);
                        db.SaveChanges();
                        MessageBox.Show("Produto do Estoque cadastrado com sucesso !");
                        populardatagrid();
                        limparcampos();
                        return;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        return;
                    }


                }

            }


        }

        private void limparcampos()
        {
            nometextbox1.Clear();
            qtdetextbox.ReadOnly = false;
            qtdetextbox.Clear();
            populardatagrid();
            nometextbox1.Focus();
        }

        private void qtdetextbox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void medidacbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nometextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void populardatagrid()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Estoque> lista = db.Estoques.OrderBy(u => u.Nome);
                produtosestoquesdataGridView1.DataSource = lista.ToList();
            }
        }


        private void popularcombobox()
        {
            medidacbb.Items.Add("Kg");
            medidacbb.Items.Add("gramas");
            medidacbb.Items.Add("Unidades");
        }

        private void formatargrid()
        {
            var grid = produtosestoquesdataGridView1;
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
            //seleciona a linha inteira
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas    
            grid.MultiSelect = false;
            // exibe nulos formatados
            //permite que o texto maior que célula não seja truncado
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void TelaCadEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet3Atualizado.Estoques'. Você pode movê-la ou removê-la conforme necessário.
            this.estoquesTableAdapter.Fill(this.mataFomeDataSet3Atualizado.Estoques);
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet3Atualizado.Estoques'. Você pode movê-la ou removê-la conforme necessário.
            this.estoquesTableAdapter.Fill(this.mataFomeDataSet3Atualizado.Estoques);
            popularcombobox();
            formatargrid();
        }

        private void produtosestoquesdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void qtdetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void produtosestoquesdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(produtosestoquesdataGridView1.CurrentRow.Cells[0].Value.ToString());
            procuraproduto(id);
        }

        private void procuraproduto(int id)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                Estoque es = db.Estoques.FirstOrDefault(u => u.Id == id);
                nometextbox1.Text = es.Nome.ToString();
                qtdetextbox.Text = es.Quantidade.ToString();
                qtdetextbox.ReadOnly = true;
                medidacbb.SelectedItem = es.Medida.ToString();
               

            }
        }
    }
}
