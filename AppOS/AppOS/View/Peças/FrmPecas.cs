using AppOS.Dados;
using AppOS.Negocio;
using AppOS.View.Cliente;
using AppOS.View.Funcionario;
using AppOS.View.OS;
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

namespace AppOS.View.Peças
{
    public partial class FrmPecas : Form
    {
        int id;
        private List<CPecas> MinhasPecas;
        private BancoPecas bp = new BancoPecas();
        public FrmPecas()
        {
            InitializeComponent();
            this.MinhasPecas = new List<CPecas>();
            AtualizarLista();
        }
        //Metodo para atualizar a o Datagrid ou lista
        private void AtualizarLista()
        {
            this.MinhasPecas.Clear();
            string sql = @"SELECT id_itens, nome, valor, descricao from itens";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            SqlDataReader dados = comando.ExecuteReader();
            while (dados.Read())
            {
                CPecas p = new CPecas();
                p.iditem = dados.GetInt32(0);
                p.nomepe = dados.GetString(1);
                p.valor = dados.GetString(2);
                p.descricao = dados.GetString(3);
                this.MinhasPecas.Add(p);
            }
            dados.Close();

            dataGridViewItem.DataSource = null;
            dataGridViewItem.DataSource = this.MinhasPecas;
            foreach (DataGridViewBand d in dataGridViewItem.Columns)
            {
                d.ReadOnly = true;
            }
        }
        //Metodo para limpar os textbox e os masked
        private void LimparTela()
        {

            textItem.Text = null;
            textValor.Text = null;
            textDescricao.Text = null;

        }

        private void btnAdicionaritem_Click(object sender, EventArgs e)
        {
              
            if (textItem.Text != "")
            {
                CPecas p = new CPecas();
                p.nomepe = textItem.Text;
                p.valor = textValor.Text;
                p.descricao = textDescricao.Text;

                BancoPecas bp = new BancoPecas();
                bp.addPecas(p);
                MessageBox.Show("Peça cadastrada com sucesso!!!");
                AtualizarLista();
                LimparTela();
            }
        }

        private void btnAlteraritem_Click(object sender, EventArgs e)
        {
            if (!isCPecas())
            {
                MessageBox.Show("Peça não cadastrado, selecione uma peça válido.");
            }
            else
            {
                CPecas p = new CPecas();
                p.iditem = id;
                p.nomepe = textItem.Text;
                p.valor = textValor.Text;
                p.descricao = textDescricao.Text;

                BancoPecas bp = new BancoPecas();
                bp.alterarPecas(p);
                MessageBox.Show("Peça alterada com sucesso!!!");
                AtualizarLista();
                LimparTela();
            }
        }

        private void btnExcluiritem_Click(object sender, EventArgs e)
        {
            if (!isCPecas())
            {
                MessageBox.Show("Peça não cadastrado, selecione um peça válido.");
            }
            else
            {

                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir a peça selecionada?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    CPecas p = new CPecas();
                    p.iditem = id;
                    BancoPecas bp = new BancoPecas();
                    bp.excluirPecas(p);
                    MessageBox.Show("Excluido do banco");
                    AtualizarLista();
                    LimparTela();
                }
            }
        }

        private bool isCPecas()
        {
            Boolean retorno = false;
            string sql = @"SELECT * from itens where nome = '" + textItem.Text + "'";

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

        private void dataGridViewItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewItem.CurrentRow.Index;

            id = int.Parse(dataGridViewItem[0, row].Value.ToString());
            textItem.Text = dataGridViewItem[1, row].Value.ToString();
            textValor.Text = dataGridViewItem[2, row].Value.ToString();
            textDescricao.Text = dataGridViewItem[3, row].Value.ToString();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario f = new FrmFuncionario();
            f.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.Show();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.Show();
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
