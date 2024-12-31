using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Npgsql;
using System.Data.SqlClient;

namespace Blaze
{

    public partial class LoginScreen : Form
    {
        
        public LoginScreen()
        {
            InitializeComponent();
            if (LoginCredentials.keepLogin)
            {
                try
                {
                    string query = "SELECT * FROM Users WHERE (uName = '" + LoginCredentials.usernameOrEmail + "' OR uEmail = '" + LoginCredentials.usernameOrEmail + "')" +
                        " AND uPassword = '" + LoginCredentials.password + "'";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);

                    DataTable dTable = new DataTable();
                    da.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {

                        MainMenu menu1 = new MainMenu();
                        menu1.Show();
                        this.Hide();
                    }
                    else
                    {
                    }
                }
                catch
                {
                    cannotConnect.Visible = true;
                }
            }
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = Blaze;" +
    " user ID = postgres; password = 123");

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usrMail = mailTextBox.Text;
            string usrPassword = passwordTextBox.Text;

            try
            {
                // Parametreli SQL sorgusu
                string query = "SELECT * FROM Users WHERE (uName = @usrMail OR uEmail = @usrMail) AND uPassword = @usrPassword";
                
                // Veri tablosu oluştur
                DataTable dataTable = new DataTable();
                DataTable dTable = new DataTable();
                //using (var da1 = new NpgsqlDataAdapter(query1, baglanti))
                //{
                    
                //    da1.Fill(dataTable);
                //}
                //if (dataTable.Rows.Count > 0) {
                //    LoginCredentials.uID = (dataTable.Rows[0]["uID"].ToString());
                //}
                // DataAdapter kullanarak veriyi al
                using (var da = new NpgsqlDataAdapter(query, baglanti))
                {
                    // Parametreleri ekle
                    da.SelectCommand.Parameters.AddWithValue("@usrMail", usrMail);
                    da.SelectCommand.Parameters.AddWithValue("@usrPassword", usrPassword);

                    // DataTable'a veriyi doldur
                    da.Fill(dTable);
                }
                ////


                // Eğer kayıt bulunduysa işlemleri yap
                if (dTable.Rows.Count > 0)
                {
                    // userID değerini CurrentUser sınıfına ata
                    
                    LoginCredentials.uID = GetKullaniciID(usrMail, usrPassword);
                    LoginCredentials.role = GetKullaniciRole(usrMail, usrPassword);
                    Console.WriteLine(LoginCredentials.uID);
                    Console.WriteLine(LoginCredentials.role);
                    // Kullanıcı bilgilerini sakla (isteğe bağlı)
                    LoginCredentials.usernameOrEmail = usrMail;
                    LoginCredentials.password = usrPassword;

                    // Ana menüyü göster
                    MainMenu menu1 = new MainMenu();
                    menu1.Show();
                    this.Hide();

                    baglanti.Close();
                }
                else
                {
                    // Giriş başarısız
                    cannotLogin.Visible = true;
                }
            }
            catch (Exception ex)
            {
                // Bağlantı hatası
                cannotConnect.Visible = true;
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpScreen signUpScreen = new SignUpScreen();
            signUpScreen.Show();
            this.Hide();
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
            }else
            {
                this.WindowState= FormWindowState.Maximized;
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

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                LoginCredentials.keepLogin = true;
            } else
            {
                LoginCredentials.keepLogin = false;
                LoginCredentials.usernameOrEmail = String.Empty;
                LoginCredentials.password = String.Empty;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private int GetKullaniciID(string email, string sifre)
        {

            string query1 = "SELECT uID FROM Users WHERE (uName = @usernameOrEmail OR uEmail = @usernameOrEmail) AND uPassword = @password";
            NpgsqlCommand command = new NpgsqlCommand(query1, baglanti);
                command.Parameters.AddWithValue("usernameOrEmail", email);
                command.Parameters.AddWithValue("password", sifre);
               
                baglanti.Open();
                object result = command.ExecuteScalar();
                

                return result != null ? Convert.ToInt32(result) : 0;
            
        }
        private string GetKullaniciRole(string email, string sifre)
        {
            string query1 = "SELECT role FROM Users WHERE (uName = @usernameOrEmail OR uEmail = @usernameOrEmail) AND uPassword = @password";
            NpgsqlCommand command = new NpgsqlCommand(query1, baglanti);
            command.Parameters.AddWithValue("usernameOrEmail", email);
            command.Parameters.AddWithValue("password", sifre);

            
            object result = command.ExecuteScalar();


            return result != null ? Convert.ToString(result) : "";
        }
    }
}
