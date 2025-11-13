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
            if (MessageBox.Show("Создать новую запись?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    employesBindingSource.AddNew();
                    MessageBox.Show("Введите данные для новой записи и нажмите 'Сохранить'", "Предупреждение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить текущую запись?", "Предупреждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    employesBindingSource.RemoveCurrent();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Запись успешно удалена!", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изменить текущую запись?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void saveEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить все изменения?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    employesBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Данные успешно сохранены!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (employesBindingSource.Position > 0)
            {
                employesBindingSource.MovePrevious();
            }
            else
            {
                MessageBox.Show("Это первая запись!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (employesBindingSource.Position + 1 < employesBindingSource.Count)
            {
                employesBindingSource.MoveNext();
            }
            else
            {
                MessageBox.Show("Это последняя запись!", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
