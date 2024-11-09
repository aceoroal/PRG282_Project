using Guna.UI2.WinForms;
using PRG282_Project.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.IO;

namespace PRG282_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Navigation focus
        private UserInput gui;

        public void SwitchPannel(Form form)
        {
            pnlMain.Controls.Clear(); // clearing all the controls inside the 'pnlMain' Panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Shadow.SetShadowForm(this);
            lblLoad.Text = "disable";
            Dashboard dashboard = new Dashboard(this);
            gui = new UserInput(this);
            gui.SwitchPannel(dashboard, pnlMain);
        }
        private void navDeshboard_Click(object sender, EventArgs e)
        {
            lblLoad.Text = "disable";
            Dashboard dashboard = new Dashboard(this);
            gui = new UserInput(this);
            gui.NavFocus(navDeshboard);
            gui.SwitchPannel(dashboard, pnlMain);
        }

        private void navAdd_Click(object sender, EventArgs e)
        {
            Register student = new Register();
            gui = new UserInput(this);
            gui.NavFocus(navAdd);
            gui.SwitchPannel(student, pnlMain);
        }

        private void navReport_Click(object sender, EventArgs e)
        {
            Report reportPage = new Report();
            gui = new UserInput(this);
            gui.NavFocus(navReport);
            gui.SwitchPannel(reportPage, pnlMain);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var closeApp = MessageBox.Show("Are you sure you want to close this Application?", "Close App", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (closeApp == DialogResult.Yes)
            {
                Environment.Exit(0); // Closing the Application
            }
        }
    }
}
