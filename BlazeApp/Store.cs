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
            this.ControlBox = false; // Pencerenin kapat düğmesini devre dışı bırak
            try
            {
                string query = "SELECT * FROM Games"; // Tüm oyunları getir
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0]; // Oyunları DataGridView'e yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Tıklanan satırın geçerli olduğundan emin olun
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["gID"].Value != null) // gID'nin null olmadığını kontrol edin
                {
                    gID = Convert.ToInt32(row.Cells["gID"].Value); // Seçilen gID'yi al
                }
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (gID == 0)
            {
                MessageBox.Show("Lütfen bir oyun seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "SELECT add_to_library(@userID, @gameID)";
                using (var command = new Npgsql.NpgsqlCommand(query, baglanti))
                {
                    command.Parameters.AddWithValue("@userID", LoginCredentials.uID);
                    command.Parameters.AddWithValue("@gameID", gID);

                    if (baglanti.State != ConnectionState.Open)
                        baglanti.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Oyun başarıyla kütüphanenize eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Library libraryForm = Application.OpenForms.OfType<Library>().FirstOrDefault();
                    if (libraryForm != null)
                    {
                        libraryForm.UpdateLibraryForm(gID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
       
    }
}
