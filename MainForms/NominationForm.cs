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
    public partial class NominationForm : Form
    {
        private MainForm mainForm;
        public NominationForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void nomination_OlimpiadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nomination_OlimpiadsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lazutkinDataSet);

        }

        private void NominationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.Nomination_Olimpiads' table. You can move, or remove it, as needed.
            this.nomination_OlimpiadsTableAdapter.Fill(this.lazutkinDataSet.Nomination_Olimpiads);

        }

        private void backMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Focus();
            this.Close();
        }

        private void AllNominationsBtn_Click(object sender, EventArgs e)
        {
            AllNominations allNominations = new AllNominations(this);
            allNominations.Show();
            allNominations.Focus();
            this.Hide();
        }

        private void addNominationBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Создать новую запись?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    nomination_OlimpiadsBindingSource.AddNew();
                    MessageBox.Show("Введите данные для создания новой записи и после нажмите 'Сохранить'",
                        "Предупреждение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании новой записи: " + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void editNominationBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изменить текущую запись?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    nomination_OlimpiadsBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Запись успешно изменена.", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении записи: " + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeNominationBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить текущую запись?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    nomination_OlimpiadsBindingSource.RemoveCurrent();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Запись успешно удалена.", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении записи: " + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveNominationBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    nomination_OlimpiadsBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.lazutkinDataSet);
                    MessageBox.Show("Изменения успешно сохранены.", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (nomination_OlimpiadsBindingSource.Position > 0)
            {
                nomination_OlimpiadsBindingSource.MovePrevious();
            }
            else
            {
                MessageBox.Show("Это первая запись.", "Информация");
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (nomination_OlimpiadsBindingSource.Position + 1 < nomination_OlimpiadsBindingSource.Count)
            {
                nomination_OlimpiadsBindingSource.MoveNext();
            }
            else
            {
                MessageBox.Show("Это последняя запись.", "Информация");
            }
        }
    }
}
