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

namespace PRG282_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cboSearch.SelectedItem = "ID";
        }
        
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Working");
            Form1 form1 = new Form1();
            EditPage editPage = new EditPage();
            //form1.SwitchPannel(editPage);

            form1.pnlMain.Controls.Clear();
            editPage.TopLevel = false;
            editPage.FormBorderStyle = FormBorderStyle.None;
            editPage.Dock = DockStyle.Fill;
            form1.pnlMain.Controls.Add(editPage);
            editPage.Show();
        }
    }
}
