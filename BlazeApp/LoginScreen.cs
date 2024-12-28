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

namespace Blaze
{

    public partial class LoginScreen : Form
    {
        


        
        public LoginScreen()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = SteamClone;" +
    " user ID = postgres; password = 123");

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!mailTextBox.Text.EndsWith(".com") || !mailTextBox.Text.Contains("@"))
            {
                mailCaution.Visible = true;
            } else
            {
                mailCaution.Visible = false;
            }
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
                string query = "SELECT * FROM Users WHERE (uName = '" + usrMail + "' OR uEmail = '" + usrMail + "')" +
                    " AND uPassword = '" + usrPassword + "'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);

                DataTable dTable = new DataTable();
                da.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    if (LoginCredentials.keepLogin == true)
                    {
                        LoginCredentials.usernameOrEmail = usrMail;
                        LoginCredentials.password = usrPassword;
                    }

                    MainMenu menu1 = new MainMenu();
                    menu1.Show();
                    this.Hide();
                } else
                {
                    cannotLogin.Visible = true;
                }
            }
            catch { 
                cannotConnect.Visible = true;
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

    }
}
