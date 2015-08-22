namespace NewProject
{
    partial class SalonEkle
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
            this.label3 = new System.Windows.Forms.Label();
            this.Adı = new System.Windows.Forms.TextBox();
            this.Row = new System.Windows.Forms.TextBox();
            this.Column = new System.Windows.Forms.TextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satır";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sutun";
            // 
            // Adı
            // 
            this.Adı.Location = new System.Drawing.Point(90, 87);
            this.Adı.Name = "Adı";
            this.Adı.Size = new System.Drawing.Size(100, 22);
            this.Adı.TabIndex = 3;
            // 
            // Row
            // 
            this.Row.Location = new System.Drawing.Point(90, 163);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(100, 22);
            this.Row.TabIndex = 4;
            // 
            // Column
            // 
            this.Column.Location = new System.Drawing.Point(90, 244);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(100, 22);
            this.Column.TabIndex = 5;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(283, 127);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(131, 94);
            this.Ekle.TabIndex = 6;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // SalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 407);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Column);
            this.Controls.Add(this.Row);
            this.Controls.Add(this.Adı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalonEkle";
            this.Text = "SalonEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adı;
        private System.Windows.Forms.TextBox Row;
        private System.Windows.Forms.TextBox Column;
        private System.Windows.Forms.Button Ekle;
    }
}