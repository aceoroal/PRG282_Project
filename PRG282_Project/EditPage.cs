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

// import namespaces
using PRG282_Project.BusinessLogicLayer;
using PRG282_Project.DataAccessLayer;
using Guna.UI2.WinForms;

namespace PRG282_Project
{
    public partial class EditPage : Form
    {
        private Dashboard _dashboard;

        private Form1 mainForm;
        private UserInput gui;
        public EditPage(Form1 form1, List<string> studentData)
        {
            InitializeComponent();
            mainForm = form1;
            _dashboard = Dashboard.GetInstance();

            txtStudentID.Text = studentData[0];
            txtName.Text = studentData[1];
            txtAge.Value = int.Parse(studentData[2]);
            cboCourse.SelectedItem = studentData[3];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(mainForm, "reload");
            mainForm.SwitchPannel(dashboard);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentID.Text;
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Value);
            string course = cboCourse.Text;

            UserInput input = new UserInput();
            input.UpdateStudent(studentId, name, age, course);

            // Switch back to the Dashboard
            Dashboard dashboard = new Dashboard(mainForm, "reload");
            mainForm.SwitchPannel(dashboard);
        }
    }
}
