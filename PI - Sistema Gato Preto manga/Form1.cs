using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI___Sistema_Gato_Preto_manga
{
    public partial class Form1 : Form
    {
        bool VerSenhaTxt = false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            
            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMensagem.Text = "Login bem-sucedido";
                labelMensagem.ForeColor = Color.Green;
                GerenciamentoClientes form = new GerenciamentoClientes();
                form.ShowDialog();
            }
            else
            {
                labelMensagem.Text = "Usuário ou senha Invalida";
                labelMensagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxUsuario.Focus();
        }

        private void buttonMostrarSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                buttonMostrarSenha.Text = "Ocultar Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                buttonMostrarSenha.Text = "Mostrar Senha";
            }
        }
    }
}
