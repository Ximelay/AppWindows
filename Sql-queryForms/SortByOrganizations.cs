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
    public partial class SortByOrganizations : Form
    {
        private MainForm mainForm;
        public SortByOrganizations(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SortByOrganizations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.СортировкаПоОрганизациям' table. You can move, or remove it, as needed.
            this.сортировкаПоОрганизациямTableAdapter.Fill(this.lazutkinDataSet.СортировкаПоОрганизациям);

        }

        private void backMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Focus();
            this.Hide();
        }
    }
}
