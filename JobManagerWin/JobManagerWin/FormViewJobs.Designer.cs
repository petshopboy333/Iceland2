namespace JobManagerWin
{
    partial class FormViewJobs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobsDataSet8 = new JobManagerWin.JobsDataSet8();
            this.spGetJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetJobsTableAdapter = new JobManagerWin.JobsDataSet8TableAdapters.sp_GetJobsTableAdapter();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVSubmittedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyJobDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.agencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetJobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.cVSubmittedDateDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.agencyJobDataGridViewCheckBoxColumn,
            this.agencyDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.telephoneNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spGetJobsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1033, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // jobsDataSet8
            // 
            this.jobsDataSet8.DataSetName = "JobsDataSet8";
            this.jobsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetJobsBindingSource
            // 
            this.spGetJobsBindingSource.DataMember = "sp_GetJobs";
            this.spGetJobsBindingSource.DataSource = this.jobsDataSet8;
            // 
            // sp_GetJobsTableAdapter
            // 
            this.sp_GetJobsTableAdapter.ClearBeforeFill = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // cVSubmittedDateDataGridViewTextBoxColumn
            // 
            this.cVSubmittedDateDataGridViewTextBoxColumn.DataPropertyName = "CVSubmittedDate";
            this.cVSubmittedDateDataGridViewTextBoxColumn.HeaderText = "CVSubmittedDate";
            this.cVSubmittedDateDataGridViewTextBoxColumn.Name = "cVSubmittedDateDataGridViewTextBoxColumn";
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            // 
            // agencyJobDataGridViewCheckBoxColumn
            // 
            this.agencyJobDataGridViewCheckBoxColumn.DataPropertyName = "AgencyJob";
            this.agencyJobDataGridViewCheckBoxColumn.HeaderText = "AgencyJob";
            this.agencyJobDataGridViewCheckBoxColumn.Name = "agencyJobDataGridViewCheckBoxColumn";
            // 
            // agencyDataGridViewTextBoxColumn
            // 
            this.agencyDataGridViewTextBoxColumn.DataPropertyName = "Agency";
            this.agencyDataGridViewTextBoxColumn.HeaderText = "Agency";
            this.agencyDataGridViewTextBoxColumn.Name = "agencyDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            // 
            // FormViewJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormViewJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Jobs";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetJobsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private JobsDataSet8 jobsDataSet8;
        private System.Windows.Forms.BindingSource spGetJobsBindingSource;
        private JobsDataSet8TableAdapters.sp_GetJobsTableAdapter sp_GetJobsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVSubmittedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn agencyJobDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
    }
}