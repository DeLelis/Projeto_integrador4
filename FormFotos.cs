using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace inserirfotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conexao;
            SqlCommand comando;


            conexao = new SqlConnection("Data Source=JESSICA\\SQLEXPRESS;Initial Catalog=IMG;Persist Security Info=True;User ID=sa;Password=123;");
            comando = conexao.CreateCommand();


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao;
            SqlCommand comando;

            //ABRE A CONEXAO
            conexao = new SqlConnection("Data Source=JESSICA\\SQLEXPRESS;Initial Catalog=IMG;Persist Security Info=True;User ID=sa;Password=123;");
            //COMANDO DA CONEXAO
            comando = conexao.CreateCommand();
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.ShowDialog();
            try
            {

               if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   //CARREGA A TELA DE PROCURA DE IMAGENS
                    imgImagem.Load(OpenFileDialog1.FileName);
                    comando.Parameters.Clear();
                    comando.CommandText = "INSERT INTO TbIMAGENS (ImgDESCRICAO, ImgCAMINHO) VALUES (@DESCRICAO, @CAMINHO)";
                    comando.Parameters.AddWithValue("DESCRICAO", txtDescricao.Text);
                    comando.Parameters.AddWithValue("CAMINHO", OpenFileDialog1.FileName);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Imagem cadastrada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
