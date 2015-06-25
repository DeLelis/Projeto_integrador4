using AppOS.Dados;
using AppOS.View;
using AppOS.View.Home;
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

namespace AppOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login1 L1 = new Login1();
            L1.ShowDialog();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string sql = @"select count (*) from  login where login1 =@login and  senha =@senha";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            comando.Parameters.Add("@login", SqlDbType.VarChar).Value = text_login.Text;
            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = text_senha.Text;

            int i = (int)comando.ExecuteScalar();


            if (i > 0)
            {
                Home h = new Home();
                h.Show();
                this.Visible = false;

                MessageBox.Show("Login efetuado com sucesso" + "  " + text_login.Text);
                
            }
            else
            {
                MessageBox.Show("usuário ou senha incorreto");
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
