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
    public partial class CountEmployesAtRykovoditels : Form
    {
        private MainForm mainForm;
        public CountEmployesAtRykovoditels(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CountEmployesAtRykovoditels_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lazutkinDataSet.КоличествоУчастниковУРуководителя' table. You can move, or remove it, as needed.
            this.количествоУчастниковУРуководителяTableAdapter.Fill(this.lazutkinDataSet.КоличествоУчастниковУРуководителя);

        }

        private void backMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            mainForm.Focus();
            this.Close();
        }
    }
}
