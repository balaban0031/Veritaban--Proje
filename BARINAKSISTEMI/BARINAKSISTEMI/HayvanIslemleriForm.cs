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
    public partial class HayvanIslemleriForm : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=admin123;Database=BARINAK";
        public HayvanIslemleriForm()
        {
            InitializeComponent();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "CALL Yeni_Hayvan_Ekle(@Isim, @Tur, @Cins, @Yas, @Durum, @TurDetay)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("Isim", txtIsim.Text);
                    cmd.Parameters.AddWithValue("Tur", cmbTur.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("Cins", txtCins.Text);
                    cmd.Parameters.AddWithValue("Yas", int.TryParse(txtYas.Text, out int yas) ? yas : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("Durum", cmbDurum.SelectedItem?.ToString() ?? "");

                    // Tür Bazlı Detay Kontrolü
                    string tur = cmbTur.SelectedItem?.ToString();
                    if (tur == "Kopek")
                    {
                        if (txtDetay.Text == "Kucuk" || txtDetay.Text == "Orta" || txtDetay.Text == "Buyuk")
                        {
                            cmd.Parameters.AddWithValue("TurDetay", txtDetay.Text);
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Boyut için 'Kucuk', 'Orta' veya 'Buyuk' değerlerinden birini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else if (tur == "Kedi")
                    {
                        cmd.Parameters.AddWithValue("TurDetay", txtDetay.Text); // Kedi için Tüy Rengi
                    }
                    else if (tur == "Kus")
                    {
                        if (int.TryParse(txtDetay.Text, out int kanatUzunlugu))
                        {
                            cmd.Parameters.AddWithValue("TurDetay", kanatUzunlugu.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Kanat Uzunluğu için geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Tür seçimini doğru yapın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Komutu Çalıştır
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Hayvan başarıyla eklendi.");
            LoadHayvanListesi(); // DatagridView'i yenile


        }
        private void LoadHayvanListesi()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM Tum_Hayvanlar";
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


        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadHayvanListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırdan ID al
                int hayvanID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Hayvan_ID"].Value);

                // ComboBox değerlerini kontrol et
                if (cmbTur.SelectedItem == null || cmbDurum.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "CALL Hayvan_Guncelle(@HayvanID, @Isim, @Tur, @Cins, @Yas, @Durum)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("HayvanID", hayvanID);
                        cmd.Parameters.AddWithValue("Isim", txtIsim.Text);
                        cmd.Parameters.AddWithValue("Tur", cmbTur.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("Cins", txtCins.Text);
                        cmd.Parameters.AddWithValue("Yas", int.TryParse(txtYas.Text, out int yas) ? yas : 0); // Boşsa 0 atanır
                        cmd.Parameters.AddWithValue("Durum", cmbDurum.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hayvan bilgileri başarıyla güncellendi.");
                LoadHayvanListesi(); // Listeyi yenile
            }
            else
            {
                MessageBox.Show("Lütfen bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int hayvanID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Hayvan_ID"].Value);
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "CALL Hayvan_Sil(@HayvanID)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("HayvanID", hayvanID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Hayvan başarıyla silindi.");
                LoadHayvanListesi();
            }
            else
            {
                MessageBox.Show("Lütfen bir hayvan seçin.");
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'de bir satır seçili mi kontrol et
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Seçilen satırı al
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Hücre değerlerini TextBox ve ComboBox'lara doldur
                    txtIsim.Text = selectedRow.Cells["Isim"].Value?.ToString(); // Hayvan İsmi
                    cmbTur.SelectedItem = selectedRow.Cells["Tur"].Value?.ToString(); // Tür (Kedi, Köpek, Kuş)
                    txtCins.Text = selectedRow.Cells["Cins"].Value?.ToString(); // Cins
                    txtYas.Text = selectedRow.Cells["Yas"].Value?.ToString(); // Yaş
                    cmbDurum.SelectedItem = selectedRow.Cells["Durum"].Value?.ToString(); // Durum (Sahiplenebilir vb.)
                    txtDetay.Text = selectedRow.Cells["Detay"].Value?.ToString(); // Tür Detayları (Tüy Rengi, Boyut vb.)
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtHayvanId.Text, out int hayvanID))
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Hayvan_Arama(@HayvanID)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("HayvanID", hayvanID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Aranan ID'ye sahip hayvan bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

            }
        }
    }
}
