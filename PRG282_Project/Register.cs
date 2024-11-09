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
using PRG282_Project.PresentationLayer;

namespace PRG282_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtAge.Value = 1;
            cboCourse.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboCourse.Text != "")
            {
                string studentId = txtStudentID.Text;
                string name = txtName.Text;
                int age = Convert.ToInt32(txtAge.Value);
                string course = cboCourse.Text;

                UserInput input = new UserInput();
                if (input.AddStudent(studentId, name, age, course))
                {
                    // Clear all fields
                    ClearFields();

                    Logic logic = new Logic();
                    logic.PassGeneratedStudentID();
                    txtStudentID.Text = logic.GenerateStudentID();
                }
            }
            else
            {
                MessageBox.Show("Please choose a course!");
                cboCourse.Focus();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            txtStudentID.Text = logic.GenerateStudentID();
        }
    }
}
