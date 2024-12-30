using Npgsql;
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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }
        int gID;
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = Blaze;" +
        " user ID = postgres; password = 123");
        private void Store_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                string query = "SELECT * FROM Games";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch { 
                
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                object selectedgID = row.Cells["gID"].Value;
                gID = Convert.ToInt32(selectedgID);
            } 
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string query = "INSERT INTO Library (uID, gID, playTime) VALUES (@userID, @gameID, 0)";
                using (var command = new Npgsql.NpgsqlCommand(query, baglanti))
                {
                    command.Parameters.AddWithValue("@userID", LoginCredentials.uID);
                    command.Parameters.AddWithValue("gameID", gID);

                    command.ExecuteNonQuery();
                    baglanti.Close();
                }

            } catch { 
            
            }
        }
    }
}
