using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeInfoBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(this);
            employeeForm.Show();
            employeeForm.Focus();
            this.Hide();
        }

        private void rykovoditelInfoBtn_Click(object sender, EventArgs e)
        {
            RykovoditelForm rykovoditelForm = new RykovoditelForm(this);
            rykovoditelForm.Show();
            rykovoditelForm.Focus();
            this.Hide();
        }

        private void educationOrgIntoBtn_Click(object sender, EventArgs e)
        {
            EducationOrgForm educationOrgForm = new EducationOrgForm(this);
            educationOrgForm.Show();
            educationOrgForm.Focus();
            this.Hide();
        }
    }
}
