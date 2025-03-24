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
         string usuario = textBoxUsuario.Text;
         string senha = textBoxSenha.Text;
            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMenssagem.Text = "Login bem-sucedido";
                labelMenssagem.ForeColor = Color.Green;
                gerenciamentoCliente form = new gerenciamentoCliente();
                form.ShowDialog();
            }
            else
            {
                labelMenssagem.Text = "Usuário ou senha Invalida";
                labelMenssagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
