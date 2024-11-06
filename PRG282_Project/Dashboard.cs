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

// import all required layers
using PRG282_Project.PresentationLayer;

namespace PRG282_Project
{
    public partial class Dashboard : Form
    {
        private UserInput gui;
        public Dashboard()
        {
            InitializeComponent();
        }
        private Form1 mainForm;
        public Dashboard(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (mainForm.lblLoad.Text == "disable")
            {
                gui = new UserInput(this);
                gui.DisableControls();
            }
            else lblViewAll.Visible = false;
            cboSearch.SelectedItem = "ID";
        }
        
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            gui = new UserInput(this);
            gui.EnableControls();
            mainForm.lblLoad.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPage editPage = new EditPage(mainForm);
            mainForm.SwitchPannel(editPage);
        }
    }
}
