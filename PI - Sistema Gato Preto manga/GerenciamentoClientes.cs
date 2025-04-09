using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI___Sistema_Gato_Preto_manga
{
    public partial class GerenciamentoClientes : Form
    {
        public GerenciamentoClientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxSenha.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxNome.Focus();
        }

        private void GerenciamentoClientes_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            GerenciamentoMangas form = new GerenciamentoMangas();
            form.ShowDialog();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;

            if (ValidarCpf(cpf))
            {
                labelAlert.Text = "CPF VÁLIDO";
                labelAlert.ForeColor = Color.Green;
            }
            else
            {

                labelAlert.Text = "CPF INVÁLIDO";
                labelAlert.ForeColor = Color.Red;
                maskedTextBoxCPF.Text = "";
                maskedTextBoxCPF.Focus();
            }

            //Defuna sua string de conexão com o banco
            string conexaoString = "Server=localhost; Port=3306; Database=bd_gato_preto; Uid=root; Pwd=;";

            //defina a inserção de registro no BD

            string query = "INSERT INTO tb_Clientes (email, telefone, cpf, senha, nome) VALUES (@email, @telefone, @cpf, @senha, @nome)";

            // Crie uma conexão com o BD

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open(); // ✅ abre a conexão com o banco de dados

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        comando.Parameters.AddWithValue("@telefone", maskedTextBoxTelefone.Text);
                        comando.Parameters.AddWithValue("@cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@senha", textBoxSenha.Text);
                        comando.Parameters.AddWithValue("@nome", textBoxNome.Text);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }


        private void buttonConsultarCliente_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=3306; Database=bd_gato_preto; Uid=root; Pwd=;Convert Zero Datetime=True";

            try
            {
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();
                    string listagem = "SELECT id, email, telefone, cpf, senha, nome FROM tb_clientes";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        dgvClientes.DataSource = dadosClientes;

                        // Apenas se a coluna existir. Caso contrário, comente a linha abaixo:
                        // dgvClientes.Columns["imagem"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Clientes: " + ex.Message);
            }
        }



        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                //pega ID do cliente da linha selecionada 
                int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este Cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=bd_gato_preto; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //abre a conexão 
                            consulta.Open();
                            //consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_clientes WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o Cliente");
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os Clientes:" + ex.Message);
                    }

                }

                else
                {
                    MessageBox.Show("Por favor, selecione um Clientes para excluir!");
                }
            }
        }


         private bool ValidarCpf(string cpf)
        {
            // Remove qualquer caractere não numérico
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se o CPF é uma sequência de números iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calculando o primeiro dígito verificador
            int soma = 0;
            int peso = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;

            // Calculando o segundo dígito verificador
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
        
        
    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxEmail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
