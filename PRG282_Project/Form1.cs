using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void SwitchPannel(Form panel)
        {
            pnlMain.Controls.Clear();
            panel.TopLevel = false;
            pnlMain.Controls.Add(panel);
            panel.Show();
        }

        Dashboard dashboard = new Dashboard();
        Student student = new Student();

        private void Form1_Load(object sender, EventArgs e)
        {
            Shadow.SetShadowForm(this);
            
        }
        private void navDeshboard_Click(object sender, EventArgs e)
        {
            NavFocus(navDeshboard);
            SwitchPannel(dashboard);
        }

        private void navAdd_Click(object sender, EventArgs e)
        {
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
