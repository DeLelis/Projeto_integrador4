using AppOS.Dados;
using AppOS.Negocio;
using AppOS.View.Cliente;
using AppOS.View.OS;
using AppOS.View.Peças;
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

namespace AppOS.View.Funcionario
{
    public partial class FrmFuncionario : Form
    {
        int id;
        private List<CFuncionario> MeusFuncionarios;
        private BancoFuncionario bf = new BancoFuncionario();
        public FrmFuncionario()
        {
            InitializeComponent();
            this.MeusFuncionarios = new List<CFuncionario>();
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
                CFuncionario f = new CFuncionario();
                f.idfun = dados.GetInt32(0);
                f.nome = dados.GetString(1);
                f.telefone = dados.GetString(2);
                f.cpf = dados.GetString(3);
                f.email = dados.GetString(4);
                f.endereço = dados.GetString(5);
                this.MeusFuncionarios.Add(f);
            }
            dados.Close();

            dataGridViewFuncionario.DataSource = null;
            dataGridViewFuncionario.DataSource = this.MeusFuncionarios;
            foreach (DataGridViewBand d in dataGridViewFuncionario.Columns)
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
        private void btnAdicionarfun_Click(object sender, EventArgs e)
        {
            if (textNome.Text != "")
            {
                CFuncionario f = new CFuncionario();
                f.nome = textNome.Text;
                f.telefone = maskedTextTelefone.Text;
                f.cpf = maskedTextCPF.Text;
                f.email = textEmail.Text;
                f.endereço = textEndereco.Text;

                BancoFuncionario bf1 = new BancoFuncionario();
                bf1.addFuncionario(f);
                MessageBox.Show("Funcionario cadastrado com sucesso!!!");
                AtualizarLista();
                LimparTela();
            }
        }
        //Botão de alterar
        private void btnAlterarfun_Click(object sender, EventArgs e)
        {
            if (!isCFuncionario())
            {
                MessageBox.Show("Funcionario não cadastrado, selecione um cliente válido.");
            }
            else
            {
                CFuncionario f = new CFuncionario();
                f.idfun = id;
                f.nome = textNome.Text;
                f.telefone = maskedTextTelefone.Text;
                f.cpf = maskedTextCPF.Text;
                f.email = textEmail.Text;
                f.endereço = textEndereco.Text;

                BancoFuncionario bf2 = new BancoFuncionario();
                bf2.alterarFuncionario(f);
                MessageBox.Show("Funcionario alterado com sucesso!!!");
                AtualizarLista();
                LimparTela();
            }
        }
        //Botão de excluir
        private void btnExcluirfun_Click(object sender, EventArgs e)
        {
            if (!isCFuncionario())
            {
                MessageBox.Show("Funcionario não cadastrado, selecione um cliente válido.");
            }
            else
            {

                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o funcionario selecionado?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    CFuncionario f = new CFuncionario();
                    f.idfun = id;
                    BancoFuncionario bf3 = new BancoFuncionario();
                    bf3.excluirFuncionario(f);
                    MessageBox.Show("Excluido do banco");
                    AtualizarLista();
                    LimparTela();
                }
            }
        }
        //Metodo para saber se esta selecionado no Datagrid
        private bool isCFuncionario()
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
        private void dataGridViewFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewFuncionario.CurrentRow.Index;

            id = int.Parse(dataGridViewFuncionario[0, row].Value.ToString());
            textNome.Text = dataGridViewFuncionario[1, row].Value.ToString();
            maskedTextTelefone.Text = dataGridViewFuncionario[2, row].Value.ToString();
            maskedTextCPF.Text = dataGridViewFuncionario[3, row].Value.ToString();
            textEmail.Text = dataGridViewFuncionario[4, row].Value.ToString();
            textEndereco.Text = dataGridViewFuncionario[5, row].Value.ToString();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.Show();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPecas p = new FrmPecas();
            p.Show();
        }

        private void oSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOS o = new FrmOS();
            o.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            FrmCliente c = new FrmCliente();
            c.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmPecas p = new FrmPecas();
            p.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmOS o = new FrmOS();
            o.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmOSListar ol = new FrmOSListar();
            ol.ShowDialog();
        }

        private void listarOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOSListar ol = new FrmOSListar();
            ol.ShowDialog();
        }

    }
}
