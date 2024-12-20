namespace BARINAKSISTEMI
{
    partial class BakimAsiIslemleriForm
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
            txtHayvanID = new TextBox();
            txtAsiTuru = new TextBox();
            dateTimePickerAsiTarihi = new DateTimePicker();
            btnAsiEkle = new Button();
            txtBakimDetayi = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimePickerBakimTarihi = new DateTimePicker();
            btnBakimEkle = new Button();
            btnAsiListesi = new Button();
            btnBakimListesi = new Button();
            btnGeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtHayvanID
            // 
            txtHayvanID.BackColor = Color.FromArgb(192, 255, 192);
            txtHayvanID.Location = new Point(538, 234);
            txtHayvanID.Name = "txtHayvanID";
            txtHayvanID.Size = new Size(125, 27);
            txtHayvanID.TabIndex = 0;
            txtHayvanID.Text = "Hayvan ID";
            // 
            // txtAsiTuru
            // 
            txtAsiTuru.BackColor = Color.FromArgb(192, 255, 192);
            txtAsiTuru.Location = new Point(538, 286);
            txtAsiTuru.Name = "txtAsiTuru";
            txtAsiTuru.Size = new Size(125, 27);
            txtAsiTuru.TabIndex = 1;
            txtAsiTuru.Text = "Aşı Türü";
            // 
            // dateTimePickerAsiTarihi
            // 
            dateTimePickerAsiTarihi.Location = new Point(538, 343);
            dateTimePickerAsiTarihi.Name = "dateTimePickerAsiTarihi";
            dateTimePickerAsiTarihi.Size = new Size(250, 27);
            dateTimePickerAsiTarihi.TabIndex = 2;
            // 
            // btnAsiEkle
            // 
            btnAsiEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnAsiEkle.Location = new Point(538, 400);
            btnAsiEkle.Name = "btnAsiEkle";
            btnAsiEkle.Size = new Size(94, 29);
            btnAsiEkle.TabIndex = 3;
            btnAsiEkle.Text = "Aşı Ekle";
            btnAsiEkle.UseVisualStyleBackColor = false;
            btnAsiEkle.Click += btnAsiEkle_Click;
            // 
            // txtBakimDetayi
            // 
            txtBakimDetayi.ForeColor = Color.DarkMagenta;
            txtBakimDetayi.Location = new Point(12, 251);
            txtBakimDetayi.Name = "txtBakimDetayi";
            txtBakimDetayi.Size = new Size(125, 27);
            txtBakimDetayi.TabIndex = 4;
            txtBakimDetayi.Text = "Bakım Detayı";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(166, -6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 5;
            // 
            // dateTimePickerBakimTarihi
            // 
            dateTimePickerBakimTarihi.Location = new Point(12, 307);
            dateTimePickerBakimTarihi.Name = "dateTimePickerBakimTarihi";
            dateTimePickerBakimTarihi.Size = new Size(250, 27);
            dateTimePickerBakimTarihi.TabIndex = 6;
            // 
            // btnBakimEkle
            // 
            btnBakimEkle.ForeColor = Color.DarkMagenta;
            btnBakimEkle.Location = new Point(12, 359);
            btnBakimEkle.Name = "btnBakimEkle";
            btnBakimEkle.Size = new Size(94, 29);
            btnBakimEkle.TabIndex = 7;
            btnBakimEkle.Text = "Bakım Ekle";
            btnBakimEkle.UseVisualStyleBackColor = true;
            btnBakimEkle.Click += btnBakimEkle_Click;
            // 
            // btnAsiListesi
            // 
            btnAsiListesi.Location = new Point(528, 42);
            btnAsiListesi.Name = "btnAsiListesi";
            btnAsiListesi.Size = new Size(129, 29);
            btnAsiListesi.TabIndex = 8;
            btnAsiListesi.Text = "Aşı Listesi";
            btnAsiListesi.UseVisualStyleBackColor = true;
            btnAsiListesi.Click += btnAsiListesi_Click;
            // 
            // btnBakimListesi
            // 
            btnBakimListesi.Location = new Point(528, 77);
            btnBakimListesi.Name = "btnBakimListesi";
            btnBakimListesi.Size = new Size(129, 29);
            btnBakimListesi.TabIndex = 9;
            btnBakimListesi.Text = "Bakım Listesi";
            btnBakimListesi.UseVisualStyleBackColor = true;
            btnBakimListesi.Click += btnBakimListesi_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(12, 12);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(94, 69);
            btnGeriDon.TabIndex = 12;
            btnGeriDon.Text = "Ana Menüye Dön";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // BakimAsiIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGeriDon);
            Controls.Add(btnBakimListesi);
            Controls.Add(btnAsiListesi);
            Controls.Add(btnBakimEkle);
            Controls.Add(dateTimePickerBakimTarihi);
            Controls.Add(dataGridView1);
            Controls.Add(txtBakimDetayi);
            Controls.Add(btnAsiEkle);
            Controls.Add(dateTimePickerAsiTarihi);
            Controls.Add(txtAsiTuru);
            Controls.Add(txtHayvanID);
            Name = "BakimAsiIslemleriForm";
            Text = "BakimAsiIslemleriForm";
            Load += BakimAsiIslemleriForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHayvanID;
        private TextBox txtAsiTuru;
        private DateTimePicker dateTimePickerAsiTarihi;
        private Button btnAsiEkle;
        private TextBox txtBakimDetayi;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerBakimTarihi;
        private Button btnBakimEkle;
        private Button btnAsiListesi;
        private Button btnBakimListesi;
        private Button btnGeriDon;
    }
}