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
            textBoxNomeCompleto.Text = "";
            maskedsenha.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxNumero.Text = "";
            maskedTextBoxTelefone.Text = "";
            pictureBox1.Text = "";
            textBoxNomeCompleto.Focus();
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
            try
            {
                // Converter a imagem para um array de bytes
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] imageBytes = ms.ToArray();
                //Abre a conexão
                //Abre a conexão
                conexao.Open();

                //Crie o comando SQL
                using (MySqlCommand comando = new MySqlCommand(query, conexao))
                {
                    //Adicionar os parâmetros com os valores dos TexBox
                    comando.Parameters.AddWithValue("@Nome", textBoxNomeCompleto.Text);
                    comando.Parameters.AddWithValue("@Senha", maskedsenha.Text);
                    comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    comando.Parameters.AddWithValue("@Cep", maskedTextBoxCEP.Text);
                    comando.Parameters.AddWithValue("@Cpf", maskedTextBoxCPF.Text);
                    comando.Parameters.AddWithValue("@Numero", maskedTextBoxNumero.Text);
                    comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);
                    comando.Parameters.AddWithValue("@Imagem", imageBytes);

                    // Executa o comando de inserção
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                // em Caso de erro, exiba mensagem do erro
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void buttonEscolherImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            // Criar um OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Definir o filtro para apenas arquivos de imagem
            openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            // Se o usuário escolher um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carregar a imagem no PictureBox
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }

        private void buttonConsultarCliente_Click(object sender, EventArgs e)
        {

            //Defina sua string de conexão com o banco
            string connectionString = "Server=localhost; Port=3306; Database=bd_lanche_damaju; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados Mysql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //abre a conexão 
                    consulta.Open();
                    //consulta SQL para selecionar os Produtos
                    string listagem = "SELECT Id_Cliente, Nome, Senha, Email, Cep, Cpf, Numero, Telefone, Imagem FROM tb_cliente";

                    //Cria o comando Mysql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        //Executa a consulta e obtém o resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao DataGridView
                        dgvClientes.DataSource = dadosClientes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Clientes:" + ex.Message);
            }
        }

        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                //pega ID do cliente da linha selecionada 
                int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id_Cliente"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este Cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=bd_lanche_damaju; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //abre a conexão 
                            consulta.Open();
                            //consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_cliente WHERE Id_cliente = @Id_Cliente";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id_Cliente", clienteID);

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
    }
}
