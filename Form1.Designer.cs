namespace NewProject
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
            this.Sifre = new System.Windows.Forms.TextBox();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.tex1 = new System.Windows.Forms.Label();
            this.tex2 = new System.Windows.Forms.Label();
            this.Giris = new System.Windows.Forms.Button();
            this.YniUye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(112, 124);
            this.Sifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(76, 20);
            this.Sifre.TabIndex = 0;
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(112, 66);
            this.kAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(76, 20);
            this.kAdi.TabIndex = 1;
            // 
            // tex1
            // 
            this.tex1.AutoSize = true;
            this.tex1.Location = new System.Drawing.Point(36, 69);
            this.tex1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tex1.Name = "tex1";
            this.tex1.Size = new System.Drawing.Size(64, 13);
            this.tex1.TabIndex = 2;
            this.tex1.Text = "Kullanıcı Adı";
            // 
            // tex2
            // 
            this.tex2.AutoSize = true;
            this.tex2.Location = new System.Drawing.Point(38, 128);
            this.tex2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tex2.Name = "tex2";
            this.tex2.Size = new System.Drawing.Size(28, 13);
            this.tex2.TabIndex = 3;
            this.tex2.Text = "Şifre";
            // 
            // Giris
            // 
            this.Giris.Location = new System.Drawing.Point(51, 177);
            this.Giris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(81, 62);
            this.Giris.TabIndex = 4;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = true;
            this.Giris.Click += new System.EventHandler(this.Giris_Click);
            // 
            // YniUye
            // 
            this.YniUye.Location = new System.Drawing.Point(161, 177);
            this.YniUye.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YniUye.Name = "YniUye";
            this.YniUye.Size = new System.Drawing.Size(75, 62);
            this.YniUye.TabIndex = 5;
            this.YniUye.Text = "Yeni Kayıt";
            this.YniUye.UseVisualStyleBackColor = true;
            this.YniUye.Click += new System.EventHandler(this.YniUye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 266);
            this.Controls.Add(this.YniUye);
            this.Controls.Add(this.Giris);
            this.Controls.Add(this.tex2);
            this.Controls.Add(this.tex1);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.Sifre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.Label tex1;
        private System.Windows.Forms.Label tex2;
        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.Button YniUye;
    }
}

