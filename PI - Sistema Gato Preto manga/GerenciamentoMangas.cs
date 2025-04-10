using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PI___Sistema_Gato_Preto_manga
{
    public partial class GerenciamentoMangas : Form
    {
        public GerenciamentoMangas()
        {
            InitializeComponent();
        }

        private void GerenciamentoMangas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvMangas.SelectedRows.Count > 0)
            {
                //pega ID do cliente da linha selecionada 
                int produtoID = Convert.ToInt32(dgvMangas.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este Produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=185.239.210.154; Port=3306; Database=u257619785_gato_preto; Uid=u257619785_gato; Pwd=Gpm@2025";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //abre a conexão 
                            consulta.Open();
                            //consulta SQL para selecionar os Produtos
                            string listagem = "DELETE FROM tb_mangas WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id", produtoID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Mangá excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o Mangá");
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os Produtos:" + ex.Message);
                    }

                }

                else
                {
                    MessageBox.Show("Por favor, selecione um Produtos para excluir!");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBoxSinopse_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextAnoLancamento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVolumes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClassificacaoIndicativa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=185.239.210.154; Port=3306; Database=u257619785_gato_preto; Uid=u257619785_gato; Pwd=Gpm@2025";

            try
            {
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();
                    string listagem = "SELECT id, titulo, genero, ano_de_lancamento, status, capitulos, classificacao_indicativa, sinopse, autor, capas FROM tb_mangas";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        DataTable dadosProdutos = new DataTable();
                        dadosProdutos.Load(reader);

                        dgvMangas.DataSource = dadosProdutos;

                        // Ocultar a coluna de imagem (byte[])
                        dgvMangas.Columns["capas"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Produtos: " + ex.Message);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            //DefIna sua string de conexão com o banco
            string conexaoString = "Server=185.239.210.154; Port=3306; Database=u257619785_gato_preto; Uid=u257619785_gato; Pwd=Gpm@2025";

            //defina a inserção de registro no BD

            string query = "INSERT INTO tb_mangas (titulo, genero, ano_de_lancamento, status, capitulos, classificacao_indicativa, sinopse, autor, capas) " +
                           "VALUES (@titulo, @genero, @ano_de_lancamento, @status, @capitulos, @classificacao_indicativa, @sinopse, @autor, @capas)";
            // Crie uma conexão com o BD

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    // Converter a imagem para um array de bytes
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    Console.WriteLine(imageBytes);
                    //Abre a conexão
                    //Abre a conexão
                    conexao.Open();

                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parâmetros com os valores dos TexBox
                        comando.Parameters.AddWithValue("@titulo", textBoxTitulo.Text);
                        comando.Parameters.AddWithValue("@genero", comboBoxGenero.Text);
                        comando.Parameters.AddWithValue("@ano_de_lancamento", maskedTextAnoLancamento.Text);
                        comando.Parameters.AddWithValue("@status", comboBoxStatus.Text);
                        comando.Parameters.AddWithValue("@capitulos", comboBoxVolumes.Text);
                        comando.Parameters.AddWithValue("@classificacao_indicativa", comboBoxClassificacaoIndicativa.Text);
                        comando.Parameters.AddWithValue("@sinopse", richTextBoxSinopse.Text);
                        comando.Parameters.AddWithValue("@autor", textBoxAutor.Text);
                        comando.Parameters.AddWithValue("@capas", imageBytes); 

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

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Text = "";
            comboBoxGenero.Text = "";
            maskedTextAnoLancamento.Text = "";
            comboBoxStatus.Text = "";
            comboBoxVolumes.Text = "";
            comboBoxClassificacaoIndicativa.Text = "";
            textBoxAutor.Text = "";
            richTextBoxSinopse.Text = "";
            pictureBox1.Text = "";
            textBoxTitulo.Focus();
        }
    }
}
