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
    public partial class AllRykovoditels : Form
    {
        private RykovoditelForm rykovoditelForm;
        public AllRykovoditels(RykovoditelForm rykovoditelForm)
        {
            InitializeComponent();
            this.rykovoditelForm = rykovoditelForm;
        }

        private void rykovoditelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rykovoditelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lazutkinDataSet);

        }

        private void AllRykovoditels_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.Rykovoditels' table. You can move, or remove it, as needed.
            this.rykovoditelsTableAdapter.Fill(this.lazutkinDataSet.Rykovoditels);

        }

        private void backRykovoditelForm_Click(object sender, EventArgs e)
        {
            rykovoditelForm.Show();
            rykovoditelForm.Focus();
            this.Hide();
        }
    }
}
