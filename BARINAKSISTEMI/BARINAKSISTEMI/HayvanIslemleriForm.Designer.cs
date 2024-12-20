namespace BARINAKSISTEMI
{
    partial class HayvanIslemleriForm
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
            btnEkle = new Button();
            label1 = new Label();
            txtIsim = new TextBox();
            txtCins = new TextBox();
            txtYas = new TextBox();
            txtDetay = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            btnGeriDon = new Button();
            cmbTur = new ComboBox();
            cmbDurum = new ComboBox();
            dataGridView1 = new DataGridView();
            btnArama = new Button();
            txtHayvanId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(87, 366);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(105, 38);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(448, 11);
            label1.Name = "label1";
            label1.Size = new Size(210, 35);
            label1.TabIndex = 1;
            label1.Text = "Hayvan İşlemleri";
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(826, 332);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(125, 27);
            txtIsim.TabIndex = 2;
            txtIsim.Text = "Hayvan İsmi";
            // 
            // txtCins
            // 
            txtCins.Location = new Point(826, 398);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(125, 27);
            txtCins.TabIndex = 4;
            txtCins.Text = "Cins";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(826, 431);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(125, 27);
            txtYas.TabIndex = 5;
            txtYas.Text = "Yaş";
            // 
            // txtDetay
            // 
            txtDetay.Location = new Point(823, 497);
            txtDetay.Name = "txtDetay";
            txtDetay.Size = new Size(128, 27);
            txtDetay.TabIndex = 7;
            txtDetay.Text = "Tür Detayları";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(87, 445);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(105, 29);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(87, 480);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(105, 29);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(87, 410);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(105, 29);
            btnListele.TabIndex = 10;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(12, 11);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(94, 69);
            btnGeriDon.TabIndex = 11;
            btnGeriDon.Text = "Ana Menüye Dön";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Items.AddRange(new object[] { "Kedi", "Kopek", "Kus" });
            cmbTur.Location = new Point(826, 366);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(125, 28);
            cmbTur.TabIndex = 12;
            cmbTur.Text = "Tür";
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Sahiplendi", "Sahiplenebilir", "Tedavi Ediliyor" });
            cmbDurum.Location = new Point(823, 464);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(128, 28);
            cmbDurum.TabIndex = 13;
            cmbDurum.Text = "Durum";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(957, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnArama
            // 
            btnArama.Location = new Point(267, 392);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(105, 38);
            btnArama.TabIndex = 15;
            btnArama.Text = "Hayvan Ara";
            btnArama.UseVisualStyleBackColor = true;
            btnArama.Click += btnArama_Click;
            // 
            // txtHayvanId
            // 
            txtHayvanId.Location = new Point(267, 366);
            txtHayvanId.Name = "txtHayvanId";
            txtHayvanId.Size = new Size(125, 27);
            txtHayvanId.TabIndex = 16;
            txtHayvanId.Text = "HayvanID";
            // 
            // HayvanIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 702);
            Controls.Add(txtHayvanId);
            Controls.Add(btnArama);
            Controls.Add(dataGridView1);
            Controls.Add(cmbDurum);
            Controls.Add(cmbTur);
            Controls.Add(btnGeriDon);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtDetay);
            Controls.Add(txtYas);
            Controls.Add(txtCins);
            Controls.Add(txtIsim);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Name = "HayvanIslemleriForm";
            Text = "HayvanIslemleriForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Label label1;
        private TextBox txtIsim;
        private TextBox txtCins;
        private TextBox txtYas;
        private TextBox txtDetay;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private Button btnGeriDon;
        private ComboBox cmbTur;
        private ComboBox cmbDurum;
        private DataGridView dataGridView1;
        private Button btnArama;
        private TextBox txtHayvanId;
    }
}