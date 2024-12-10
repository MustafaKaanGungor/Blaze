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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = SteamClone;" +
            " user ID = postgres; password = 123");

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string usrMail = mailTextBox.Text;
            string usrPassword = passwordTextBox.Text;

            try
            {
                string query = "SELECT * FROM Users WHERE (uName = '" + usrMail + "' OR uEmail = '" + usrMail +"')" +
                    " AND uPassword = '" + usrPassword + "'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);

                DataTable dTable = new DataTable();
                da.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
            catch { }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void keepLoginCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
