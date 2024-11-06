﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.PresentationLayer
{
    internal class UserInput
    {
        // User interface - Get User input and output

        private Dashboard dashboard;
        private Form1 mainForm;
        public UserInput(Dashboard form)
        {
            dashboard = form;
        }
        public UserInput(Form1 form)
        {
            mainForm = form;
        }

        // Main Form
        public void NavFocus(Guna2Button btn)
        {
            List<Guna2Button> guna2Button = new List<Guna2Button>();

            guna2Button.Add(mainForm.navDeshboard);
            guna2Button.Add(mainForm.navAdd);
            guna2Button.Add(mainForm.navReport);

            foreach (var item in guna2Button)
            {
                if (item == btn)
                {
                    item.FillColor = Color.White;
                    item.ForeColor = Color.Black;
                }
                else
                {
                    item.FillColor = Color.FromArgb(26, 26, 26);
                    item.ForeColor = Color.White;
                }
            }
        }

        // Switching panels
        public void SwitchPannel(Form form, Panel pnlMain)
        {
            pnlMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.Show();
        }



        // Disable Dashboard controls
        public void DisableControls()
        {
            dashboard.cboSearch.Enabled = false;
            dashboard.txtSearch.Enabled = false;
            dashboard.btnSearch.Enabled = false;
            dashboard.lblViewAll.Visible = true;
            dashboard.btnFirst.Enabled = false;
            dashboard.btnPrevious.Enabled = false;
            dashboard.btnNext.Enabled = false;
            dashboard.btnLast.Enabled = false;
            dashboard.btnDelete.Enabled = false;
            dashboard.btnEdit.Enabled = false;
        }

        // Enable Dashboard controls
        public void EnableControls()
        {
            dashboard.cboSearch.SelectedItem = "ID";
            dashboard.txtSearch.Clear();
            dashboard.cboSearch.Enabled = true;
            dashboard.txtSearch.Enabled = true;
            dashboard.btnSearch.Enabled = true;
            dashboard.lblViewAll.Visible = false;
            dashboard.btnFirst.Enabled = true;
            dashboard.btnPrevious.Enabled = true;
            dashboard.btnNext.Enabled = true;
            dashboard.btnLast.Enabled = true;
            dashboard.btnDelete.Enabled = true;
            dashboard.btnEdit.Enabled = true;
        }
    }
}
