using AppWindows.Sql_queryForms;
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

        private void NominationInfoBtn_Click(object sender, EventArgs e)
        {
            NominationForm nominationForm = new NominationForm(this);
            nominationForm.Show();
            nominationForm.Focus();
            this.Hide();
        }

        private void allUsersAndAnotherDataBtn_Click(object sender, EventArgs e)
        {
            AllUsersAndAnotherData allUsersAndAnotherData = new AllUsersAndAnotherData(this);
            allUsersAndAnotherData.Show();
            allUsersAndAnotherData.Focus();
            this.Hide();
        }

        private void sortByNominationsBtn_Click(object sender, EventArgs e)
        {
            SortByNominations sortByNominationsForm = new SortByNominations(this);
            sortByNominationsForm.Show();
            sortByNominationsForm.Focus();
            this.Hide();
        }

        private void sortByOrganizationsBtn_Click(object sender, EventArgs e)
        {
            SortByOrganizations sortByOrganizationsForm = new SortByOrganizations(this);
            sortByOrganizationsForm.Show();
            sortByOrganizationsForm.Focus();
            this.Hide();
        }

        private void CountEmplouesAtRykovoditelsBtn_Click(object sender, EventArgs e)
        {
            CountEmployesAtRykovoditels countEmployesAtRykovoditelsForm = new CountEmployesAtRykovoditels(this);
            countEmployesAtRykovoditelsForm.Show();
            countEmployesAtRykovoditelsForm.Focus();
            this.Hide();
        }

        private void nominationLessThreeEmployes_Click(object sender, EventArgs e)
        {
            NominationLessThreeEmployes nominationLessThreeEmployesForm = new NominationLessThreeEmployes(this);
            nominationLessThreeEmployesForm.Show();
            nominationLessThreeEmployesForm.Focus();
            this.Hide();
        }
    }
}
