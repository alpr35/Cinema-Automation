namespace NewProject
{
    partial class FlmGuncll
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
            this.Güncelle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FlmAd = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.Gnclle = new System.Windows.Forms.Button();
            this.releseTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.PosterAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncellemek İstediğiniz\r\nFilmi Seçiniz";
            // 
            // Güncelle
            // 
            this.Güncelle.FormattingEnabled = true;
            this.Güncelle.Location = new System.Drawing.Point(204, 82);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(121, 24);
            this.Güncelle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film\'in Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Türü";
            // 
            // FlmAd
            // 
            this.FlmAd.Location = new System.Drawing.Point(138, 158);
            this.FlmAd.Name = "FlmAd";
            this.FlmAd.Size = new System.Drawing.Size(100, 22);
            this.FlmAd.TabIndex = 5;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(138, 257);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 22);
            this.type.TabIndex = 7;
            // 
            // Gnclle
            // 
            this.Gnclle.Location = new System.Drawing.Point(415, 206);
            this.Gnclle.Name = "Gnclle";
            this.Gnclle.Size = new System.Drawing.Size(86, 68);
            this.Gnclle.TabIndex = 8;
            this.Gnclle.Text = "Güncelle";
            this.Gnclle.UseVisualStyleBackColor = true;
            this.Gnclle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // releseTimeBox
            // 
            this.releseTimeBox.Location = new System.Drawing.Point(138, 206);
            this.releseTimeBox.Name = "releseTimeBox";
            this.releseTimeBox.Size = new System.Drawing.Size(200, 22);
            this.releseTimeBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Poster Adresi";
            // 
            // PosterAddress
            // 
            this.PosterAddress.Location = new System.Drawing.Point(149, 306);
            this.PosterAddress.Name = "PosterAddress";
            this.PosterAddress.Size = new System.Drawing.Size(100, 22);
            this.PosterAddress.TabIndex = 11;
            // 
            // FlmGuncll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 441);
            this.Controls.Add(this.PosterAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.releseTimeBox);
            this.Controls.Add(this.Gnclle);
            this.Controls.Add(this.type);
            this.Controls.Add(this.FlmAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.label1);
            this.Name = "FlmGuncll";
            this.Text = "FlmGuncll";
            this.Load += new System.EventHandler(this.FlmGuncll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Güncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FlmAd;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Button Gnclle;
        private System.Windows.Forms.DateTimePicker releseTimeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PosterAddress;
    }
}