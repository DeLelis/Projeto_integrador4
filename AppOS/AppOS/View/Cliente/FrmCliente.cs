using AppOS.Dados;
using AppOS.Negocio;
using AppOS.View.Funcionario;
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

namespace AppOS.View.Cliente
{
    public partial class FrmCliente : Form
    {
        int id;
        private List<CCliente> MeusClientes;
        private BancoCliente bc = new BancoCliente();
        public FrmCliente()
        {
            InitializeComponent();
            this.MeusClientes = new List<CCliente>();
            AtualizarLista();
        }
        //Metodo para atualizar a o Datagrid ou lista
        private void AtualizarLista()
        {
            this.MeusClientes.Clear();
            string sql = @"SELECT id_cliente, nome, telefone, cpf, email, endereco from Cliente";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            SqlDataReader dados = comando.ExecuteReader();
            while (dados.Read())
            {
                CCliente c = new CCliente();
                c.idcli = dados.GetInt32(0);
                c.nome = dados.GetString(1);
                c.telefone = dados.GetString(2);
                c.cpf = dados.GetString(3);
                c.email = dados.GetString(4);
                c.endereço = dados.GetString(5);
                this.MeusClientes.Add(c);
            }
            dados.Close();

            dataGridViewCliente.DataSource = null;
            dataGridViewCliente.DataSource = this.MeusClientes;
            foreach (DataGridViewBand d in dataGridViewCliente.Columns)
            {
                d.ReadOnly = true;
            }
        }
        //Metodo para limpar os textbox e os masked
        private void LimparTela()
        {

            textNomeCli.Text = null;
            maskedTextTelefonecli.Text = null;
            maskedTextCPFcli.Text = null;
            textemail.Text = null;
            textendereco.Text = null;

        }
        //Botão de Cadastro
        private void btnAdicionarCli_Click(object sender, EventArgs e)
        {

            if (textNomeCli.Text != "")
            {
                CCliente c = new CCliente();
                c.nome = textNomeCli.Text;
                c.telefone = maskedTextTelefonecli.Text;
                c.cpf = maskedTextCPFcli.Text;
                c.email = textemail.Text;
                c.endereço = textendereco.Text;

                BancoCliente bc1 = new BancoCliente();
                bc1.addCliente(c);
                MessageBox.Show("Cliente cadastrado com sucesso!!!");
                AtualizarLista();
                LimparTela();
            }
        }
        //Botão de alterar
        private void btnAlterarcli_Click(object sender, EventArgs e)
        {
            if (!isCCliente())
            {
                MessageBox.Show("Cliente não cadastrado, selecione um cliente válido.");
            }
            else
            {
                CCliente c = new CCliente();
                c.idcli = id;
                c.nome = textNomeCli.Text;
                c.telefone = maskedTextTelefonecli.Text;
                c.cpf = maskedTextCPFcli.Text;
                c.email = textemail.Text;
                c.endereço = textendereco.Text;

                BancoCliente bc2 = new BancoCliente();
                bc2.alterarCliente(c);
                MessageBox.Show("Cliente alterado com sucesso!!!");
                AtualizarLista();
                LimparTela();
            }
        }
        //Botão de excluir
        private void btnExcluircli_Click(object sender, EventArgs e)
        {
            if (!isCCliente())
            {
                MessageBox.Show("Cliente não cadastrado, selecione um cliente válido.");
            }
            else
            {

                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    CCliente c = new CCliente();
                    c.idcli = id;
                    BancoCliente bc3 = new BancoCliente();
                    bc3.excluirCliente(c);
                    MessageBox.Show("Excluido do banco");
                    AtualizarLista();
                    LimparTela();
                }
            }
        }
        //Metodo para saber se esta selecionado no Datagrid
        private bool isCCliente()
        {
            Boolean retorno = false;
            string sql = @"SELECT * from cliente where cpf = '" + maskedTextCPFcli.Text + "'";

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

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewCliente.CurrentRow.Index;

            id = int.Parse(dataGridViewCliente[0, row].Value.ToString());
            textNomeCli.Text = dataGridViewCliente[1, row].Value.ToString();
            maskedTextTelefonecli.Text = dataGridViewCliente[2, row].Value.ToString();
            maskedTextCPFcli.Text = dataGridViewCliente[3, row].Value.ToString();
            textemail.Text = dataGridViewCliente[4, row].Value.ToString();
            textendereco.Text = dataGridViewCliente[5, row].Value.ToString();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario f = new FrmFuncionario();
            f.Show();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmFuncionario f = new FrmFuncionario();
            f.Show();
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
