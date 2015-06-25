using AppOS.Dados;
using AppOS.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOS.View
{
    public partial class CadastroLogin : Form
    {
        public CadastroLogin()
        {
            InitializeComponent();
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            CLogin c = new CLogin();
            c.login = text_login2.Text;
            c.senha = text_senha2.Text;
            BancoLogin b = new BancoLogin();
            b.addLogin(c);
           
            DialogResult resposta = MessageBox.Show("Login cadastrado com sucesso", "Atenção", MessageBoxButtons.OK);
            Login l = new Login();
            l.ShowDialog();
        }

        private void btncancel2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
