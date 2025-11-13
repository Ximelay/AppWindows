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
    public partial class RykovoditelForm : Form
    {
        private MainForm mainForm;
        public RykovoditelForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void backMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Focus();
            this.Close();
        }

        private void rykovoditelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rykovoditelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lazutkinDataSet);

        }

        private void RykovoditelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.Rykovoditels' table. You can move, or remove it, as needed.
            this.rykovoditelsTableAdapter.Fill(this.lazutkinDataSet.Rykovoditels);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllRykovoditels allRykovoditels = new AllRykovoditels(this);
            allRykovoditels.Show();
            this.Hide();
        }

        private void addRykovoditelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Создать новую запись?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    rykovoditelsBindingSource.AddNew();
                    MessageBox.Show("Введите данные для создания новой записи и после нажмите 'Сохранить'",
                        "Предупреждение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void editRykovoditelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изменить текущую запись?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    rykovoditelsBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Данные успешно обновлены!", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void removeRykovoditelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить текущую запись?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    rykovoditelsBindingSource.RemoveCurrent();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Запись успешно удалена!", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void saveRykovoditelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить все изменения?", "Предупреждение", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    rykovoditelsBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Все изменения успешно сохранены!", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (rykovoditelsBindingSource.Position > 0)
            {
                rykovoditelsBindingSource.MovePrevious();
            }
            else
            {
                MessageBox.Show("Это первая запись!", "Информация");
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (rykovoditelsBindingSource.Position + 1 < rykovoditelsBindingSource.Count)
            {
                rykovoditelsBindingSource.MoveNext();
            }
            else
            {
                MessageBox.Show("Это последняя запись!", "Информация");
            }
        }
    }
}
