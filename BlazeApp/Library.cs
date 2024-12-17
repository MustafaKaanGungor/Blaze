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
        }

        private void gameOrderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //oyunların sıralamasını değiştir
        }

        private void genreFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //oyunları türe göre filtrele
        }
    }
}
