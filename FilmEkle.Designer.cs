namespace NewProject
{
    partial class FilmEkle
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
            this.tex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.Tur = new System.Windows.Forms.TextBox();
            this.PosterYolu = new System.Windows.Forms.TextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.releseTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tex
            // 
            this.tex.AutoSize = true;
            this.tex.Location = new System.Drawing.Point(27, 73);
            this.tex.Name = "tex";
            this.tex.Size = new System.Drawing.Size(28, 17);
            this.tex.TabIndex = 0;
            this.tex.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yapım Yılı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Poster Adresi";
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(159, 73);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(100, 22);
            this.Ad.TabIndex = 4;
            // 
            // Tur
            // 
            this.Tur.Location = new System.Drawing.Point(159, 189);
            this.Tur.Name = "Tur";
            this.Tur.Size = new System.Drawing.Size(100, 22);
            this.Tur.TabIndex = 6;
            // 
            // PosterYolu
            // 
            this.PosterYolu.Location = new System.Drawing.Point(159, 252);
            this.PosterYolu.Name = "PosterYolu";
            this.PosterYolu.Size = new System.Drawing.Size(100, 22);
            this.PosterYolu.TabIndex = 7;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(393, 140);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(105, 66);
            this.Ekle.TabIndex = 8;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // releseTime
            // 
            this.releseTime.Location = new System.Drawing.Point(142, 127);
            this.releseTime.Name = "releseTime";
            this.releseTime.Size = new System.Drawing.Size(200, 22);
            this.releseTime.TabIndex = 9;
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 412);
            this.Controls.Add(this.releseTime);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.PosterYolu);
            this.Controls.Add(this.Tur);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tex);
            this.Name = "FilmEkle";
            this.Text = "FilmEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Tur;
        private System.Windows.Forms.TextBox PosterYolu;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.DateTimePicker releseTime;
    }
}