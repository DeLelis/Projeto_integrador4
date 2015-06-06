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

namespace Projeto
{
    public partial class frmItens : Form
    {
        public frmItens()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { //conexão do banco de dados com a tabela de Itens

            string conexao = "Data Source=JESSICA\\SQLEXPRESS;Initial Catalog=OS;User ID=sa;Password=123";
            SqlConnection add = new SqlConnection(conexao);
            SqlCommand comando = new SqlCommand("select count (*) from  itens where nome =@nome descricao=@descricao and  valor =@valor", add);
            comando.Parameters.Add("@nome", SqlDbType.NVarChar).Value = textNome.Text;
            comando.Parameters.Add("@descricao", SqlDbType.NVarChar).Value = richTextDescricao.Text;
            comando.Parameters.Add("@valor", SqlDbType.NVarChar).Value = textValor.Text;

            add.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
