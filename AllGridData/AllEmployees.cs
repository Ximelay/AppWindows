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
    public partial class AllEmployees : Form
    {
        private EmployeeForm employeeForm;
        public AllEmployees(EmployeeForm employeeForm)
        {
            InitializeComponent();
            this.employeeForm = employeeForm;
        }

        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lazutkinDataSet);

        }

        private void AllEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.SelectAllEmployees' table. You can move, or remove it, as needed.
            this.selectAllEmployeesTableAdapter.Fill(this.lazutkinDataSet.SelectAllEmployees);
            // TODO: This line of code loads data into the 'lazutkinDataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.lazutkinDataSet.Employes);

        }

        private void backEmployeesForm_Click(object sender, EventArgs e)
        {
            employeeForm.Show();
            employeeForm.Focus();
            this.Close();
        }
    }
}
