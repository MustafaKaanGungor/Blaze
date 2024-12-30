using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Blaze
{

    public partial class EditProfile : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = Blaze;" +
    " user ID = postgres; password = 123");
        public EditProfile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Account login = new Account();
            login.MdiParent = this.MdiParent;
            login.Dock = DockStyle.Fill;
            login.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UpdateUserInfo("uName", userNameTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newEmail = mailTextBox.Text;

            // E-posta formatını kontrol et
            if (!IsValidEmail(newEmail))
            {
                MessageBox.Show("Geçersiz e-posta adresi. Lütfen '@' ve '.com' içeren bir adres giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdateUserInfo("uEmail", newEmail);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateUserInfo("birthDate", birthDateTextBox.Text);
        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
