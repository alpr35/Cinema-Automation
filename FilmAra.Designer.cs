namespace NewProject
{
    partial class FilmAra
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Arama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.tblSaloonTableAdapter = new NewProject.SinemaDataSet1TableAdapters.tblSaloonTableAdapter();
            this.Ara = new System.Windows.Forms.Button();
            this.sinemaDataSet2 = new NewProject.SinemaDataSet2();
            this.tblMovieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMovieTableAdapter = new NewProject.SinemaDataSet2TableAdapters.tblMovieTableAdapter();
            this.movieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSaloonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMovieBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMovieBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaloonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // Arama
            // 
            this.Arama.Location = new System.Drawing.Point(190, 60);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(100, 22);
            this.Arama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ara";
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.releseDateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewFilm.DataSource = this.tblMovieBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFilm.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFilm.Location = new System.Drawing.Point(30, 149);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilm.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFilm.RowTemplate.Height = 24;
            this.dataGridViewFilm.Size = new System.Drawing.Size(546, 232);
            this.dataGridViewFilm.TabIndex = 2;
            this.dataGridViewFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilm_CellContentClick);
            // 
            // tblSaloonTableAdapter
            // 
            this.tblSaloonTableAdapter.ClearBeforeFill = true;
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(346, 55);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(82, 32);
            this.Ara.TabIndex = 3;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // sinemaDataSet2
            // 
            this.sinemaDataSet2.DataSetName = "SinemaDataSet2";
            this.sinemaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMovieBindingSource
            // 
            this.tblMovieBindingSource.DataMember = "tblMovie";
            this.tblMovieBindingSource.DataSource = this.sinemaDataSet2;
            // 
            // tblMovieTableAdapter
            // 
            this.tblMovieTableAdapter.ClearBeforeFill = true;
            // 
            // movieIdDataGridViewTextBoxColumn
            // 
            this.movieIdDataGridViewTextBoxColumn.DataPropertyName = "movieId";
            this.movieIdDataGridViewTextBoxColumn.HeaderText = "movieId";
            this.movieIdDataGridViewTextBoxColumn.Name = "movieIdDataGridViewTextBoxColumn";
            this.movieIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // releseDateDataGridViewTextBoxColumn
            // 
            this.releseDateDataGridViewTextBoxColumn.DataPropertyName = "releseDate";
            this.releseDateDataGridViewTextBoxColumn.HeaderText = "releseDate";
            this.releseDateDataGridViewTextBoxColumn.Name = "releseDateDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // FilmAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 461);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Arama);
            this.Name = "FilmAra";
            this.Text = "FilmAra";
            this.Load += new System.EventHandler(this.FilmAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaloonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Arama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.BindingSource tblSaloonBindingSource;
        private SinemaDataSet1TableAdapters.tblSaloonTableAdapter tblSaloonTableAdapter;
        private System.Windows.Forms.BindingSource tblMovieBindingSource4;
        private System.Windows.Forms.BindingSource tblMovieBindingSource3;
        private System.Windows.Forms.BindingSource sinemaDataSet1BindingSource;
        private System.Windows.Forms.Button Ara;
        private SinemaDataSet2 sinemaDataSet2;
        private System.Windows.Forms.BindingSource tblMovieBindingSource;
        private SinemaDataSet2TableAdapters.tblMovieTableAdapter tblMovieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}