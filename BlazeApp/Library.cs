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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Panel newPanel = new Panel();
            PictureBox pictureBox = new PictureBox();
            newPanel.Controls.Add(pictureBox);

            newPanel.Size = new System.Drawing.Size(400, 400);
            pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;

            this.tableLayoutPanel1.Controls.Add(panel1);
            this.tableLayoutPanel1.Controls.Add(newPanel);
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
