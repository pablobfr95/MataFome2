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
    public partial class TelaTrocarPontos : Form
    {
        public TelaTrocarPontos()
        {
            InitializeComponent();
        }

        private void TelaTrocarPontos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet4.ProdutosFidelidades'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtosFidelidadesTableAdapter.Fill(this.mataFomeDataSet4.ProdutosFidelidades);
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet4.Clientes'. Você pode movê-la ou removê-la conforme necessário.
           // this.clientesTableAdapter.Fill(this.mataFomeDataSet4.Clientes);
            desabilitar();
            telclientetxt.Focus();
        }

        private void telclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonetxtachado_TextChanged(object sender, EventArgs e)
        {

        }

        private void pontostxtcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeclientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void popularclientecbb()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                int pontos = Convert.ToInt32(pontostxtcliente.Text);
                IEnumerable<ProdutosFidelidade> lista = db.ProdutosFidelidades.Where(u => u.QtdePontos <= pontos);
                produtofidelidadecbb.DataSource = lista.ToList();
                int totalprod = lista.Count();
                if (totalprod < 1)
                {
                    MessageBox.Show("Este Cliente não possui pontos Suficientes para serem trocados por algum produto !");
                    produtofidelidadecbb.Enabled = false;

                    return;
                }
                
            }
        }

        private void clientecbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new LanchoneteEntityContainer())
            {
                int id = Convert.ToInt32(clientecbb.SelectedValue);
                Cliente c = db.Clientes.FirstOrDefault(u => u.Id == id);
                nomeclientetxt.Text = c.NomeCliente.ToString();
                telefonetxtachado.Text = c.Telefone.ToString();
                pontostxtcliente.Text = c.PontosFidelidade.ToString();
                nomeclientetxt.ReadOnly = true;
                telefonetxtachado.ReadOnly = true;
                pontostxtcliente.ReadOnly = true;
                popularclientecbb();
                produtofidelidadecbb.Focus();
                produtofidelidadecbb.Enabled = true;
                
            }

        }

        private void produtofidelidadecbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trocarbutton.Enabled = true;
        }

        private void desabilitar()
        {
            Trocarbutton.Enabled = false;

            clientecbb.Enabled = false;
            nomeclientetxt.Enabled = false;
            telefonetxtachado.Enabled = false;
            pontostxtcliente.Enabled = false;
            produtofidelidadecbb.Enabled = false;
        }

        private void telclientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    int tel = Convert.ToInt32(telclientetxt.Text);
                    Cliente c = db.Clientes.FirstOrDefault(u => u.Telefone == tel);
                    if (c == null)
                    {
                        DialogResult dg = MessageBox.Show(this, "Telefone não Encontrado, tente Encontrar na lista de clientes abaixo !", "Aviso", MessageBoxButtons.OK);
                        if (dg == DialogResult.OK)
                        {
                            clientecbb.Enabled = true;
                            telclientetxt.ReadOnly = true;
                            this.clientesTableAdapter.Fill(this.mataFomeDataSet4.Clientes);
                            clientecbb.Focus();
                            return;
                        }
                    }
                    else
                    {
                        nomeclientetxt.Text = c.NomeCliente.ToString();
                        telefonetxtachado.Text = c.Telefone.ToString();
                        pontostxtcliente.Text = c.PontosFidelidade.ToString();
                        popularclientecbb();
                        produtofidelidadecbb.Enabled = true;
                        produtofidelidadecbb.Focus();
                    }
                    


                }
            }
        }

        private void Trocarbutton_Click(object sender, EventArgs e)
        {
             
            using (var db = new LanchoneteEntityContainer())
            {
                Cliente c = db.Clientes.First(u => u.NomeCliente == nomeclientetxt.Text.ToString());
                int id = Convert.ToInt32(produtofidelidadecbb.SelectedValue);
                ProdutosFidelidade pf = db.ProdutosFidelidades.First(u => u.Id == id);
                FidelidadeCliente fc = new FidelidadeCliente();
                fc.ClienteId = c.Id;
                fc.ProdutosFidelidadeId = pf.Id;
                fc.Quantidade = 1;
                c.PontosFidelidade = c.PontosFidelidade - pf.QtdePontos;
                try
                {
                    db.FidelidadeClienteSet.Add(fc);
                    db.SaveChanges();
                    MessageBox.Show($"Produto trocado com sucesso !, Cliente {c.NomeCliente} agora possui {c.PontosFidelidade} pontos!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }


            }
        }
    }
}
