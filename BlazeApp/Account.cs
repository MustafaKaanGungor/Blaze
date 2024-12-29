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
            this.ControlBox = false;


            try
            {
                string query = "SELECT uName, uEmail, birthDate FROM Users WHERE uID = @UserID";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);

                DataTable dTable = new DataTable();
                da.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {

                }
                // Kullanıcı ID'sini parametre olarak gönder
                using (var command = new NpgsqlCommand(query, baglanti))
                {
                    command.Parameters.AddWithValue("@UserID", userID); // Kullanıcı ID'sini parametre olarak gönder

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Kullanıcı bilgilerini al ve formdaki alanlara doldur
                            usernameText.Text = reader["uName"].ToString();
                            mailText.Text = reader["uEmail"].ToString();
                            birthDateText.Text = Convert.ToDateTime(reader["birthDate"]).ToString("yyyy-MM-dd");
                            creationDateText.Text = reader["createdAt"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                }
            }
            catch { }
            //Data yüklenecek
            //usernameText.Text = "";
            //mailText.Text = string.Empty;
            //birthDateText.Text = string.Empty;
            //creationDateText.Text = string.Empty;

            //profil fotoğrafı kısmı da sonra halledilcek
        }

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
