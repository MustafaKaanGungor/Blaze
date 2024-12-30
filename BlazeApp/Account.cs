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

namespace Blaze
{
    public partial class Account : Form
    {

        private int userID; // Kullanıcı ID'si
        public Account()
        {

            InitializeComponent();
            //userID = currentUserId;
            
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = Blaze;" +
            " user ID = postgres; password = 123");
        private void Account_Load(object sender, EventArgs e)
        {
            // Daha önce saklanan uID'yi kullan
            int userID = LoginCredentials.uID;

            // Veritabanından kullanıcı bilgilerini çek
            string query = "SELECT uName, uEmail, birthDate, createdAt FROM Users WHERE uID = @uID";

            using (var command = new NpgsqlCommand(query, baglanti))
            {
                // uID parametresini ekle
                command.Parameters.AddWithValue("@uID", userID);

                try
                {
                    // Bağlantıyı aç
                    if (baglanti.State != ConnectionState.Open)
                        baglanti.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Kullanıcı bilgileri bulunduysa
                        {
                            // Form elemanlarına bilgileri doldur
                            usernameText.Text = reader["uName"].ToString();
                            mailText.Text = reader["uEmail"].ToString();
                            birthDateText.Text = Convert.ToDateTime(reader["birthDate"]).ToShortDateString();
                            creationDateText.Text = $"Hesap Oluşturulma Tarihi: {Convert.ToDateTime(reader["createdAt"]).ToShortDateString()}";
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        //Data yüklenecek
        //usernameText.Text = "";
        //mailText.Text = string.Empty;
        //birthDateText.Text = string.Empty;
        //creationDateText.Text = string.Empty;

        //profil fotoğrafı kısmı da sonra halledilcek
        private void button2_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Hide();
            this.MdiParent.Hide();
        }

        private void mailText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile();
            edit.MdiParent = this.MdiParent;
            edit.Dock = DockStyle.Fill;
            edit.Show();
            this.Hide();

        }
    }
}
