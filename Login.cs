using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TelaMenuProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexao = "Data Source=JESSICA\\SQLEXPRESS;Initial Catalog=OS;User ID=sa;Password=123"; 
            SqlConnection add = new SqlConnection(conexao);
            SqlCommand comando = new SqlCommand("select count (*) from  usuario where usuario =@user and  senha =@senha",add);
            comando.Parameters.Add("@user",SqlDbType.NVarChar).Value = text_login.Text;
            comando.Parameters.Add("@senha",SqlDbType.NVarChar).Value = text_senha.Text;

            add.Open();

            int i = (int)comando.ExecuteScalar();

            if (i>0)
            {
                MessageBox.Show("login efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("usuário ou senha incorreto");
            }
           
            add.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
