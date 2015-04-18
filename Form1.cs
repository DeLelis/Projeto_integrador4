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

namespace Projeto_integrador4
{
    public partial class loga : Form
    {
        public loga()
        {
            InitializeComponent();
           
        }
        public Boolean formeprincipal = false;

        public void login(){

        string tab_login = "select * from tabel_login where usuario = @usuario";
        SqlConnection conex;
        SqlCommand coma;
        SqlDataReader reas;

        conex = new SqlConnection(Conexao.conex);
        coma = new SqlCommand(tab_login, conex);
        coma.Parameters.Add(new SqlParameter("@usuario", usuarioTx.Text));
        conex.Open();
        reas = coma.ExecuteReader(CommandBehavior.CloseConnection);
        while (reas.Read())
        {
            dados.usuario = Convert.ToString(reas["usuario"]);
            dados.senha = Convert.ToString(reas["senha"]);
            dados.id_login = Convert.ToInt32(reas["id_login"]);
        }
        conex.Close();

        if (dados.senha == senhaTx.Text)
        {
            formeprincipal = true;
            this.Dispose();

        }
        else
        {
            MessageBox.Show("Usúario ou Senha inválidos.");
            formeprincipal = false;

        }
      }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBT_Click(object sender, EventArgs e)
        {
            
        }

        private void entraBT_Click(object sender, EventArgs e)
        {
            login();
        }
    }
    

}