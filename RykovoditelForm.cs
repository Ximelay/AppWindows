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
    }
}
