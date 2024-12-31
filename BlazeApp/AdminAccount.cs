using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaze
{
    public partial class AdminAccount : Form
    {
        public AdminAccount()
        {
            InitializeComponent();
            try
            {
                string query = "SELECT * FROM Users";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {

            }

        }
        int uID;
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = Blaze;" +
        " user ID = postgres; password = 123");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                object selecteduID = row.Cells["uID"].Value;
                uID = Convert.ToInt32(selecteduID);

                usrnameTextBox.Text = row.Cells["uName"].Value?.ToString() ?? string.Empty;
                mailtextBox.Text = row.Cells["uEmail"].Value?.ToString()?? string.Empty ;
                passwordtextBox.Text = row.Cells["uPassword"].Value?.ToString()??string.Empty;
            }
        }

        private void usrnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateUserInfo(string columnName, string newValue)
        {
            string query = $"UPDATE Users SET {columnName} = @newValue WHERE uID = @uID";

            using (var command = new NpgsqlCommand(query, baglanti))
            {
                // Parametreleri ekle
                command.Parameters.AddWithValue("@newValue", columnName == "birthDate" ? (object)Convert.ToDateTime(newValue) : newValue);
                command.Parameters.AddWithValue("@uID", LoginCredentials.uID);

                try
                {
                    // Bağlantıyı aç
                    if (baglanti.State != ConnectionState.Open)
                        baglanti.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{columnName} başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bilgi güncellenemedi. Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            // E-posta doğrulama için Regex
            string emailPattern = @"^[^@\s]+@[^@\s]+\.(com|org|net|edu)$";
            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
        }

        private void usernameupdate_Click(object sender, EventArgs e)
        {
            UpdateUserInfo("uName",usrnameTextBox.Text);
        }

        private void passwordupdate_Click(object sender, EventArgs e)
        {
            UpdateUserInfo("uPassword", passwordtextBox.Text);
        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
