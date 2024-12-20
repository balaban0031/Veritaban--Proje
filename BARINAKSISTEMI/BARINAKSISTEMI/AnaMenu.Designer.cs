namespace BARINAKSISTEMI
{
    partial class AnaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnHayvanIslemleri = new Button();
            btnKullaniciIslemleri = new Button();
            btnSahiplenmeIslemleri = new Button();
            btnBakimAsiIslemleri = new Button();
            btnCikis = new Button();
            btnBarinakİslemleri = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 35);
            label1.TabIndex = 0;
            label1.Text = "Barınak Sistemi Ana Menü";
            // 
            // btnHayvanIslemleri
            // 
            btnHayvanIslemleri.Location = new Point(269, 111);
            btnHayvanIslemleri.Name = "btnHayvanIslemleri";
            btnHayvanIslemleri.Size = new Size(159, 29);
            btnHayvanIslemleri.TabIndex = 1;
            btnHayvanIslemleri.Text = "Hayvan İşlemleri";
            btnHayvanIslemleri.UseVisualStyleBackColor = true;
            btnHayvanIslemleri.Click += btnHayvanIslemleri_Click;
            // 
            // btnKullaniciIslemleri
            // 
            btnKullaniciIslemleri.Location = new Point(269, 194);
            btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            btnKullaniciIslemleri.Size = new Size(159, 29);
            btnKullaniciIslemleri.TabIndex = 2;
            btnKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            btnKullaniciIslemleri.UseVisualStyleBackColor = true;
            btnKullaniciIslemleri.Click += btnKullaniciIslemleri_Click;
            // 
            // btnSahiplenmeIslemleri
            // 
            btnSahiplenmeIslemleri.Location = new Point(269, 268);
            btnSahiplenmeIslemleri.Name = "btnSahiplenmeIslemleri";
            btnSahiplenmeIslemleri.Size = new Size(159, 29);
            btnSahiplenmeIslemleri.TabIndex = 3;
            btnSahiplenmeIslemleri.Text = "Sahiplenme İşlemleri";
            btnSahiplenmeIslemleri.UseVisualStyleBackColor = true;
            btnSahiplenmeIslemleri.Click += btnSahiplenmeIslemleri_Click;
            // 
            // btnBakimAsiIslemleri
            // 
            btnBakimAsiIslemleri.Location = new Point(269, 319);
            btnBakimAsiIslemleri.Name = "btnBakimAsiIslemleri";
            btnBakimAsiIslemleri.Size = new Size(159, 48);
            btnBakimAsiIslemleri.TabIndex = 4;
            btnBakimAsiIslemleri.Text = "Bakım ve Aşı İşlemleri";
            btnBakimAsiIslemleri.UseVisualStyleBackColor = true;
            btnBakimAsiIslemleri.Click += btnBakimAsiIslemleri_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(269, 460);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(159, 29);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnBarinakİslemleri
            // 
            btnBarinakİslemleri.Location = new Point(269, 387);
            btnBarinakİslemleri.Name = "btnBarinakİslemleri";
            btnBarinakİslemleri.Size = new Size(159, 48);
            btnBarinakİslemleri.TabIndex = 6;
            btnBarinakİslemleri.Text = "Barınak İşlemleri";
            btnBarinakİslemleri.UseVisualStyleBackColor = true;
            btnBarinakİslemleri.Click += btnBarinakİslemleri_Click;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 519);
            Controls.Add(btnBarinakİslemleri);
            Controls.Add(btnCikis);
            Controls.Add(btnBakimAsiIslemleri);
            Controls.Add(btnSahiplenmeIslemleri);
            Controls.Add(btnKullaniciIslemleri);
            Controls.Add(btnHayvanIslemleri);
            Controls.Add(label1);
            Name = "AnaMenu";
            Text = "Ana Menü";
            Load += AnaMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHayvanIslemleri;
        private Button btnKullaniciIslemleri;
        private Button btnSahiplenmeIslemleri;
        private Button btnBakimAsiIslemleri;
        private Button btnCikis;
        private Button btnBarinakİslemleri;
    }
}
