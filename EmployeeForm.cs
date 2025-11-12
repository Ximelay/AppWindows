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
    public partial class EmployeeForm : Form
    {
        private MainForm mainForm;
        public EmployeeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lazutkinDataSet);

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.Nomination_Olimpiads' table. You can move, or remove it, as needed.
            this.nomination_OlimpiadsTableAdapter.Fill(this.lazutkinDataSet.Nomination_Olimpiads);
            // TODO: This line of code loads data into the 'lazutkinDataSet.Rykovoditels' table. You can move, or remove it, as needed.
            this.rykovoditelsTableAdapter.Fill(this.lazutkinDataSet.Rykovoditels);
            // TODO: This line of code loads data into the 'lazutkinDataSet.Educational_Organisations' table. You can move, or remove it, as needed.
            this.educational_OrganisationsTableAdapter.Fill(this.lazutkinDataSet.Educational_Organisations);
            // TODO: This line of code loads data into the 'lazutkinDataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.lazutkinDataSet.Employes);

        }

        private void BackMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Focus();
            this.Close();
        }

        private void allEmpoyeeBtn_Click(object sender, EventArgs e)
        {
            AllEmployees allEmployees = new AllEmployees(this);
            allEmployees.Show();
            this.Hide();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            employesBindingSource.AddNew();
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить текущую запись?", "Предупреждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    employesBindingSource.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                employesBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления: " + ex.Message);
            }
        }
    }
}
