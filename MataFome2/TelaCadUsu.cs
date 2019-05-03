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
    public partial class TelaCadUsu : Form
    {
        public TelaCadUsu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadUsu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mataFomeDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.mataFomeDataSet1.Usuarios);

        }

        private void nometxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void confsenhatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nivel1checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (nivel1checkBox1.Checked == true)
            {
                nivel2checkBox2.Enabled = false;
            }
            else
            {
                nivel2checkBox2.Enabled = true;
            }
        }

        private void nivel2checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (nivel2checkBox2.Checked == true)
            {
                nivel1checkBox1.Enabled = false;
            }
            else
            {
                nivel1checkBox1.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salvarbutton1_Click(object sender, EventArgs e)
        {
            if (nometxt.Text == "" || nometxt.Text == null)
            {
                MessageBox.Show("Informe o nome do Usuário ");
                nometxt.Focus();
                return;
            }
            if (senhatxt.Text == "" || senhatxt.Text == null)
            {
                MessageBox.Show("Informe a senha ");
                senhatxt.Focus();
                return;
            }
            if (confsenhatxt.Text == "" || confsenhatxt.Text == null)
            {
                MessageBox.Show("Confirme a senha !");
                confsenhatxt.Focus();
                return;
            }

            if (senhatxt.Text != confsenhatxt.Text)
            {
                MessageBox.Show("As senhas informadas não estão iguais, digite e confirme a senha novamente !");
                senhatxt.Focus();
                return;
            }

            if (nivel1checkBox1.Checked == false && nivel2checkBox2.Checked == false)
            {
                MessageBox.Show("Escolha pelo menos um nível de usuário !");
                nivel1checkBox1.Focus();
                return;
            }

            Usuario u = new Usuario();
            u.Login = nometxt.Text.ToString().ToLower();
            u.Senha = senhatxt.Text.ToString();
            if (nivel1checkBox1.Checked == true)
            {
                u.NivelAcesso = 1;
            }
            else
            {
                u.NivelAcesso = 2;
            }
            UsuarioController usucon = new UsuarioController();
            if (usucon.Cadastrar(u) == true)    
            {
                MessageBox.Show("Usuário Cadastrado com sucesso !");
                popularGrid();
            }
            else
            {
                MessageBox.Show("Usuário já Cadastrado !");
                nometxt.Focus();
            }
        }

        private void attbutton2_Click(object sender, EventArgs e)
        {

        }

        private void popularGrid()
        {
            using (var db = new LanchoneteEntityContainer())
            {
                IEnumerable<Usuario> lista = from u in db.Usuarios select u;
                dataGridView1.DataSource = lista.ToList();
            }
        }
        

    }
}
