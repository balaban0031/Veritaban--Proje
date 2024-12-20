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
    public partial class KullaniciIslemleriForm : Form
    {
        string connString = "Host=localhost;Username=postgres;Password=admin123;Database=BARINAK";
        public KullaniciIslemleriForm()
        {
            InitializeComponent();
        }
        private void LoadKullaniciListesi()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM Kullanici";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string email = txtEposta.Text.Trim();

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO Kullanici (Ad, Soyad, Telefon, Eposta) VALUES (@Ad, @Soyad, @Telefon, @Eposta)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@Telefon", telefon);
                        cmd.Parameters.AddWithValue("@Eposta", email);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKullaniciListesi(); // Listeyi güncellemek için
            }
            catch (Npgsql.PostgresException ex)
            {
                // Hata SQL tarafından tetiklendiyse yakala ve kullanıcıya bildir
                if (ex.SqlState == "23514") // Constraint violation hatası
                {
                    MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int kullaniciId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Kullanici_ID"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE Kullanici SET Ad=@Ad, Soyad=@Soyad, Telefon=@Telefon, Eposta=@Eposta WHERE Kullanici_ID=@KullaniciID";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("Soyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("Telefon", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("Eposta", txtEposta.Text);
                        cmd.Parameters.AddWithValue("KullaniciID", kullaniciId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                LoadKullaniciListesi();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int kullaniciId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Kullanici_ID"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM Kullanici WHERE Kullanici_ID=@KullaniciID";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("KullaniciID", kullaniciId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kullanıcı başarıyla silindi.");
                LoadKullaniciListesi();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEposta.Text = row.Cells["Eposta"].Value.ToString();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadKullaniciListesi();
        }
    }
}
