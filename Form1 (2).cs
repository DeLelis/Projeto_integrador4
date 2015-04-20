using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroClienteDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroClienteDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.cadastroClienteDataSet.Cliente);

        }

        private void Habilitar(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            cPFMaskedTextBox.Enabled = true;
            enderecoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            telefoneMaskedTextBox.Enabled = true;
        }

        private void nomeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.Nome(this.cadastroClienteDataSet.Cliente, nomeToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
