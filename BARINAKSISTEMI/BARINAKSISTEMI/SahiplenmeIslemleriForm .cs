using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BARINAKSISTEMI
{
    public partial class SahiplendirmeForm : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=admin123;Database=BARINAK";

        public SahiplendirmeForm()
        {
            InitializeComponent();
        }

        private void btnBasvuruEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtHayvanId.Text) || !int.TryParse(txtHayvanId.Text, out int hayvanId))
                {
                    MessageBox.Show("Lütfen geçerli bir Hayvan ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtKullaniciId.Text) || !int.TryParse(txtKullaniciId.Text, out int kullaniciId))
                {
                    MessageBox.Show("Lütfen geçerli bir Kullanıcı ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                DateTime basvuruTarihi = dateTimePickerBasvuruTarihi.Value;

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "CALL Sahiplendirme_Basvurusu_Ekle(@HayvanID, @KullaniciID, @BasvuruTarihi)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HayvanID", hayvanId);
                        cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                        cmd.Parameters.AddWithValue("@BasvuruTarihi", basvuruTarihi.ToString("yyyy-MM-dd"));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sahiplenme başvurusu başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi güncelle
                BasvuruListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BasvuruListele()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM Basvuru_Listesi()";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçilen satırı kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Seçilen satırdan gerekli bilgileri al
                    int sahiplenmeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Sahiplenme_ID"].Value);
                    string yeniDurum = comboBoxDurum.SelectedItem.ToString();

                    // SQL bağlantısı ve işlem
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();

                        // SQL fonksiyonunu çağır
                        string query = "UPDATE Sahiplenme SET Durum = @Durum WHERE Sahiplenme_ID = @SahiplenmeID";

                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            // Parametreleri ekle
                            cmd.Parameters.AddWithValue("@Durum", yeniDurum);
                            cmd.Parameters.AddWithValue("@SahiplenmeID", sahiplenmeId);

                            // Sorguyu çalıştır
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Durum başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Güncellenen listeyi tekrar yükle
                    BasvuruListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir başvuru seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            BasvuruListele();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
