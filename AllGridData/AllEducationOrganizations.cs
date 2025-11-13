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
    public partial class AllEducationOrganizations : Form
    {
        private EducationOrgForm educationOrgForm;
        public AllEducationOrganizations(EducationOrgForm educationOrgForm)
        {
            InitializeComponent();
            this.educationOrgForm = educationOrgForm;
        }

        private void educational_OrganisationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.educational_OrganisationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lazutkinDataSet);

        }

        private void AllEducationOrganizations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.Educational_Organisations' table. You can move, or remove it, as needed.
            this.educational_OrganisationsTableAdapter.Fill(this.lazutkinDataSet.Educational_Organisations);

        }

        private void backEducOrgForm_Click(object sender, EventArgs e)
        {
            educationOrgForm.Show();
            educationOrgForm.Focus();
            this.Close();
        }
    }
}
