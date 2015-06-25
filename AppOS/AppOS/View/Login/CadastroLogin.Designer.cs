namespace AppOS.View
{
    partial class CadastroLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_login2 = new System.Windows.Forms.TextBox();
            this.text_senha2 = new System.Windows.Forms.TextBox();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.btncancel2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Senha:";
            // 
            // text_login2
            // 
            this.text_login2.Location = new System.Drawing.Point(124, 55);
            this.text_login2.Name = "text_login2";
            this.text_login2.Size = new System.Drawing.Size(154, 20);
            this.text_login2.TabIndex = 20;
            // 
            // text_senha2
            // 
            this.text_senha2.Location = new System.Drawing.Point(124, 97);
            this.text_senha2.Name = "text_senha2";
            this.text_senha2.Size = new System.Drawing.Size(154, 20);
            this.text_senha2.TabIndex = 21;
            this.text_senha2.UseSystemPasswordChar = true;
            // 
            // btnOk2
            // 
            this.btnOk2.Location = new System.Drawing.Point(124, 123);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(78, 26);
            this.btnOk2.TabIndex = 22;
            this.btnOk2.Text = "Ok";
            this.btnOk2.UseVisualStyleBackColor = true;
            this.btnOk2.Click += new System.EventHandler(this.btnOk2_Click);
            // 
            // btncancel2
            // 
            this.btncancel2.Location = new System.Drawing.Point(208, 123);
            this.btncancel2.Name = "btncancel2";
            this.btncancel2.Size = new System.Drawing.Size(78, 26);
            this.btncancel2.TabIndex = 23;
            this.btncancel2.Text = "Cancelar";
            this.btncancel2.UseVisualStyleBackColor = true;
            this.btncancel2.Click += new System.EventHandler(this.btncancel2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cadastro de Login";
            // 
            // CadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 152);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancel2);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.text_senha2);
            this.Controls.Add(this.text_login2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CadastroLogin";
            this.Text = "Cadastror Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox text_login2;
        public System.Windows.Forms.TextBox text_senha2;
        public System.Windows.Forms.Button btnOk2;
        public System.Windows.Forms.Button btncancel2;
    }
}