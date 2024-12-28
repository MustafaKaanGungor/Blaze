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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Blaze
{
    public partial class SignUpScreen : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = Blaze;" +
        " user ID = postgres; password = 123");
        DateTime birthDateG;
        public SignUpScreen()
        {
            InitializeComponent();
        }
    
        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!mailTextBox.Text.EndsWith(".com") || !mailTextBox.Text.Contains("@"))
            {
                mailCaution.Visible = true;
            }
            else
            {
                mailCaution.Visible = false;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Users WHERE uName = '" + usernameTextBox.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);

                DataTable dTable = new DataTable();
                da.Fill(dTable);

                if (!(dTable.Rows.Count > 0))
                {
                    usrnameCaution.Visible = true;
                }
                else
                {
                    usrnameCaution.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void BirthdateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(BirthdateTextBox.Text, out birthDateG))
            {
                bdateCaution.Visible=true;
            } else
            {
                bdateCaution.Visible = false;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < PasswordTextBox.Text.Length; i++)
            {
                // If the character is uppercase, add +1 to the counter
                if (char.IsUpper(PasswordTextBox.Text[i]))
                {
                    counter++;
                }
            }
            if (counter == 0 && PasswordTextBox.Text.Length < 6)
            {
                passwCaution.Visible = true;
            } else
            {
                passwCaution.Visible = false;
            }
        }

        private void PasswordConfTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!PasswordTextBox.Text.Equals(PasswordConfTextBox.Text))
            {
                confCaution.Visible = true;
            } else
            {
                confCaution.Visible = false;
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string usrMail = mailTextBox.Text;
            string usrName = usernameTextBox.Text;
            string birthDate = BirthdateTextBox.Text;
            string password = PasswordTextBox.Text;
            string passwordConf = PasswordConfTextBox.Text;
            
            
            if (string.IsNullOrEmpty(usrName) && string.IsNullOrEmpty(""))
            {
                
            }
            // Kayıt işlemini başlat
            RegisterUser(usrName, usrMail, password, birthDateG);
        }

        private void RegisterUser(string username, string email, string password, DateTime birthDay)
        {
            // Veritabanı bağlantısı oluştur




            // Veritabanına kullanıcıyı eklemek için SQL sorgusu
            string query = "INSERT INTO Users (uName, uEmail, uPassword,birthDate,role) VALUES (@Username, @Email, @Password,@birthDay,'PersonelUser')";
            //using (var command = new Npgsql.NpgsqlCommand(query, baglanti))
            {
                // Parametreleri ekle
                //command.Parameters.AddWithValue("@Username", username);
                //command.Parameters.AddWithValue("@Email", email);
                //command.Parameters.AddWithValue("@Password", password);
                //command.Parameters.AddWithValue("@birthDay", birthDay);
                try
                {
                    //command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //ÜST MENÜ TUŞLARI-----------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

    }
}
