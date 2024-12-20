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
    public partial class BarinakIslemleriForm : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=admin123;Database=BARINAK";
        public BarinakIslemleriForm()
        {
            InitializeComponent();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("CALL Personel_Ekle(@p_ad, @p_soyad, @p_telefon, @p_gorev_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("p_ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("p_soyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("p_telefon", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("p_gorev_id", string.IsNullOrWhiteSpace(txtGorevID.Text) ? DBNull.Value : Convert.ToInt32(txtGorevID.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO Oda (Bina_ID, Oda_Adi) VALUES (@p_bina_id, @p_oda_adi)", conn))
                    {
                        cmd.Parameters.AddWithValue("p_bina_id", Convert.ToInt32(txtBarinakID.Text));
                        cmd.Parameters.AddWithValue("p_oda_adi", txtOdaAdi.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Oda başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {

            try
            {
                // Görev Adı ve Açıklama alanlarını kontrol et
                if (string.IsNullOrWhiteSpace(txtGorevAdi.Text))
                {
                    MessageBox.Show("Lütfen Görev Adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gorevAdi = txtGorevAdi.Text;
                string aciklama = txtAciklama.Text;

                // Veritabanı bağlantısı ve ekleme işlemi
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO Gorev (Gorev_Adi, Aciklama) VALUES (@gorev_adi, @aciklama)", conn))
                    {
                        cmd.Parameters.AddWithValue("gorev_adi", gorevAdi);
                        cmd.Parameters.AddWithValue("aciklama", string.IsNullOrWhiteSpace(aciklama) ? DBNull.Value : aciklama);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Görev başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
