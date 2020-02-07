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
    public partial class FormViewJobs : Form
    {
        public FormViewJobs()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobsDataSet8.sp_GetJobs' table. You can move, or remove it, as needed.
            this.sp_GetJobsTableAdapter.Fill(this.jobsDataSet8.sp_GetJobs);
            // TODO: This line of code loads data into the 'jobsDataSet7.sp_GetJobs' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'jobsDataSet6.sp_GetJobs' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'jobsDataSet3.sp_GetJobs' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'jobsDataSet2.sp_GetJobs' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'jobsDataSet1.sp_GetJobs' table. You can move, or remove it, as needed.

        }
    }
}
