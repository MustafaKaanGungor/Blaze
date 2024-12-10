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
    public partial class SignUpScreen : Form
    {
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string usrMail = mailTextBox.Text;
            string usrName = UsernameTextBox.Text;
            string birthDate = BirthDateTextBox.Text;
            string password = PasswordTextBox.Text;
            string passwordConf = PasswordConfTextBox.Text;

            if(password.Equals(passwordConf))
            {
                //yeni kullanıcının bilgileri database e eklenicek
            }
        }
    }
}
