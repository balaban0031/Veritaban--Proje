namespace BARINAKSISTEMI
{
    partial class SahiplendirmeForm
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
            btnListele = new Button();
            dataGridView1 = new DataGridView();
            btnAnaMenu = new Button();
            btnDurumGuncelle = new Button();
            btnBasvuruEkle = new Button();
            label1 = new Label();
            txtHayvanId = new TextBox();
            txtKullaniciId = new TextBox();
            dateTimePickerBasvuruTarihi = new DateTimePicker();
            comboBoxDurum = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnListele
            // 
            btnListele.Location = new Point(336, 435);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(129, 49);
            btnListele.TabIndex = 21;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(253, 115);
            dataGridView1.TabIndex = 20;
            // 
            // btnAnaMenu
            // 
            btnAnaMenu.Location = new Point(12, 14);
            btnAnaMenu.Name = "btnAnaMenu";
            btnAnaMenu.Size = new Size(94, 88);
            btnAnaMenu.TabIndex = 19;
            btnAnaMenu.Text = "Ana Menüye Dön";
            btnAnaMenu.UseVisualStyleBackColor = true;
            btnAnaMenu.Click += btnAnaMenu_Click;
            // 
            // btnDurumGuncelle
            // 
            btnDurumGuncelle.Location = new Point(577, 240);
            btnDurumGuncelle.Name = "btnDurumGuncelle";
            btnDurumGuncelle.Size = new Size(220, 45);
            btnDurumGuncelle.TabIndex = 17;
            btnDurumGuncelle.Text = "Başvuru Durumu Güncelle";
            btnDurumGuncelle.UseVisualStyleBackColor = true;
            btnDurumGuncelle.Click += btnDurumGuncelle_Click;
            // 
            // btnBasvuruEkle
            // 
            btnBasvuruEkle.Location = new Point(64, 240);
            btnBasvuruEkle.Name = "btnBasvuruEkle";
            btnBasvuruEkle.Size = new Size(166, 29);
            btnBasvuruEkle.TabIndex = 16;
            btnBasvuruEkle.Text = "Başvuru Ekle";
            btnBasvuruEkle.UseVisualStyleBackColor = true;
            btnBasvuruEkle.Click += btnBasvuruEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 23);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 11;
            label1.Text = "Sahiplendirme İşlemi";
            // 
            // txtHayvanId
            // 
            txtHayvanId.Location = new Point(64, 275);
            txtHayvanId.Name = "txtHayvanId";
            txtHayvanId.Size = new Size(125, 27);
            txtHayvanId.TabIndex = 22;
            txtHayvanId.Text = "Hayvan ID";
            // 
            // txtKullaniciId
            // 
            txtKullaniciId.Location = new Point(64, 308);
            txtKullaniciId.Name = "txtKullaniciId";
            txtKullaniciId.Size = new Size(125, 27);
            txtKullaniciId.TabIndex = 23;
            txtKullaniciId.Text = "Kullanıcı ID";
            // 
            // dateTimePickerBasvuruTarihi
            // 
            dateTimePickerBasvuruTarihi.Location = new Point(64, 350);
            dateTimePickerBasvuruTarihi.Name = "dateTimePickerBasvuruTarihi";
            dateTimePickerBasvuruTarihi.Size = new Size(250, 27);
            dateTimePickerBasvuruTarihi.TabIndex = 24;
            // 
            // comboBoxDurum
            // 
            comboBoxDurum.FormattingEnabled = true;
            comboBoxDurum.Items.AddRange(new object[] { "Kabul Edildi", "Beklemede", "Reddedildi" });
            comboBoxDurum.Location = new Point(577, 296);
            comboBoxDurum.Name = "comboBoxDurum";
            comboBoxDurum.Size = new Size(220, 28);
            comboBoxDurum.TabIndex = 25;
            comboBoxDurum.Text = "comboBoxDurum";
            // 
            // SahiplendirmeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 616);
            Controls.Add(comboBoxDurum);
            Controls.Add(dateTimePickerBasvuruTarihi);
            Controls.Add(txtKullaniciId);
            Controls.Add(txtHayvanId);
            Controls.Add(btnListele);
            Controls.Add(dataGridView1);
            Controls.Add(btnAnaMenu);
            Controls.Add(btnDurumGuncelle);
            Controls.Add(btnBasvuruEkle);
            Controls.Add(label1);
            Name = "SahiplendirmeForm";
            Text = "Sahiplenme İşlemleri Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListele;
        private DataGridView dataGridView1;
        private Button btnAnaMenu;
        private Button btnDurumGuncelle;
        private Button btnBasvuruEkle;
        private Label label1;
        private TextBox txtHayvanId;
        private TextBox txtKullaniciId;
        private DateTimePicker dateTimePickerBasvuruTarihi;
        private ComboBox comboBoxDurum;
    }
}