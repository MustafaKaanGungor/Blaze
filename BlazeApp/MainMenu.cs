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
    public partial class MainMenu : Form
    {
        Store storeForm;
        Library libraryForm;
        Account accountForm;
        public MainMenu()
        {
            InitializeComponent();
        }

        //ÜST MENÜ TUŞLARI-----------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void BlazeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(storeForm == null)
            {
                storeForm = new Store();
                storeForm.FormClosed += StoreForm_FormClosed;
                storeForm.MdiParent = this;
                storeForm.Dock = DockStyle.Fill;
                storeForm.Show();
            } else
            {
                storeForm.Activate();
            }
        }

        private void StoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            storeForm = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (libraryForm == null)
            {
                libraryForm = new Library();
                libraryForm.FormClosed += LibraryForm_FormClosed;
                libraryForm.MdiParent = this;
                libraryForm.Dock = DockStyle.Fill;
                libraryForm.Show();
            }
            else
            {
                libraryForm.Activate();
            }
        }

        private void LibraryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            libraryForm = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (accountForm == null)
            {
                accountForm = new Account();
                accountForm.FormClosed += AccountForm_FormClosed;
                accountForm.MdiParent = this;
                accountForm.Dock = DockStyle.Fill;
                accountForm.Show();
            }
            else
            {
                accountForm.Activate();
            }
        }

        private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            accountForm = null;
        }
    }
}
