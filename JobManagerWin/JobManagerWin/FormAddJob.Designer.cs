namespace JobManagerWin
{
    partial class FormAddJob
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
            this.ddlJobTitle = new System.Windows.Forms.ComboBox();
            this.spGetJobTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsDataSet = new JobManagerWin.JobsDataSet();
            this.sp_GetJobTitlesTableAdapter = new JobManagerWin.JobsDataSetTableAdapters.sp_GetJobTitlesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlLocation = new System.Windows.Forms.ComboBox();
            this.spGetLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsDataSet4 = new JobManagerWin.JobsDataSet4();
            this.sp_GetLocationsTableAdapter = new JobManagerWin.JobsDataSet4TableAdapters.sp_GetLocationsTableAdapter();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.rbAgency = new System.Windows.Forms.RadioButton();
            this.rbDirect = new System.Windows.Forms.RadioButton();
            this.dtpDateCVSubmitted = new System.Windows.Forms.DateTimePicker();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlAgencies = new System.Windows.Forms.ComboBox();
            this.spGetAgenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsDataSet5 = new JobManagerWin.JobsDataSet5();
            this.sp_GetAgenciesTableAdapter = new JobManagerWin.JobsDataSet5TableAdapters.sp_GetAgenciesTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spGetJobTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAgenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlJobTitle
            // 
            this.ddlJobTitle.DataSource = this.spGetJobTitlesBindingSource;
            this.ddlJobTitle.DisplayMember = "Title";
            this.ddlJobTitle.FormattingEnabled = true;
            this.ddlJobTitle.Location = new System.Drawing.Point(69, 34);
            this.ddlJobTitle.Name = "ddlJobTitle";
            this.ddlJobTitle.Size = new System.Drawing.Size(230, 21);
            this.ddlJobTitle.TabIndex = 0;
            this.ddlJobTitle.ValueMember = "TitleID";
            // 
            // spGetJobTitlesBindingSource
            // 
            this.spGetJobTitlesBindingSource.DataMember = "sp_GetJobTitles";
            this.spGetJobTitlesBindingSource.DataSource = this.jobsDataSet;
            // 
            // jobsDataSet
            // 
            this.jobsDataSet.DataSetName = "JobsDataSet";
            this.jobsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetJobTitlesTableAdapter
            // 
            this.sp_GetJobTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // ddlLocation
            // 
            this.ddlLocation.DataSource = this.spGetLocationsBindingSource;
            this.ddlLocation.DisplayMember = "Location";
            this.ddlLocation.FormattingEnabled = true;
            this.ddlLocation.Location = new System.Drawing.Point(359, 36);
            this.ddlLocation.Name = "ddlLocation";
            this.ddlLocation.Size = new System.Drawing.Size(121, 21);
            this.ddlLocation.TabIndex = 2;
            this.ddlLocation.ValueMember = "LocationID";
            // 
            // spGetLocationsBindingSource
            // 
            this.spGetLocationsBindingSource.DataMember = "sp_GetLocations";
            this.spGetLocationsBindingSource.DataSource = this.jobsDataSet4;
            // 
            // jobsDataSet4
            // 
            this.jobsDataSet4.DataSetName = "JobsDataSet4";
            this.jobsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetLocationsTableAdapter
            // 
            this.sp_GetLocationsTableAdapter.ClearBeforeFill = true;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(69, 77);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(230, 20);
            this.txtCompany.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(661, 73);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 6;
            // 
            // rbAgency
            // 
            this.rbAgency.AutoSize = true;
            this.rbAgency.Location = new System.Drawing.Point(122, 129);
            this.rbAgency.Name = "rbAgency";
            this.rbAgency.Size = new System.Drawing.Size(61, 17);
            this.rbAgency.TabIndex = 8;
            this.rbAgency.TabStop = true;
            this.rbAgency.Text = "Agency";
            this.rbAgency.UseVisualStyleBackColor = true;
            this.rbAgency.Click += new System.EventHandler(this.rbAgency_Click);
            // 
            // rbDirect
            // 
            this.rbDirect.AutoSize = true;
            this.rbDirect.Location = new System.Drawing.Point(213, 129);
            this.rbDirect.Name = "rbDirect";
            this.rbDirect.Size = new System.Drawing.Size(53, 17);
            this.rbDirect.TabIndex = 9;
            this.rbDirect.TabStop = true;
            this.rbDirect.Text = "Direct";
            this.rbDirect.UseVisualStyleBackColor = true;
            this.rbDirect.Click += new System.EventHandler(this.rbDirect_Click);
            // 
            // dtpDateCVSubmitted
            // 
            this.dtpDateCVSubmitted.Location = new System.Drawing.Point(661, 31);
            this.dtpDateCVSubmitted.Name = "dtpDateCVSubmitted";
            this.dtpDateCVSubmitted.Size = new System.Drawing.Size(200, 20);
            this.dtpDateCVSubmitted.TabIndex = 10;
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(405, 186);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 11;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CV sent on";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Agency";
            // 
            // ddlAgencies
            // 
            this.ddlAgencies.DataSource = this.spGetAgenciesBindingSource;
            this.ddlAgencies.DisplayMember = "Agency";
            this.ddlAgencies.FormattingEnabled = true;
            this.ddlAgencies.Location = new System.Drawing.Point(359, 123);
            this.ddlAgencies.Name = "ddlAgencies";
            this.ddlAgencies.Size = new System.Drawing.Size(121, 21);
            this.ddlAgencies.TabIndex = 13;
            this.ddlAgencies.ValueMember = "AgencyID";
            // 
            // spGetAgenciesBindingSource
            // 
            this.spGetAgenciesBindingSource.DataMember = "sp_GetAgencies";
            this.spGetAgenciesBindingSource.DataSource = this.jobsDataSet5;
            // 
            // jobsDataSet5
            // 
            this.jobsDataSet5.DataSetName = "JobsDataSet5";
            this.jobsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetAgenciesTableAdapter
            // 
            this.sp_GetAgenciesTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(564, 126);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Telephone No";
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Location = new System.Drawing.Point(767, 125);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelephoneNo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Website";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(359, 73);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(216, 20);
            this.txtWebsite.TabIndex = 19;
            // 
            // FormAddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 233);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelephoneNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlAgencies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.dtpDateCVSubmitted);
            this.Controls.Add(this.rbDirect);
            this.Controls.Add(this.rbAgency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlJobTitle);
            this.Name = "FormAddJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Job";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spGetJobTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAgenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlJobTitle;
        private JobsDataSet jobsDataSet;
        private System.Windows.Forms.BindingSource spGetJobTitlesBindingSource;
        private JobsDataSetTableAdapters.sp_GetJobTitlesTableAdapter sp_GetJobTitlesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlLocation;
        private JobsDataSet4 jobsDataSet4;
        private System.Windows.Forms.BindingSource spGetLocationsBindingSource;
        private JobsDataSet4TableAdapters.sp_GetLocationsTableAdapter sp_GetLocationsTableAdapter;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.RadioButton rbAgency;
        private System.Windows.Forms.RadioButton rbDirect;
        private System.Windows.Forms.DateTimePicker dtpDateCVSubmitted;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlAgencies;
        private JobsDataSet5 jobsDataSet5;
        private System.Windows.Forms.BindingSource spGetAgenciesBindingSource;
        private JobsDataSet5TableAdapters.sp_GetAgenciesTableAdapter sp_GetAgenciesTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWebsite;
    }
}

