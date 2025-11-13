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
    public partial class EducationOrgForm : Form
    {
        private MainForm mainForm;
        public EducationOrgForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void educational_OrganisationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.educational_OrganisationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lazutkinDataSet);

        }

        private void EducationOrgForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.Educational_Organisations' table. You can move, or remove it, as needed.
            this.educational_OrganisationsTableAdapter.Fill(this.lazutkinDataSet.Educational_Organisations);

        }

        private void backMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Focus();
            this.Close();
        }

        private void allEducationOrgBtn_Click(object sender, EventArgs e)
        {
            AllEducationOrganizations allEducationOrganizations = new AllEducationOrganizations(this);
            allEducationOrganizations.Show();
            allEducationOrganizations.Focus();
            this.Hide();
        }

        private void addEducationOrgBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Создать запись?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    educational_OrganisationsBindingSource.AddNew();
                    MessageBox.Show("Введите данные новой записи и нажмите 'Сохранить'", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void editEducationOrgBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изменить текущую запись?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    educational_OrganisationsBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);

                    MessageBox.Show("Изменения сохранены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void removeEducationOrgBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить текущую запись?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    educational_OrganisationsBindingSource.RemoveCurrent();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Данные успешно удалены!", "Информация");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (educational_OrganisationsBindingSource.Position > 0)
            {
                educational_OrganisationsBindingSource.MovePrevious();
            }
            else
            {
                MessageBox.Show("Это первая запись!", "Информация");
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (educational_OrganisationsBindingSource.Position + 1 < educational_OrganisationsBindingSource.Count)
            {
                educational_OrganisationsBindingSource.MoveNext();
            }
            else
            {
                MessageBox.Show("Это последняя запись!", "Информация");
            }
        }

        private void saveEducOrgBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить все изменения?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    educational_OrganisationsBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Данные успешно сохранены!", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
