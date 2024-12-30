using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            if (e.RowIndex == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                object selecteduID = row.Cells["uID"].Value;
                uID = Convert.ToInt32(selecteduID);

                usrnameTextBox.Text = row.Cells["uName"].Value?.ToString() ?? string.Empty;
                mailtextBox.Text = row.Cells["uEmail"].Value?.ToString()?? string.Empty ;
                passwordtextBox.Text = row.Cells["uPassword"].Value?.ToString()??string.Empty;
            }
        }
    }
}
