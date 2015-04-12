namespace Projeto_integrador4
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
            this.usuariolb = new System.Windows.Forms.Label();
            this.usuarioTx = new System.Windows.Forms.TextBox();
            this.senhaTx = new System.Windows.Forms.TextBox();
            this.senhalb = new System.Windows.Forms.Label();
            this.entraBT = new System.Windows.Forms.Button();
            this.cancelarBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuariolb
            // 
            this.usuariolb.AutoSize = true;
            this.usuariolb.Location = new System.Drawing.Point(94, 57);
            this.usuariolb.Name = "usuariolb";
            this.usuariolb.Size = new System.Drawing.Size(46, 13);
            this.usuariolb.TabIndex = 0;
            this.usuariolb.Text = "Usúario:";
            this.usuariolb.Click += new System.EventHandler(this.Login_Click);
            // 
            // usuarioTx
            // 
            this.usuarioTx.Location = new System.Drawing.Point(157, 50);
            this.usuarioTx.Name = "usuarioTx";
            this.usuarioTx.Size = new System.Drawing.Size(110, 20);
            this.usuarioTx.TabIndex = 1;
            // 
            // senhaTx
            // 
            this.senhaTx.Location = new System.Drawing.Point(157, 112);
            this.senhaTx.Name = "senhaTx";
            this.senhaTx.Size = new System.Drawing.Size(110, 20);
            this.senhaTx.TabIndex = 2;
            // 
            // senhalb
            // 
            this.senhalb.AutoSize = true;
            this.senhalb.Location = new System.Drawing.Point(94, 115);
            this.senhalb.Name = "senhalb";
            this.senhalb.Size = new System.Drawing.Size(41, 13);
            this.senhalb.TabIndex = 3;
            this.senhalb.Text = "Senha:";
            this.senhalb.Click += new System.EventHandler(this.label1_Click);
            // 
            // entraBT
            // 
            this.entraBT.Location = new System.Drawing.Point(97, 177);
            this.entraBT.Name = "entraBT";
            this.entraBT.Size = new System.Drawing.Size(75, 23);
            this.entraBT.TabIndex = 4;
            this.entraBT.Text = "Entrar";
            this.entraBT.UseVisualStyleBackColor = true;
            this.entraBT.Click += new System.EventHandler(this.entraBT_Click);
            // 
            // cancelarBT
            // 
            this.cancelarBT.Location = new System.Drawing.Point(192, 177);
            this.cancelarBT.Name = "cancelarBT";
            this.cancelarBT.Size = new System.Drawing.Size(75, 23);
            this.cancelarBT.TabIndex = 5;
            this.cancelarBT.Text = "Cancelar";
            this.cancelarBT.UseVisualStyleBackColor = true;
            this.cancelarBT.Click += new System.EventHandler(this.cancelarBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 212);
            this.Controls.Add(this.cancelarBT);
            this.Controls.Add(this.entraBT);
            this.Controls.Add(this.senhalb);
            this.Controls.Add(this.senhaTx);
            this.Controls.Add(this.usuarioTx);
            this.Controls.Add(this.usuariolb);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuariolb;
        private System.Windows.Forms.TextBox usuarioTx;
        private System.Windows.Forms.TextBox senhaTx;
        private System.Windows.Forms.Label senhalb;
        private System.Windows.Forms.Button entraBT;
        private System.Windows.Forms.Button cancelarBT;
    }
}

