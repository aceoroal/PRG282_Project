namespace PRG282_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.navLogout = new Guna.UI2.WinForms.Guna2Button();
            this.navAdd = new Guna.UI2.WinForms.Guna2Button();
            this.navDeshboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.CausesValidation = false;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(985, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(50);
            this.btnClose.Size = new System.Drawing.Size(47, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 572);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel4.Controls.Add(this.navLogout);
            this.panel4.Controls.Add(this.navAdd);
            this.panel4.Controls.Add(this.navDeshboard);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 494);
            this.panel4.TabIndex = 1;
            // 
            // navLogout
            // 
            this.navLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.navLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.navLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.navLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.navLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.navLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.navLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.navLogout.ForeColor = System.Drawing.Color.White;
            this.navLogout.Location = new System.Drawing.Point(0, 120);
            this.navLogout.Name = "navLogout";
            this.navLogout.Size = new System.Drawing.Size(204, 60);
            this.navLogout.TabIndex = 2;
            this.navLogout.Text = "Logout";
            // 
            // navAdd
            // 
            this.navAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.navAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.navAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.navAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.navAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.navAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.navAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.navAdd.ForeColor = System.Drawing.Color.White;
            this.navAdd.Location = new System.Drawing.Point(0, 60);
            this.navAdd.Name = "navAdd";
            this.navAdd.Size = new System.Drawing.Size(204, 60);
            this.navAdd.TabIndex = 1;
            this.navAdd.Text = "+ New Student";
            this.navAdd.Click += new System.EventHandler(this.navAdd_Click);
            // 
            // navDeshboard
            // 
            this.navDeshboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navDeshboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.navDeshboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.navDeshboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.navDeshboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.navDeshboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.navDeshboard.FillColor = System.Drawing.Color.White;
            this.navDeshboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.navDeshboard.ForeColor = System.Drawing.Color.Black;
            this.navDeshboard.Location = new System.Drawing.Point(0, 0);
            this.navDeshboard.Name = "navDeshboard";
            this.navDeshboard.Size = new System.Drawing.Size(204, 60);
            this.navDeshboard.TabIndex = 0;
            this.navDeshboard.Text = "Deshboard";
            this.navDeshboard.Click += new System.EventHandler(this.navDeshboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 76);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Shadow
            // 
            this.Shadow.BorderRadius = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(204, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(828, 572);
            this.pnlMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 612);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private Guna.UI2.WinForms.Guna2Button navLogout;
        private Guna.UI2.WinForms.Guna2Button navAdd;
        private Guna.UI2.WinForms.Guna2Button navDeshboard;
        private System.Windows.Forms.Panel pnlMain;
    }
}

