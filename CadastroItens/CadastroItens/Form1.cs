using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroItens
{
    public partial class Form1 : Form
    {
        private List<Itens> MeusItens;
        private RepositorioItens rep1 = new RepositorioItens();
        public Form1()
        {
            InitializeComponent();
            this.MeusItens = new List<Itens>();
            
        }

       
        private void limparTela()
        {
            textNome.Text = null;
            textDescricao.Text = null;
            textValor.Text = null;
        }
    
        private void butCadastar_Click(object sender, EventArgs e)
        {
             SqlConnection conexão = new SqlConnection("Server=EMYLLAINE;Database=Itens;Trusted_Connection=True;");
                conexão.Open();

                string sq = "INSERT INTO dbo.itens (Nome, Descricao, Valor) values ('" + textNome.Text + "', '" + textDescricao.Text + "', '" + textValor.Text + "')";
                SqlCommand comando = new SqlCommand(sq, conexão);
                comando.ExecuteNonQuery();

                conexão.Close();

                MessageBox.Show("Cadastrado no banco");
                limparTela();
            
        }
    }
}
