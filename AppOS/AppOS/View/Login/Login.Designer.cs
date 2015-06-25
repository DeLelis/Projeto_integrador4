namespace AppOS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.linkcadastro = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login :";
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(279, 64);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(154, 20);
            this.text_login.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Senha:";
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(279, 101);
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(154, 20);
            this.text_senha.TabIndex = 18;
            this.text_senha.UseSystemPasswordChar = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(261, 127);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(78, 26);
            this.btnok.TabIndex = 19;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(355, 127);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 26);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // linkcadastro
            // 
            this.linkcadastro.AutoSize = true;
            this.linkcadastro.Location = new System.Drawing.Point(324, 159);
            this.linkcadastro.Name = "linkcadastro";
            this.linkcadastro.Size = new System.Drawing.Size(86, 13);
            this.linkcadastro.TabIndex = 21;
            this.linkcadastro.TabStop = true;
            this.linkcadastro.Text = "Cadastre-se aqui";
            this.linkcadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcadastro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 181);
            this.Controls.Add(this.linkcadastro);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnok;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.LinkLabel linkcadastro;
        public System.Windows.Forms.TextBox text_login;
        public System.Windows.Forms.TextBox text_senha;
    }
}

