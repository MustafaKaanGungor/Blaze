﻿using System;
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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port = 5432; Database = Blaze;" +
        " user ID = postgres; password = 123");
        private void Library_Load(object sender, EventArgs e)
        {

           
        }
        public void UpdateLibraryForm(int uID)
        {
            try
            {
                // Kullanıcıya ait oyunları çekmek için UserGames View'ını kullanıyoruz.
                string query = "SELECT title, description, genre, purchaseDate FROM UserGames WHERE uID = @userID";

                using (var command = new Npgsql.NpgsqlCommand(query, baglanti))
                {
                    // Kullanıcının ID'sini parametre olarak ekliyoruz
                    command.Parameters.AddWithValue("@userID", LoginCredentials.uID);

                    // Verileri çekmek için NpgsqlDataAdapter kullanıyoruz
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    DataSet ds = new DataSet();

                    // Veriyi DataSet'e dolduruyoruz
                    da.Fill(ds);

                    // DataGridView'e veriyi bağlıyoruz
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gameOrderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //oyunların sıralamasını değiştir
        }

        private void genreFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //oyunları türe göre filtrele
        }

        private void tableLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
