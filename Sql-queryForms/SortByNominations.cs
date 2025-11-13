using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows.Sql_queryForms
{
    public partial class SortByNominations : Form
    {
        private MainForm mainForm;
        public SortByNominations(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SortByNominations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.СортировкаПоНоминациям' table. You can move, or remove it, as needed.
            this.сортировкаПоНоминациямTableAdapter.Fill(this.lazutkinDataSet.СортировкаПоНоминациям);

        }

        private void backMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Focus();
            this.Close();
        }
    }
}
