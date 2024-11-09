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

namespace PRG282_Project
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            int totalStudents = 0;
            double averageAge = 0;
            (totalStudents, averageAge) = logic.Calculate();
            lblTotalStudents.Text = totalStudents.ToString();
            lblAverageAge.Text = averageAge.ToString();
        }

        private void btnTXT_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            logic.CalculateForTXT();
            MessageBox.Show("Summary Report written to 'summary.txt' file in the bin folder");
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            logic.CalculateForPDF();
            MessageBox.Show("Summary Report written to 'summary.pdf' file in the bin folder");
        }
    }
}
