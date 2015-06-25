using AppOS.Dados;
using AppOS.Negocio;
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

namespace AppOS.View.OS
{
    public partial class FrmOS : Form
    {   
        public FrmOS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = @"SELECT nome, telefone, cpf, email, endereco from Cliente where nome='" + NomeCli.Text + "'";

             SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
             SqlDataReader dados = comando.ExecuteReader();
             while (dados.Read())
             {
                 
                 NomeCli.Text = dados.GetString(0);
                 TelefoneCli.Text = dados.GetString(1);
                 CpfCli.Text = dados.GetString(2);
                 emailcli.Text = dados.GetString(3);
                 enderecocli.Text = dados.GetString(4);
             } 
              dados.Close();
            
           }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT nome, telefone from funcionario where nome='"+NomeFunc.Text+"'";
           
            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            SqlDataReader dados = comando.ExecuteReader();
            while (dados.Read())
            {

                NomeFunc.Text = dados.GetString(0);
                TelFunc.Text = dados.GetString(1);
                
            }
            dados.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FotoOS.Text = openFileDialog1.FileName;

                pictureBox1.ImageLocation = openFileDialog1.FileName;

                pictureBox1.Load();
            }
        }

        private void CANCEL_BUT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_BUT_Click(object sender, EventArgs e)
        {
            if (NomeCli.Text != "")
            {
                COS o = new COS();
                o.nomecli = NomeCli.Text;
                o.telefonecli = TelefoneCli.Text;
                o.cpfcli = CpfCli.Text;
                o.emailcli = emailcli.Text;
                o.endereçocli = enderecocli.Text;
                o.nomefun = NomeFunc.Text;
                o.telefonefun = TelFunc.Text;
                o.datacri = DataCri.Text;
                o.datafinal = DataVisita.Text;
                o.marca = MarcaEquip.Text;
                o.modelo = ModeloEquip.Text;
                o.descricao = DescServ.Text;
                o.itens = ItensOS.Text;
                o.foto = FotoOS.Text;
                o.valoros = ValOS.Text;
                o.statusos = Status_Os.Text;
                BancoOS bo = new BancoOS();
                bo.addOS(o);
                MessageBox.Show("OS cadastrada com sucesso!!!");
            }
        }

        private void btnAlterarOs_Click(object sender, EventArgs e)
        {
            FrmOSListar ol = new FrmOSListar();
            ol.ShowDialog();
        }

    }
}
