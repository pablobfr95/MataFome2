using MataFome2.Cache;
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
    public partial class TelaLogin : MetroFramework.Forms.MetroForm
    {
        int tentativa = 0;
        UsuarioController usucon = new UsuarioController(); 
        
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void verificarOperador(string nome, string data)
        {
            
            string horacomp = DateTime.Now.ToShortTimeString().ToString();
            string sohora = horacomp.Substring(0, 2);
            int hora = Convert.ToInt32(sohora);
            DateTime date = DateTime.Now;
            DateTime date2 = date.AddDays(-1);
            string dataanterior = date2.ToShortDateString().ToString();
            using (var db = new LanchoneteEntityContainer()) 
            {
                 Usuario usu = db.Usuarios.FirstOrDefault(u => u.Login == nome);
                OperadorCaixa op = db.OperadorCaixas.FirstOrDefault(u => u.Nome == nome && u.DataCaixa == data);
                OperadorCaixa op1 = db.OperadorCaixas.FirstOrDefault(u => u.Nome == nome && u.DataCaixa == dataanterior);
                if (op == null && hora > 3 )
                {
                    
                        OperadorCaixa operador = new OperadorCaixa();
                        operador.Nome = usuariotxt.Text.ToString();
                        operador.UsuarioId = usu.Id;
                        operador.Venda = 0;
                        operador.DataCaixa = DateTime.Now.ToShortDateString().ToString();
                        db.OperadorCaixas.Add(operador);
                        db.SaveChanges();


                        OperadorCaixa oper = db.OperadorCaixas.FirstOrDefault(u => u.Nome == operador.Nome);
                        OperadorCache.Operador = oper.Id;
                        OperadorCache.Nome = oper.Nome;
                        OperadorCache.UsuarioId = oper.UsuarioId;
                        OperadorCache.Venda = oper.Venda;
                        OperadorCache.DataCaixa = oper.DataCaixa;
                        MessageBox.Show("Operador para venda aberto com sucesso !");

                }
                else if (hora <= 3)
                {
                    if (op1 == null)
                    {
                        OperadorCaixa operador = new OperadorCaixa();
                        operador.Nome = usuariotxt.Text.ToString();
                        operador.UsuarioId = usu.Id;
                        operador.Venda = 0;
                        operador.DataCaixa = dataanterior;
                        db.OperadorCaixas.Add(operador);
                        db.SaveChanges();
                        OperadorCaixa oper = db.OperadorCaixas.FirstOrDefault(u => u.Nome == operador.Nome);
                        OperadorCache.Operador = oper.Id;
                        OperadorCache.Nome = oper.Nome;
                        OperadorCache.UsuarioId = oper.UsuarioId;
                        OperadorCache.Venda = oper.Venda;
                        OperadorCache.DataCaixa = oper.DataCaixa;
                        MessageBox.Show("Operador para venda aberto com sucesso com a Data do dia Anterior !");
                    }
                    else
                    {
                        OperadorCache.Operador = op1.Id;
                        OperadorCache.Nome = op1.Nome;
                        OperadorCache.UsuarioId = op1.UsuarioId;
                        OperadorCache.Venda = op1.Venda;
                        OperadorCache.DataCaixa = op1.DataCaixa;
                        MessageBox.Show("Operador para venda já foi aberto com a Data do dia Anterior !");
                        
                    }

                }
                else 
                {
                    OperadorCache.Operador = op.Id;
                    OperadorCache.Nome = op.Nome;
                    OperadorCache.UsuarioId = op.UsuarioId;
                    OperadorCache.Venda = op.Venda;
                    OperadorCache.DataCaixa = op.DataCaixa;
                    MessageBox.Show("Operador  já foi aberto hoje !");
                }
                
            }
        }

        private void usuariotxt_Click(object sender, EventArgs e)
        {

        }

        private void senhatxt_Click(object sender, EventArgs e)
        {

        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            if (usuariotxt.Text == "" || usuariotxt.Text == null)
            {
                MessageBox.Show("Digite um usuário !");
                usuariotxt.Focus();
                return;
            }
            if (senhatxt.Text == "" || senhatxt.Text == null)
            {
                MessageBox.Show($"Digite uma senha para o Usuário: {usuariotxt.Text.ToString()} ");
                senhatxt.Focus();
                return;
            }

            try
            {
                Usuario u = new Usuario();
                u.Login = usuariotxt.Text.ToString().ToLower();
                u.Senha = senhatxt.Text.ToString();
                
                if (usucon.Login(u) != null)
                {
                    MessageBox.Show($"BEM VINDO - {u.Login.ToUpper()}");
                    Form1 tela = new Form1();
                    using (var db = new LanchoneteEntityContainer())
                    {
                        Usuario usuario = db.Usuarios.FirstOrDefault(p => p.Login == u.Login);
                        UsuarioCache.Login = usuario.Login.ToString();
                        UsuarioCache.NivelUsuario = Convert.ToInt32(usuario.NivelAcesso.ToString());
                        UsuarioCache.UsuarioId =Convert.ToInt32(usuario.Id.ToString());
                    }
                    
                    tela.Show();
                    this.Hide();
                    string data = DateTime.Now.ToShortDateString().ToString();
                    verificarOperador(u.Login, data);

                }
                else
                {
                    
                    
                        MessageBox.Show("Usuário Incorreto, Digte o Usuário novamente. ");
                        usuariotxt.Focus();
                        tentativa++;
                   
                    if (tentativa == 3)
                    {
                        MessageBox.Show("Excesso de tentativas, Adeus !");
                        Application.Exit();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void senhatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loginButton1_Click(sender, e);
            }
        }
    }
}
