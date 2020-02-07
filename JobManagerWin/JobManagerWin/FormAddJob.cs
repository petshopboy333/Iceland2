using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace JobManagerWin
{
    public partial class FormAddJob : Form
    {
        public FormAddJob()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobsDataSet5.sp_GetAgencies' table. You can move, or remove it, as needed.
            this.sp_GetAgenciesTableAdapter.Fill(this.jobsDataSet5.sp_GetAgencies);
            // TODO: This line of code loads data into the 'jobsDataSet4.sp_GetLocations' table. You can move, or remove it, as needed.
            this.sp_GetLocationsTableAdapter.Fill(this.jobsDataSet4.sp_GetLocations);
            // TODO: This line of code loads data into the 'jobsDataSet.sp_GetJobTitles' table. You can move, or remove it, as needed.
            this.sp_GetJobTitlesTableAdapter.Fill(this.jobsDataSet.sp_GetJobTitles);

            // Initialise controls 
            rbAgency.Checked = true;
            ddlLocation.SelectedIndex = -1;
            ddlJobTitle.SelectedIndex = -1;
            ddlAgencies.SelectedIndex = -1;

        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) { AddJob(); };
        }

        private void AddJob()
        {
            // Save the job in the database 
            try
            {

                SqlConnection sqlCon = null;
                String SqlconString = ConfigurationManager.ConnectionStrings["JobManagerWin.Properties.Settings.JobsConnectionString"].ConnectionString;

                using (sqlCon = new SqlConnection(SqlconString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("sp_JobInsert", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TitleID", SqlDbType.Int).Value = ddlJobTitle.SelectedValue;
                    cmd.Parameters.AddWithValue("@LocationID", SqlDbType.Int).Value = ddlLocation.SelectedValue;
                    cmd.Parameters.AddWithValue("@CVSubmittedDate", SqlDbType.DateTime).Value = dtpDateCVSubmitted.Value;
                    cmd.Parameters.AddWithValue("@Company", SqlDbType.Text).Value = txtCompany.Text;
                    cmd.Parameters.AddWithValue("@Salary", SqlDbType.Text).Value = txtSalary.Text;
                    cmd.Parameters.AddWithValue("@AgencyID", SqlDbType.Int).Value = ddlAgencies.SelectedValue;
                    cmd.Parameters.AddWithValue("@Contact", SqlDbType.Text).Value = txtContact.Text;
                    cmd.Parameters.AddWithValue("@TelephoneNo", SqlDbType.Text).Value = txtTelephoneNo.Text;
                    cmd.Parameters.AddWithValue("@Website", SqlDbType.Text).Value = txtWebsite.Text;

                    if (rbAgency.Checked)
                    {
                        cmd.Parameters.AddWithValue("@AgencyJob", SqlDbType.Bit).Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@AgencyJob", SqlDbType.Bit).Value = 0;
                    }


                    cmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Job added", "Job Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidateForm()
        {

            string messageText = "The following data is missing - please enter\n\n";
            bool isFormValid = true;
            
            if (ddlJobTitle.SelectedIndex == -1)
            {
                messageText += "Job title\n";
                isFormValid = false; 
            }

            if (ddlLocation.SelectedIndex == -1)
            {
                messageText += "Location\n";
                isFormValid = false;
            }

            if (txtCompany.Text == "")
            {
                messageText += "Company\n";
                isFormValid = false;
            }

            if (txtSalary.Text == "")
            {
                messageText += "Salary\n";
                isFormValid = false;
            }

            if (txtWebsite.Text == "")
            {
                messageText += "Company website\n";
                isFormValid = false;
            }



            // Only validate these controls if its an agency job 
            if (rbAgency.Checked)
            {

                if (ddlAgencies.SelectedIndex == -1)
                {
                    messageText += "Agency\n";
                    isFormValid = false;
                }

                if (txtContact.Text == "")
                {
                    messageText += "Contact\n";
                    isFormValid = false;
                }

                if (txtTelephoneNo.Text == "")
                {
                    messageText += "Telephone Number\n";
                    isFormValid = false;
                }
            }

            if (!isFormValid)
            {
                ValidationMessage(messageText);
            }
            else
            {
                isFormValid = true;
            }

            return isFormValid;
        }


        private void ValidationMessage(string message)
        {
            MessageBox.Show(message, "Vaidation error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        private void rbDirect_Click(object sender, EventArgs e)
        {
            ddlAgencies.Enabled = false;
            txtContact.Enabled = false;
            txtTelephoneNo.Enabled = false;
        }

        private void rbAgency_Click(object sender, EventArgs e)
        {
            ddlAgencies.Enabled = true;
            txtContact.Enabled = true;
            txtTelephoneNo.Enabled = true;
        }
    }
}
