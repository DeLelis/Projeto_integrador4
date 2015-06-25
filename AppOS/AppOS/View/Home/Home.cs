using AppOS.Dados;
using AppOS.Negocio;
using AppOS.View.Cliente;
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

namespace AppOS.View.Home
{
    public partial class Home : Form
    {
        private List<CCliente> MeusClientes;
        private BancoCliente bc = new BancoCliente();
        public Home()
        {
            InitializeComponent();
            this.MeusClientes = new List<CCliente>();
            AtualizarLista();
        }

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

            dataGridViewHome.DataSource = null;
            dataGridViewHome.DataSource = this.MeusClientes;
            foreach (DataGridViewBand d in dataGridViewHome.Columns)
            {
                d.ReadOnly = true;
            }
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
            DialogResult result = MessageBox.Show("Deseja realmente fechar a aplicação?", "Fechar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listarOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOSListar ol = new FrmOSListar();
            ol.ShowDialog();
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
        
    }
}
