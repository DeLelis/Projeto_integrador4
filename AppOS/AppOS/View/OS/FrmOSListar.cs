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
    public partial class FrmOSListar : Form
    {
        int id;
        private List<COS> MinhasOS;
        private BancoOS bo = new BancoOS();
        public FrmOSListar()
        {
            InitializeComponent();
            this.MinhasOS = new List<COS>();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            this.MinhasOS.Clear();
            string sql = @"SELECT  id_os,nomecli,telefonecli,cpfcli,emailcli,enderecocli,nomefun,telefonefun,datacri,datafinal,marca,modelo,descrica_os,itens,fotos,valor_os,statos from os";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            SqlDataReader dados = comando.ExecuteReader();
            while (dados.Read())
            {
                COS o = new COS();
                o.idos = dados.GetInt32(0);
                o.nomecli = dados.GetString(1);
                o.telefonecli = dados.GetString(2);
                o.cpfcli = dados.GetString(3);
                o.emailcli = dados.GetString(4);
                o.endereçocli = dados.GetString(5);
                o.nomefun = dados.GetString(6);
                o.telefonefun = dados.GetString(7);
                o.datacri = dados.GetString(8);
                o.datafinal = dados.GetString(9);
                o.marca = dados.GetString(10);
                o.modelo = dados.GetString(11);
                o.descricao = dados.GetString(12);
                o.itens = dados.GetString(13);
                o.foto = dados.GetString(14);
                o.valoros = dados.GetString(15);
                o.statusos = dados.GetString(16);
                this.MinhasOS.Add(o);
            }
            dados.Close();

            dataGridViewOS.DataSource = null;
            dataGridViewOS.DataSource = this.MinhasOS;
            foreach (DataGridViewBand d in dataGridViewOS.Columns)
            {
                d.ReadOnly = true;
            }
        }
        private void LimparTela()
        {

            NomeCli.Text = null;
            TelefoneCli.Text = null;
            CpfCli.Text = null;
            emailcli.Text = null;
            enderecocli.Text = null;
            NomeFunc.Text = null;
            TelFunc.Text = null;
            DataCri.Text = null;
            DataVisita.Text = null;
            MarcaEquip.Text = null;
            ModeloEquip.Text = null;
            DescServ.Text = null;
            ItensOS.Text = null;
            FotoOS.Text = null;
            ValOS.Text = null;
            Status_Os.Text = null;
        }

        private void btnAlterarOS_Click(object sender, EventArgs e)
        {
            if (!isCOS())
            {
                MessageBox.Show("OS não cadastrada, selecione um cliente válido.");
            }
            else 
            {
                COS o = new COS();
                o.idos = id;
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
                bo.alterarOS(o);
                MessageBox.Show("OS alterada com sucesso!!!");
                AtualizarLista();
                LimparTela();
            }
        }

        private bool isCOS()
        {
            Boolean retorno = false;
            string sql = @"SELECT * from OS where cpfcli = '" + CpfCli.Text + "'";

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

        private void dataGridViewOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewOS.CurrentRow.Index;
            
                id = int.Parse(dataGridViewOS[0, row].Value.ToString());
                NomeCli.Text = dataGridViewOS[1, row].Value.ToString();
                TelefoneCli.Text = dataGridViewOS[2, row].Value.ToString();
                CpfCli.Text = dataGridViewOS[3, row].Value.ToString();
                emailcli.Text = dataGridViewOS[4, row].Value.ToString();
                enderecocli.Text = dataGridViewOS[5, row].Value.ToString();
                NomeFunc.Text = dataGridViewOS[6, row].Value.ToString();
                TelFunc.Text = dataGridViewOS[7, row].Value.ToString();
                DataCri.Text = dataGridViewOS[8, row].Value.ToString();
                DataVisita.Text = dataGridViewOS[9, row].Value.ToString();
                MarcaEquip.Text = dataGridViewOS[10, row].Value.ToString();
                ModeloEquip.Text = dataGridViewOS[11, row].Value.ToString();
                DescServ.Text = dataGridViewOS[12, row].Value.ToString();
                ItensOS.Text = dataGridViewOS[13, row].Value.ToString();
                FotoOS.Text = dataGridViewOS[14, row].Value.ToString();
                ValOS.Text = dataGridViewOS[15, row].Value.ToString();
                Status_Os.Text = dataGridViewOS[16, row].Value.ToString();

                pictureBox1.ImageLocation = dataGridViewOS[14, row].Value.ToString();
                if (FotoOS.Text == "Sem imagem")
                {

                }
                else { pictureBox1.Load(); }

        
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

    }
}
