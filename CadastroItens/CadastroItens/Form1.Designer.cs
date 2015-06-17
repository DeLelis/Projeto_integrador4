namespace CadastroItens
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butCadastar = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butCadastar
            // 
            this.butCadastar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butCadastar.Location = new System.Drawing.Point(247, 169);
            this.butCadastar.Name = "butCadastar";
            this.butCadastar.Size = new System.Drawing.Size(75, 23);
            this.butCadastar.TabIndex = 0;
            this.butCadastar.Text = "Cadastrar";
            this.butCadastar.UseVisualStyleBackColor = true;
            this.butCadastar.Click += new System.EventHandler(this.butCadastar_Click);
            // 
            // butSair
            // 
            this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butSair.Location = new System.Drawing.Point(95, 169);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(75, 23);
            this.butSair.TabIndex = 1;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(121, 33);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(234, 20);
            this.textNome.TabIndex = 5;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(121, 122);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 7;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(122, 79);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(234, 20);
            this.textDescricao.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 232);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butCadastar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCadastar;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.TextBox textDescricao;
    }
}

