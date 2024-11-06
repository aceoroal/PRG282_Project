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
            pnlMain.Controls.Clear();
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
            Student student = new Student();
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
            // Closing the Application
            Environment.Exit(0);
        }
    }
}
