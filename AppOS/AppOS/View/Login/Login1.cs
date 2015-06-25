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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void btnOk1_Click(object sender, EventArgs e)
        {
            if (text_login1.Text == "adm" && text_senha1.Text == "123")
            {
                CadastroLogin cl = new CadastroLogin();
                cl.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Senha do Administrador incorreta!!!!");
            }
        }

        private void btncancel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
