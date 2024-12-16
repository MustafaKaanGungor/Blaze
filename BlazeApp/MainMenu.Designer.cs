namespace Blaze
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.TopMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.SideMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.BlazePanel = new System.Windows.Forms.Panel();
            this.BlazeButton = new System.Windows.Forms.Button();
            this.StorePanel = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.BlazePanel.SuspendLayout();
            this.StorePanel.SuspendLayout();
            this.LibraryPanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TopMenu.Controls.Add(this.ExitButton);
            this.TopMenu.Controls.Add(this.ResizeButton);
            this.TopMenu.Controls.Add(this.MinimizeButton);
            this.TopMenu.Controls.Add(this.DragPanel);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1450, 38);
            this.TopMenu.TabIndex = 8;
            // 
            // DragPanel
            // 
            this.DragPanel.Location = new System.Drawing.Point(12, 3);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(1309, 35);
            this.DragPanel.TabIndex = 7;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SideMenu.Controls.Add(this.BlazePanel);
            this.SideMenu.Controls.Add(this.StorePanel);
            this.SideMenu.Controls.Add(this.LibraryPanel);
            this.SideMenu.Controls.Add(this.AccountPanel);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 38);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(265, 762);
            this.SideMenu.TabIndex = 14;
            // 
            // BlazePanel
            // 
            this.BlazePanel.Controls.Add(this.pictureBox1);
            this.BlazePanel.Controls.Add(this.BlazeButton);
            this.BlazePanel.Location = new System.Drawing.Point(3, 3);
            this.BlazePanel.Name = "BlazePanel";
            this.BlazePanel.Size = new System.Drawing.Size(259, 145);
            this.BlazePanel.TabIndex = 18;
            // 
            // BlazeButton
            // 
            this.BlazeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BlazeButton.FlatAppearance.BorderSize = 0;
            this.BlazeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlazeButton.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BlazeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.BlazeButton.Location = new System.Drawing.Point(0, 3);
            this.BlazeButton.Name = "BlazeButton";
            this.BlazeButton.Size = new System.Drawing.Size(256, 139);
            this.BlazeButton.TabIndex = 16;
            this.BlazeButton.Text = "      Blaze";
            this.BlazeButton.UseMnemonic = false;
            this.BlazeButton.UseVisualStyleBackColor = true;
            this.BlazeButton.Click += new System.EventHandler(this.BlazeButton_Click);
            // 
            // StorePanel
            // 
            this.StorePanel.Controls.Add(this.pictureBox2);
            this.StorePanel.Controls.Add(this.button19);
            this.StorePanel.Location = new System.Drawing.Point(3, 154);
            this.StorePanel.Name = "StorePanel";
            this.StorePanel.Size = new System.Drawing.Size(259, 100);
            this.StorePanel.TabIndex = 17;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.button19.Location = new System.Drawing.Point(0, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(256, 93);
            this.button19.TabIndex = 16;
            this.button19.Text = "   Store";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Controls.Add(this.pictureBox3);
            this.LibraryPanel.Controls.Add(this.button17);
            this.LibraryPanel.Location = new System.Drawing.Point(3, 260);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(259, 100);
            this.LibraryPanel.TabIndex = 15;
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.button17.Location = new System.Drawing.Point(0, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(256, 93);
            this.button17.TabIndex = 16;
            this.button17.Text = "     Library";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.pictureBox4);
            this.AccountPanel.Controls.Add(this.button18);
            this.AccountPanel.Location = new System.Drawing.Point(3, 366);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(259, 100);
            this.AccountPanel.TabIndex = 17;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.button18.Location = new System.Drawing.Point(-3, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(256, 93);
            this.button18.TabIndex = 16;
            this.button18.Text = "      Account";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Blaze.Properties.Resources.BurnColored;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(22, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 70);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Blaze.Properties.Resources.store;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(22, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 70);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Blaze.Properties.Resources.folder;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(22, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 70);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Blaze.Properties.Resources.user;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(22, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 70);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::Blaze.Properties.Resources.closeRecolor;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1411, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(36, 35);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResizeButton
            // 
            this.ResizeButton.BackgroundImage = global::Blaze.Properties.Resources.asagiAlrecolored2;
            this.ResizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResizeButton.FlatAppearance.BorderSize = 0;
            this.ResizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeButton.Location = new System.Drawing.Point(1369, 3);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(36, 35);
            this.ResizeButton.TabIndex = 8;
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::Blaze.Properties.Resources.AsagiAlrecolor;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1327, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(36, 35);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            this.Text = "Blaze - Menu";
            this.TopMenu.ResumeLayout(false);
            this.SideMenu.ResumeLayout(false);
            this.BlazePanel.ResumeLayout(false);
            this.StorePanel.ResumeLayout(false);
            this.LibraryPanel.ResumeLayout(false);
            this.AccountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TopMenu;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.FlowLayoutPanel SideMenu;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Panel StorePanel;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Panel BlazePanel;
        private System.Windows.Forms.Button BlazeButton;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}