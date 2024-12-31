namespace Blaze
{
    partial class AdminAccount
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usrnameTextBox = new System.Windows.Forms.TextBox();
            this.mailtextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.usernameupdate = new System.Windows.Forms.Button();
            this.passwordupdate = new System.Windows.Forms.Button();
            this.roleupdate = new System.Windows.Forms.Button();
            this.emailupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usrnameTextBox
            // 
            this.usrnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.usrnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usrnameTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usrnameTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.usrnameTextBox.Location = new System.Drawing.Point(65, 508);
            this.usrnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrnameTextBox.Name = "usrnameTextBox";
            this.usrnameTextBox.Size = new System.Drawing.Size(383, 38);
            this.usrnameTextBox.TabIndex = 3;
            this.usrnameTextBox.TextChanged += new System.EventHandler(this.usrnameTextBox_TextChanged);
            // 
            // mailtextBox
            // 
            this.mailtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.mailtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailtextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailtextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mailtextBox.Location = new System.Drawing.Point(579, 509);
            this.mailtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailtextBox.Name = "mailtextBox";
            this.mailtextBox.Size = new System.Drawing.Size(383, 38);
            this.mailtextBox.TabIndex = 4;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.passwordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordtextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.passwordtextBox.Location = new System.Drawing.Point(65, 587);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(383, 38);
            this.passwordtextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(61, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(575, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(61, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(575, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Role";
            // 
            // roleBox
            // 
            this.roleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.roleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roleBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Admin",
            "Developer",
            "PersonalUser"});
            this.roleBox.Location = new System.Drawing.Point(579, 591);
            this.roleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(384, 36);
            this.roleBox.TabIndex = 11;
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // usernameupdate
            // 
            this.usernameupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.usernameupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usernameupdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameupdate.Location = new System.Drawing.Point(454, 508);
            this.usernameupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameupdate.Name = "usernameupdate";
            this.usernameupdate.Size = new System.Drawing.Size(94, 39);
            this.usernameupdate.TabIndex = 12;
            this.usernameupdate.Text = "Update";
            this.usernameupdate.UseVisualStyleBackColor = false;
            this.usernameupdate.Click += new System.EventHandler(this.usernameupdate_Click);
            // 
            // passwordupdate
            // 
            this.passwordupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.passwordupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passwordupdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordupdate.Location = new System.Drawing.Point(454, 590);
            this.passwordupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordupdate.Name = "passwordupdate";
            this.passwordupdate.Size = new System.Drawing.Size(94, 39);
            this.passwordupdate.TabIndex = 13;
            this.passwordupdate.Text = "Update";
            this.passwordupdate.UseVisualStyleBackColor = false;
            this.passwordupdate.Click += new System.EventHandler(this.passwordupdate_Click);
            // 
            // roleupdate
            // 
            this.roleupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.roleupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roleupdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roleupdate.Location = new System.Drawing.Point(983, 591);
            this.roleupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleupdate.Name = "roleupdate";
            this.roleupdate.Size = new System.Drawing.Size(94, 39);
            this.roleupdate.TabIndex = 15;
            this.roleupdate.Text = "Update";
            this.roleupdate.UseVisualStyleBackColor = false;
            // 
            // emailupdate
            // 
            this.emailupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.emailupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emailupdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailupdate.Location = new System.Drawing.Point(983, 509);
            this.emailupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailupdate.Name = "emailupdate";
            this.emailupdate.Size = new System.Drawing.Size(94, 39);
            this.emailupdate.TabIndex = 14;
            this.emailupdate.Text = "Update";
            this.emailupdate.UseVisualStyleBackColor = false;
            // 
            // AdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1185, 762);
            this.Controls.Add(this.roleupdate);
            this.Controls.Add(this.emailupdate);
            this.Controls.Add(this.passwordupdate);
            this.Controls.Add(this.usernameupdate);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.mailtextBox);
            this.Controls.Add(this.usrnameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminAccount";
            this.Text = "AdminAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox usrnameTextBox;
        private System.Windows.Forms.TextBox mailtextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Button usernameupdate;
        private System.Windows.Forms.Button passwordupdate;
        private System.Windows.Forms.Button roleupdate;
        private System.Windows.Forms.Button emailupdate;
    }
}