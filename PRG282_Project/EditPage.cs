using PRG282_Project.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class EditPage : Form
    {
        private Form1 mainForm;
        private UserInput gui;
        public EditPage(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(mainForm);
            mainForm.SwitchPannel(dashboard);
        }
    }
}
