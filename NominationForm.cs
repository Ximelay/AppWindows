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
        public NominationForm()
        {
            InitializeComponent();
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
    }
}
