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

namespace CadastroFuncionario
{   //Classe do Form
    public partial class CadastroFuncionario : Form
    {
        int id;
        private List<Funcionario> MeusFuncionarios;
        private Repositorio rep = new Repositorio();
        public CadastroFuncionario()
        {
            InitializeComponent();
            this.MeusFuncionarios = new List<Funcionario>();
            AtualizarLista();
        }
        //Metodo para atualizar a o Datagrid ou lista
        private void AtualizarLista()
        {
            this.MeusFuncionarios.Clear();
            string sql = @"SELECT id_funcionario, nome, telefone, cpf, email, endereco from funcionario";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            SqlDataReader dados = comando.ExecuteReader();
            while (dados.Read())
            {
                Funcionario f = new Funcionario();
                f.idfun = dados.GetInt32(0);
                f.nome = dados.GetString(1);
                f.telefone = dados.GetString(2);
                f.cpf = dados.GetString(3);
                f.email = dados.GetString(4);
                f.endereço = dados.GetString(5);
                this.MeusFuncionarios.Add(f);
            }
            dados.Close();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.MeusFuncionarios;
            foreach (DataGridViewBand d in dataGridView1.Columns)
            {
                d.ReadOnly = true;
            }
        }
        //Metodo para limpar os textbox e os masked
        private void LimparTela()
        {
           
             textNome.Text = null;
             maskedTextTelefone.Text = null;
             maskedTextCPF.Text = null;
             textEmail.Text = null;
             textEndereco.Text = null; 

        }
        //Botão de Cadastro
        private void btnCadastar_Click(object sender, EventArgs e)
        {
  
            if (textNome.Text != "")
            {
                Funcionario f = new Funcionario();
                f.nome = textNome.Text;
                f.telefone = maskedTextTelefone.Text;
                f.cpf = maskedTextCPF.Text;
                f.email = textEmail.Text;
                f.endereço = textEndereco.Text;

                Repositorio r = new Repositorio();
                r.addFuncionario(f);
                MessageBox.Show("Funcionario cadastrado com sucesso!!!");
                AtualizarLista();
                LimparTela();
            }
        }
        //Botão de alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!isFuncionario())
            {
                MessageBox.Show("Cliente não cadastrado, selecione um cliente válido.");
            }
            else
            {
                Funcionario f = new Funcionario();
                f.idfun = id;
                f.nome = textNome.Text;
                f.telefone = maskedTextTelefone.Text;
                f.cpf = maskedTextCPF.Text;
                f.email = textEmail.Text;
                f.endereço = textEndereco.Text;

                Repositorio r = new Repositorio();
                r.alterarFuncionario(f);
                MessageBox.Show("Funcionario alterado com sucesso!!!");
                AtualizarLista();
                LimparTela();   
            }
        }
        //Metodo para saber se esta selecionado no Datagrid
        private bool isFuncionario()
        {
            Boolean retorno = false;
            string sql = @"SELECT * from funcionario where cpf = '" + maskedTextCPF.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            SqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                retorno = true;
                break;
            }
            dados.Close();

            return retorno;
        }
        //Metodo para jogar oque esta no DataGrid para os textbox e masked
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            id = int.Parse(dataGridView1[0, row].Value.ToString());
            textNome.Text = dataGridView1[1, row].Value.ToString();
            maskedTextTelefone.Text = dataGridView1[2, row].Value.ToString();
            maskedTextCPF.Text = dataGridView1[3, row].Value.ToString();
            textEmail.Text = dataGridView1[4, row].Value.ToString();
            textEndereco.Text = dataGridView1[5, row].Value.ToString();
            
            
        }
        //Botão de excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!isFuncionario())
            {
                MessageBox.Show("Cliente não cadastrado, selecione um cliente válido.");
            }
            else
            {

                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    Funcionario f = new Funcionario();
                    f.idfun = id;
                    Repositorio r = new Repositorio();
                    r.excluirFuncionario(f);
                    MessageBox.Show("Excluido do banco");
                    AtualizarLista();
                    LimparTela();
                }
            }
        }
        //Botão de fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Botão de pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (maskedTextCPF.Text == null || !isFuncionario()) 
            {
                LimparTela();
                MessageBox.Show("Este CPF não existe em nosso banco de dados!!");
            }
            this.MeusFuncionarios.Clear();
            string sql = @"SELECT id_funcionario, nome, telefone, cpf , email,  endereco from funcionario where cpf = '" + maskedTextCPF.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            SqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                Funcionario f = new Funcionario();
                f.idfun = dados.GetInt32(0);
                f.nome = dados.GetString(1);
                f.telefone = dados.GetString(2);
                f.cpf = dados.GetString(3);
                f.email = dados.GetString(4);
                f.endereço = dados.GetString(5);
                this.MeusFuncionarios.Add(f);
            }
            cmd.Cancel();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.MeusFuncionarios;
            foreach (DataGridViewBand d in dataGridView1.Columns)
            {
                d.ReadOnly = true;
            }
        }
    }
}
