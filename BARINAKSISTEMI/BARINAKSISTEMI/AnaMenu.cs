namespace BARINAKSISTEMI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnHayvanIslemleri_Click(object sender, EventArgs e)
        {
            // Hayvan İşlemleri formunu aç
            HayvanIslemleriForm hayvanForm = new HayvanIslemleriForm();
            this.Hide(); // Ana menüyü gizle
            hayvanForm.ShowDialog();
            this.Show(); // Alt form kapandığında ana menüyü geri getir
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            KullaniciIslemleriForm kullaniciForm = new KullaniciIslemleriForm();
            this.Hide();
            kullaniciForm.ShowDialog();
            this.Show();
        }

        private void btnSahiplenmeIslemleri_Click(object sender, EventArgs e)
        {
            SahiplendirmeForm sahiplenmeForm = new SahiplendirmeForm();
            this.Hide();
            sahiplenmeForm.ShowDialog();
            this.Show();

        }

        private void btnBakimAsiIslemleri_Click(object sender, EventArgs e)
        {
            BakimAsiIslemleriForm bakimAsiForm = new BakimAsiIslemleriForm();
            this.Hide();
            bakimAsiForm.ShowDialog();
            this.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBarinakİslemleri_Click(object sender, EventArgs e)
        {
            BarinakIslemleriForm barinakForm = new BarinakIslemleriForm();
            this.Hide();
            barinakForm.ShowDialog();
            this.Show();
        }
    }
}
