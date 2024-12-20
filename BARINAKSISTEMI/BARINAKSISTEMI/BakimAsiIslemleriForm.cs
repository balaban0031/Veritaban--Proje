using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace BARINAKSISTEMI
{
    public partial class BakimAsiIslemleriForm : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=admin123;Database=BARINAK";

        public BakimAsiIslemleriForm()
        {
            InitializeComponent();
        }

        private void btnAsiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtHayvanID.Text) || string.IsNullOrWhiteSpace(txtAsiTuru.Text))
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int hayvanId = Convert.ToInt32(txtHayvanID.Text); // Get Hayvan ID
                string asiTuru = txtAsiTuru.Text; // Get Vaccination Type
                DateTime asiTarihi = dateTimePickerAsiTarihi.Value; // Get Vaccination Date

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open(); // Open the database connection

                    // Insert vaccination data into the database
                    using (var cmd = new NpgsqlCommand("CALL Asi_Ekle(@p_hayvan_id, @p_asi_turu, @p_asi_tarihi)", conn))
                    {
                        cmd.Parameters.AddWithValue("p_hayvan_id", hayvanId);
                        cmd.Parameters.AddWithValue("p_asi_turu", asiTuru);
                        cmd.Parameters.AddWithValue("p_asi_tarihi", asiTarihi);

                        cmd.ExecuteNonQuery(); // Execute the stored procedure
                        MessageBox.Show("Aşı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBakimEkle_Click(object sender, EventArgs e)
        {
            ToggleVisibility(true, false, false); // Sadece bakım bileşenleri görünür

            try
            {
                int hayvanID = Convert.ToInt32(txtHayvanID.Text);
                string bakimDetayi = txtBakimDetayi.Text;
                DateTime bakimTarihi = dateTimePickerBakimTarihi.Value;

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("CALL public.bakim_ekle(@p_hayvan_id, @p_bakim_tarihi, @p_bakim_detayi)", conn))
                    {
                        cmd.Parameters.AddWithValue("p_hayvan_id", hayvanID);
                        cmd.Parameters.AddWithValue("p_bakim_tarihi", bakimTarihi);
                        cmd.Parameters.AddWithValue("p_bakim_detayi", bakimDetayi);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bakım kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsiListesi_Click(object sender, EventArgs e)
        {
            try
            {
                int hayvanID = Convert.ToInt32(txtHayvanID.Text);
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM public.asi_listesi(@p_hayvan_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("p_hayvan_id", hayvanID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBakimListesi_Click(object sender, EventArgs e)
        {
            try
            {
                int hayvanID = Convert.ToInt32(txtHayvanID.Text);
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM public.bakim_listesi(@p_hayvan_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("p_hayvan_id", hayvanID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ToggleVisibility(bool isBakimVisible, bool isAsiVisible, bool isListVisible)
        {
            txtBakimDetayi.Visible = isBakimVisible;
            dateTimePickerBakimTarihi.Visible = isBakimVisible;
            btnBakimEkle.Visible = isBakimVisible;

            txtAsiTuru.Visible = isAsiVisible;
            dateTimePickerAsiTarihi.Visible = isAsiVisible;
            btnAsiEkle.Visible = isAsiVisible;

            dataGridView1.Visible = isListVisible;
            btnAsiListesi.Visible = isListVisible;
            btnBakimListesi.Visible = isListVisible;
            btnGeriDon.Visible = isListVisible;

            txtHayvanID.Visible = true; // Hayvan ID her işlemde kullanılabilir.
        }

        private void BakimAsiIslemleriForm_Load(object sender, EventArgs e)
        {
            txtHayvanID.Visible = true;
            dataGridView1.Visible = true;

            txtAsiTuru.Visible = false;
            dateTimePickerAsiTarihi.Visible = false;

            txtBakimDetayi.Visible = false;
            dateTimePickerBakimTarihi.Visible = false;
        }
    }
}
