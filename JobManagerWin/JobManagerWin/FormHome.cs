using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManagerWin
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void viewJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormViewJobs frmViewJobs = new FormViewJobs();
            frmViewJobs.ShowDialog();
        }

        private void addJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddJob frmAddJob = new FormAddJob();
            frmAddJob.ShowDialog();
        }
    }
}
