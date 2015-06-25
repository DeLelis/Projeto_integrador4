namespace AppOS.View
{
    partial class Login1
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
            this.text_login1 = new System.Windows.Forms.TextBox();
            this.text_senha1 = new System.Windows.Forms.TextBox();
            this.btnOk1 = new System.Windows.Forms.Button();
            this.btncancel1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Senha:";
            // 
            // text_login1
            // 
            this.text_login1.Location = new System.Drawing.Point(117, 29);
            this.text_login1.Name = "text_login1";
            this.text_login1.Size = new System.Drawing.Size(154, 20);
            this.text_login1.TabIndex = 19;
            // 
            // text_senha1
            // 
            this.text_senha1.Location = new System.Drawing.Point(117, 62);
            this.text_senha1.Name = "text_senha1";
            this.text_senha1.Size = new System.Drawing.Size(154, 20);
            this.text_senha1.TabIndex = 20;
            this.text_senha1.UseSystemPasswordChar = true;
            // 
            // btnOk1
            // 
            this.btnOk1.Location = new System.Drawing.Point(117, 98);
            this.btnOk1.Name = "btnOk1";
            this.btnOk1.Size = new System.Drawing.Size(78, 26);
            this.btnOk1.TabIndex = 21;
            this.btnOk1.Text = "Ok";
            this.btnOk1.UseVisualStyleBackColor = true;
            this.btnOk1.Click += new System.EventHandler(this.btnOk1_Click);
            // 
            // btncancel1
            // 
            this.btncancel1.Location = new System.Drawing.Point(201, 98);
            this.btncancel1.Name = "btncancel1";
            this.btncancel1.Size = new System.Drawing.Size(78, 26);
            this.btncancel1.TabIndex = 22;
            this.btncancel1.Text = "Cancelar";
            this.btncancel1.UseVisualStyleBackColor = true;
            this.btncancel1.Click += new System.EventHandler(this.btncancel1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Validação do Cadastro do Login";
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 134);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancel1);
            this.Controls.Add(this.btnOk1);
            this.Controls.Add(this.text_senha1);
            this.Controls.Add(this.text_login1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login1";
            this.Text = "Login1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_login1;
        private System.Windows.Forms.TextBox text_senha1;
        private System.Windows.Forms.Button btnOk1;
        private System.Windows.Forms.Button btncancel1;
        private System.Windows.Forms.Label label3;
    }
}