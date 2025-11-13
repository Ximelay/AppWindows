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
    public partial class NominationLessThreeEmployes : Form
    {
        private MainForm mainForm;
        public NominationLessThreeEmployes(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void NominationLessThreeEmployes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.УКакойНоминацииМеньшеТрехУчастников' table. You can move, or remove it, as needed.
            this.уКакойНоминацииМеньшеТрехУчастниковTableAdapter.Fill(this.lazutkinDataSet.УКакойНоминацииМеньшеТрехУчастников);

        }

        private void backMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Focus();
            this.Close();
        }
    }
}
