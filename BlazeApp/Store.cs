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
            }
            catch { 
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string query = "update library " + dataGridView1.SelectedRows[0].DataBoundItem as String;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);

            }
            catch {
            
            }
        }
    }
}
