using MataFome2.Controller;
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
    public partial class TelaCadastroUsuario : Form
    {
        ClienteController clicon = new ClienteController();
            
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            telefone.Text = "";
            nometxt.Text = "";
            textBox2.Text = "";
            cpftxt.Text = "";
            numerotxt.Text = "";
            bairrotxt.Text = "";
            municipiotxt.Text = "";
            ceptxt.Text = "";
            obstxt.Text = "";
            txentregatxt.Text = "";
            pontosfidtxt.Text = "";
            complementotxt.Text = "";
        }

        private void desabilitarcampos()
        {
            nometxt.Enabled = false;
            cpftxt.Enabled = false;
            bairrotxt.Enabled = false;
            municipiotxt.Enabled = false;
            ceptxt.Enabled = false;
            obstxt.Enabled = false;
            numerotxt.Enabled = false;
            textBox2.Enabled = false;
            txentregatxt.Enabled = false;
            pontosfidtxt.Enabled = false;
            complementotxt.Enabled = false;
        }

        private void habilitarcampos()
        {
            nometxt.Enabled = true;
            cpftxt.Enabled = true;
            bairrotxt.Enabled = true;
            municipiotxt.Enabled = true;
            ceptxt.Enabled = true;
            obstxt.Enabled = true;
            numerotxt.Enabled = true;
            textBox2.Enabled = true;
            txentregatxt.Enabled = true;
            complementotxt.Enabled = true;
        }

        private void salvarbutton1_Click(object sender, EventArgs e)
        {
            if (telefone.Text == "" || telefone.Text == null)
            {
                MessageBox.Show(this, "Digite um Telefone para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                telefone.Focus();
                return;
            }

            if (nometxt.Text == "" || nometxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Nome para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nometxt.Focus();
                return;
            }

            if (textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show(this, "Digite um Endereço para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }

            if (numerotxt.Text == "" || numerotxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Número para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numerotxt.Focus();
                return;
            }

            if (bairrotxt.Text == "" || bairrotxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Bairro para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bairrotxt.Focus();
                return;
            }

            if (municipiotxt.Text == "" || municipiotxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Município para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                municipiotxt.Focus();
                return;
            }

            if (txentregatxt.Text == "" || txentregatxt.Text == null)
            {
                MessageBox.Show("Digite um Valor para a Taxa de Entrega !");
                return;
            }
            Cliente c = new Cliente();
            c.Telefone = Convert.ToInt32(telefone.Text);
            c.NomeCliente = nometxt.Text.ToString();
            c.Endereco = textBox2.Text.ToString();
            c.Numero = Convert.ToInt32(numerotxt.Text);
            c.Bairro = bairrotxt.Text.ToString();
            c.Municipio = municipiotxt.Text.ToString();
            c.PontosFidelidade = 0;
            c.TaxaEntrega = Convert.ToDouble(txentregatxt.Text);
            if (complementotxt.Text == "" || complementotxt.Text == null)
            {
                c.Complemento = "";
            }
            else
            {
                c.Complemento = complementotxt.Text.ToString();
            }
            if (ceptxt.Text == "" || ceptxt.Text == null)
            {
                c.CEP = "";
            }
            else
            {
                c.CEP = ceptxt.Text.ToString();
            }
            if (obstxt.Text == ""|| obstxt.Text == null)
            {
                c.Observacao = "";
            }
            else
            {
                c.Observacao = obstxt.Text.ToString();
            }
            if (cpftxt.Text == "" || cpftxt.Text == null)
            {
                c.CPF = "";
            }
            else
            {
                c.CPF = cpftxt.Text.ToString();
            }

            try
            {
                using (var db = new LanchoneteEntityContainer())
                {
                    db.Clientes.Add(c);
                    db.SaveChanges();
                    MessageBox.Show(this, "Cliente Cadastrado com sucesso !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salvarbutton1.Enabled = false;
                    attbutton1.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro: {ex.Message.ToString()}");
                return;
            }

        }

        private void nometxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpftxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bairrotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void municipiotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ceptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void numerotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void obstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastroUsuario_Load(object sender, EventArgs e)
        {
            desabilitarcampos();
            desabilitabotoes();
        }

        private void desabilitabotoes()
        {
            salvarbutton1.Enabled = false;
            attbutton1.Enabled = false;
        }

        private void telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            
            if (e.KeyChar == 13)
            {
                Cliente cli = new Cliente();
                int tel = Convert.ToInt32(telefone.Text);
                cli.Telefone = tel;
                if (clicon.procurarCliente(tel) == true)
                {
                    MessageBox.Show("Telefone já cadastrado !");
                    habilitarcampos();
                    salvarbutton1.Enabled = false;
                    attbutton1.Enabled = true;
                    using (var db = new LanchoneteEntityContainer())
                    {
                        Cliente c = db.Clientes.FirstOrDefault(u => u.Telefone == tel);
                        nometxt.Text = c.NomeCliente.ToString();
                        textBox2.Text = c.Endereco.ToString();
                        cpftxt.Text = c.CPF.ToString();
                        bairrotxt.Text = c.Bairro.ToString();
                        municipiotxt.Text = c.Municipio.ToString();
                        ceptxt.Text = c.CEP.ToString();
                        numerotxt.Text = c.Numero.ToString();
                        txentregatxt.Text = c.TaxaEntrega.ToString();
                        pontosfidtxt.Enabled = true;
                        pontosfidtxt.ReadOnly = true;
                        pontosfidtxt.Text = $"{c.PontosFidelidade.ToString()} pontos";
                        if (c.Observacao == null)
                        {
                            obstxt.Text = "";
                        }
                        else
                        {
                            obstxt.Text = c.Observacao.ToString();
                        }

                    }
                }
                else
                {
                    habilitarcampos();
                    salvarbutton1.Enabled = true;
                    attbutton1.Enabled = false;
                }
            }
          
        }

        private void attbutton1_Click(object sender, EventArgs e)
        {
            if (telefone.Text == "" || telefone.Text == null)
            {
                MessageBox.Show(this, "Digite um Telefone para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nometxt.Text == "" || nometxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Nome para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show(this, "Digite um Endereço para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (numerotxt.Text == "" || numerotxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Número para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (bairrotxt.Text == "" || bairrotxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Bairro para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (municipiotxt.Text == "" || municipiotxt.Text == null)
            {
                MessageBox.Show(this, "Digite um Município para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txentregatxt.Text == "" || txentregatxt == null)
            {
                MessageBox.Show(this, "Digite uma taxa de entrega para o Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var db = new LanchoneteEntityContainer())
            {
                int tel = Convert.ToInt32(telefone.Text);
                Cliente c = db.Clientes.FirstOrDefault(u => u.Telefone == tel);
                c.Telefone = Convert.ToInt32(telefone.Text);
                c.NomeCliente = nometxt.Text.ToString();
                c.Endereco = textBox2.Text.ToString();
                c.Numero = Convert.ToInt32(numerotxt.Text);
                c.Bairro = bairrotxt.Text.ToString();
                c.Municipio = municipiotxt.Text.ToString();
                c.TaxaEntrega = Convert.ToDouble(txentregatxt.Text.Trim());
                if (complementotxt.Text == "" || complementotxt.Text == null)
                {
                    c.Complemento = "";
                }
                else
                {
                    c.Complemento = complementotxt.Text.ToString();
                }
                if (ceptxt.Text == "" || ceptxt.Text == null)
                {
                    c.CEP = "";
                }
                else
                {
                    c.CEP = ceptxt.Text.ToString();
                }
                if (obstxt.Text == "" || obstxt.Text == null)
                {
                    c.Observacao = "";
                }
                else
                {
                    c.Observacao = obstxt.Text.ToString();
                }
                if (cpftxt.Text == "" || cpftxt.Text == null)
                {
                    c.CPF = "";
                }
                else
                {
                    c.CPF = cpftxt.Text.ToString();
                }
                try
                {
                    db.SaveChanges();
                    MessageBox.Show(this, "Usuário Atualizado com sucesso !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    attbutton1.Enabled = false;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                    return;
                    
                }
            }


        }

        private void limpadadosbutton1_Click(object sender, EventArgs e)
        {
            limparCampos();
            salvarbutton1.Enabled = false;
            attbutton1.Enabled = false;
            desabilitarcampos();
        }

        private void cpftxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }

        private void numerotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }

        private void ceptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txentregatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txentregatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 )
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            

        }

        private void pontosfidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void complementotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
