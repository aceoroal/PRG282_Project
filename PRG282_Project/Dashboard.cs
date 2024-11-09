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
using System.Xml.Linq;


// import namesapces
using PRG282_Project.PresentationLayer;
using PRG282_Project.BusinessLogicLayer;
using PRG282_Project.DataAccessLayer;

namespace PRG282_Project
{
    public partial class Dashboard : Form
    {
        private static Dashboard _instance;
        public List<string> studentList;

        private int _currentRowIndex = 0;
        DataGridViewRow row;
        private UserInput gui;
        public Dashboard()
        {
            InitializeComponent();
            studentList = new List<string>();
        }

        private Form1 mainForm;
        public Dashboard(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }
        public Dashboard(Form1 form1, string reloadRequest)
        {
            InitializeComponent();
            mainForm = form1;
            Logic logic = new Logic();
            dgvStudents.DataSource = logic.DisplayStudents();

            if (row == null || row.Index == -1)
            {
                row = dgvStudents.Rows[0];
            }
            // Disable row navigation buttons
            gui = new UserInput(this);
            gui.DisableRowNavigationButtons(dgvStudents.Rows.Count);
        }
        public static Dashboard GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Dashboard();
            }
            return _instance;
        }
        public List<string> GetStudent()
        {
            return studentList;
        }


        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblNoStudents.Visible = false;

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
            Logic logic = new Logic();
            if (row == null || row.Index == -1)
            {
                try
                {
                    gui = new UserInput(this);
                    gui.EnableControls();
                    mainForm.lblLoad.Text = "";

                    gui.ClearSearch(); // Clear combobox and textbox for searching
                    dgvStudents.DataSource = logic.DisplayStudents(); // Display students

                    row = dgvStudents.Rows[0];
                    if (lblNoStudents.Visible == true)
                    {
                        lblNoStudents.Visible = false;
                    }
                }
                catch (Exception)
                {
                    gui.DisableControls();
                    lblViewAll.Visible = false;
                    lblNoStudents.Visible = true;
                    MessageBox.Show("There are no students, add a student first.");
                    return;
                }
            }
            else
            {
                gui.ClearSearch(); // Clear combobox and textbox for searching
                dgvStudents.DataSource = logic.DisplayStudents(); // Display students
            }

            // Disable row navigation buttons
            gui.DisableRowNavigationButtons(dgvStudents.Rows.Count);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (row == null || row.Index == -1)
            {
                row = dgvStudents.Rows[0];
            }

            // Populate the studentList
            studentList = new List<string>
            {
                row.Cells[0].Value.ToString(), // Student ID
                row.Cells[1].Value.ToString(), // Name
                row.Cells[2].Value.ToString(), // Age
                row.Cells[3].Value.ToString()  // Course
            };

            // Pass studentList to EditPage
            EditPage editPage = new EditPage(mainForm, studentList);
            mainForm.SwitchPannel(editPage);
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = this.dgvStudents.Rows[e.RowIndex];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (row == null || row.Index == -1)
            {
                row = dgvStudents.Rows[0];
            }


            string studentId = row.Cells[0].Value.ToString(); // Student ID
            gui.DeleteStudent(studentId);
            Logic logic = new Logic();
            try
            {
                gui = new UserInput(this);
                gui.EnableControls();
                mainForm.lblLoad.Text = "";

                gui.ClearSearch(); // Clear combobox and textbox for searching
                dgvStudents.DataSource = logic.DisplayStudents(); // Display students

                row = dgvStudents.Rows[0];
                if (lblNoStudents.Visible == true)
                {
                    lblNoStudents.Visible = false;
                }
            }
            catch (Exception)
            {
                gui.DisableControls();
                lblViewAll.Visible = false;
                lblNoStudents.Visible = true;
                MessageBox.Show("There are no students, add a student first.");
                return;
            }

            // Disable row navigation buttons
            gui.DisableRowNavigationButtons(dgvStudents.Rows.Count);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Search field is empty");
                txtSearch.Focus();
                return;
            }
            Logic logic = new Logic();
            switch (cboSearch.Text)
            {
                case "ID":
                    if (logic.ValidID(txtSearch.Text))
                    {
                        dgvStudents.DataSource = logic.SearchStudentID(txtSearch.Text);
                    }
                    else
                    {
                        MessageBox.Show("Student ID should only contain 6 digit numbers.");
                    }
                    break;
                case "Name":
                    if (logic.ValidName(txtSearch.Text))
                    {
                        dgvStudents.DataSource = logic.SearchStudentName(txtSearch.Text);
                    }
                    else
                    {
                        MessageBox.Show("Name should only contain alphabet characters with no spaces or special characters.");
                    }
                    break;
                case "Age":
                    try
                    {
                        dgvStudents.DataSource = logic.SearchStudentAge(int.Parse(txtSearch.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Age should countain digits only");
                    }
                    break;
                case "Course":
                    dgvStudents.DataSource = logic.SearchStudentCourse(txtSearch.Text);
                    break;
            }

            gui.DisableRowNavigationButtons(dgvStudents.Rows.Count);
        }

        // Row Navigations
        private void SelectRow(int rowIndex)
        {
            dgvStudents.ClearSelection(); // Clear any previous selection
            dgvStudents.Rows[rowIndex].Selected = true;
            dgvStudents.CurrentCell = dgvStudents.Rows[rowIndex].Cells[0]; // Set focus to a cell in the selected row
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count > 0)
            {
                _currentRowIndex = 0;
                row = dgvStudents.Rows[_currentRowIndex];
                SelectRow(_currentRowIndex);

                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;

                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnLast.Enabled = true;

            if (_currentRowIndex == 1)
            {
                _currentRowIndex--;
                row = dgvStudents.Rows[_currentRowIndex];
                SelectRow(_currentRowIndex);

                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else if (_currentRowIndex > 0)
            {
                _currentRowIndex--;
                row = dgvStudents.Rows[_currentRowIndex];
                SelectRow(_currentRowIndex);
            }
            else
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;

            if (_currentRowIndex == dgvStudents.Rows.Count - 2)
            {
                _currentRowIndex++;
                row = dgvStudents.Rows[_currentRowIndex];
                SelectRow(_currentRowIndex);

                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else if (_currentRowIndex < dgvStudents.Rows.Count - 1)
            {
                _currentRowIndex++;
                row = dgvStudents.Rows[_currentRowIndex];
                SelectRow(_currentRowIndex);
            }
            else
            {
                //MessageBox.Show("You are already on the last student");
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count > 0)
            {
                _currentRowIndex = dgvStudents.Rows.Count - 1;
                row = dgvStudents.Rows[_currentRowIndex];
                SelectRow(_currentRowIndex);

                btnNext.Enabled = false;
                btnLast.Enabled = false;

                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }
        }
    }
}
