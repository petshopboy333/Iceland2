namespace JobManagerWin
{
    partial class FormHome
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
            this.Action = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // Action
            // 
            this.Action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.Action.Location = new System.Drawing.Point(0, 0);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(800, 24);
            this.Action.TabIndex = 0;
            this.Action.Text = "Action";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewJobsToolStripMenuItem,
            this.addJobToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // viewJobsToolStripMenuItem
            // 
            this.viewJobsToolStripMenuItem.Name = "viewJobsToolStripMenuItem";
            this.viewJobsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewJobsToolStripMenuItem.Text = "View Jobs";
            this.viewJobsToolStripMenuItem.Click += new System.EventHandler(this.viewJobsToolStripMenuItem_Click);
            // 
            // addJobToolStripMenuItem
            // 
            this.addJobToolStripMenuItem.Name = "addJobToolStripMenuItem";
            this.addJobToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addJobToolStripMenuItem.Text = "Add Job";
            this.addJobToolStripMenuItem.Click += new System.EventHandler(this.addJobToolStripMenuItem_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Action);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Manager";
            this.Action.ResumeLayout(false);
            this.Action.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Action;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addJobToolStripMenuItem;
    }
}