using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaze
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            //Data yüklenecek
            usernameText.Text = "";
            mailText.Text = string.Empty;
            birthDateText.Text = string.Empty;
            creationDateText.Text = string.Empty;

            //profil fotoğrafı kısmı da sonra halledilcek
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Hide();
            this.MdiParent.Hide();
        }
    }
}
