using Guna.UI2.WinForms;
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
        public void NavFocus(Guna2Button btn)
        {
            List<Guna2Button> guna2Button = new List<Guna2Button>();

            guna2Button.Add(navDeshboard);
            guna2Button.Add(navAdd);
            guna2Button.Add(navLogout);

            foreach (var item in guna2Button)
            {
                if (item == btn)
                {
                    item.FillColor = Color.White;
                    item.ForeColor = Color.Black;
                }
                else
                {
                    item.FillColor = Color.FromArgb(26,26,26);
                    item.ForeColor = Color.White;
                }
            }
        }

        // Switching panels
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
            Dashboard dashboard = new Dashboard();
            SwitchPannel(dashboard);
        }
        private void navDeshboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            NavFocus(navDeshboard);
            SwitchPannel(dashboard);
        }

        private void navAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            NavFocus(navAdd);
            SwitchPannel(student);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Closing the Application
            Environment.Exit(0);
        }
    }
}
