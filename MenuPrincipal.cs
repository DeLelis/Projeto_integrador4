using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class MenuPrincipal : Form
    {
        

        public MenuPrincipal()
        {
            InitializeComponent();
            dataGridView();
            
            
        }

       

        private void dataGridView()
        {
            {
                //o dataGridView1 está limpando as linhas
                dataGridView1.Rows.Clear();
                //está indico o número de colunas que será exibido dentro do dataGridView1
                dataGridView1.ColumnCount = 6;
                //É a Instância da conexão onde passa a ConnectionString 
                var con = new SqlConnection("Data Source=VAIO\\SQLEXPRESS;Initial Catalog=OS;User ID=sa;Password=123");
                //sql que será executado na tabela cliente
                var sql = "SELECT * FROM cliente";
                //É a instância do comando onde passo o sql e a conexão como parâmetro
                var comando = new SqlCommand(sql, con);
                //abre a conexão
                con.Open();
                //instância o leitor
                var leitor = comando.ExecuteReader();
                //enquanto o leitor está lendo
                while (leitor.Read())
                {
                    //inserindo os dados no dataGridView1
                    dataGridView1.Rows.Add(leitor[0].ToString(),
                        leitor[1].ToString(),
                        leitor[2].ToString(),
                        leitor[3].ToString(),
                        leitor[4].ToString(),
                        leitor[5].ToString());
                    
                }
                con.Close();
            }
        }
       

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {//chamando o form do cliente
            frmCliente cli = new frmCliente();
            cli.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {//chamando o form do funcionario
            CadastroFuncionario fun= new CadastroFuncionario();
            fun.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            dataGridView();
            //informo quantas colunas dataGridView1
           
            dataGridView1.ColumnCount = 6;
            //Informo os nomes das colunas do dataGridView1
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "CPF";
            dataGridView1.Columns[3].Name = "Endereço";
            dataGridView1.Columns[4].Name = "Email";
            dataGridView1.Columns[5].Name = "Telefone";
            



           
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            
           

        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();

            frmCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {//botão excluir coluna do dataGridView1 sendo conectado com o banco
            

                string sql = "DELETE FROM cliente WHERE id_cliente= " + dataGridView1.CurrentRow.Cells[0].Value;
                SqlConnection con = new SqlConnection("Data Source=VAIO\\SQLEXPRESS;Initial Catalog=OS;User ID=sa;Password=123");
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show(i + "Dados Excluídos Com Sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    
                }

                con.Close();

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void funcionariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroFuncionario fun = new CadastroFuncionario();
            fun.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarFuncionario lisFun = new frmListarFuncionario();
            lisFun.ShowDialog();
        }

        private void pecasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPecas CadastroPecas = new CadastroPecas();

            CadastroPecas.Show();
        }

        private void peçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarItens frmListarItens = new frmListarItens();
            frmListarItens.Show();
        }

        private void oSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarOrdemDeServio CriarOrdemDeServio = new CriarOrdemDeServio();
            CriarOrdemDeServio.Show();
        }

        private void oDSToolStripMenuItem_Click(object sender, EventArgs e)
        {//arrayCliente criado para quando selecionar um cliente todas as informções
            List<String> arrayCliente = new List<string>();
       
            Int32 selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                   

                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        
                        arrayCliente.Add(dataGridView1.SelectedRows[i].Cells[1].Value.ToString());
                        arrayCliente.Add(dataGridView1.SelectedRows[i].Cells[2].Value.ToString());
                        arrayCliente.Add(dataGridView1.SelectedRows[i].Cells[3].Value.ToString());
                        arrayCliente.Add(dataGridView1.SelectedRows[i].Cells[4].Value.ToString());
                        arrayCliente.Add(dataGridView1.SelectedRows[i].Cells[5].Value.ToString());
                        
                    }

                }

                CriarOrdemDeServio criarOrdemServ = new CriarOrdemDeServio(arrayCliente);
            criarOrdemServ.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void oSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listarOs listarOs = new listarOs();
            listarOs.Show();
        }
            
        }
    }

