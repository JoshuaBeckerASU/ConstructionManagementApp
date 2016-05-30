using System;

namespace WindowsFormsApplication1
{
    partial class CheckIn
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
            this.SignInB = new System.Windows.Forms.Button();
            this.JobListCB = new System.Windows.Forms.ComboBox();
            this.EmployeeIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jobListDataSet = new WindowsFormsApplication1.JobListDataSet();
            this.jobListDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobListDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jobListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobListDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobListDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInB
            // 
            this.SignInB.Location = new System.Drawing.Point(328, 11);
            this.SignInB.Name = "SignInB";
            this.SignInB.Size = new System.Drawing.Size(123, 21);
            this.SignInB.TabIndex = 0;
            this.SignInB.Text = "Sign-In";
            this.SignInB.UseVisualStyleBackColor = true;
            this.SignInB.Click += new System.EventHandler(this.SignInB_Click);
            // 
            // JobListCB
            // 
            this.JobListCB.DataSource = this.jobListDataSetBindingSource;
            this.JobListCB.FormattingEnabled = true;
            this.JobListCB.Location = new System.Drawing.Point(12, 12);
            this.JobListCB.Name = "JobListCB";
            this.JobListCB.Size = new System.Drawing.Size(110, 21);
            this.JobListCB.TabIndex = 1;
            this.JobListCB.Tag = "JobListCB";
            this.JobListCB.SelectedIndexChanged += new System.EventHandler(this.JobListCB_SelectedIndexChanged);
            // 
            // EmployeeIdTB
            // 
            this.EmployeeIdTB.Location = new System.Drawing.Point(200, 11);
            this.EmployeeIdTB.Name = "EmployeeIdTB";
            this.EmployeeIdTB.Size = new System.Drawing.Size(122, 20);
            this.EmployeeIdTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Id:";
            // 
            // jobListDataSet
            // 
            this.jobListDataSet.DataSetName = "JobListDataSet";
            this.jobListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobListDataSetBindingSource
            // 
            this.jobListDataSetBindingSource.DataSource = this.jobListDataSet;
            this.jobListDataSetBindingSource.Position = 0;
            // 
            // jobListDataSetBindingSource1
            // 
            this.jobListDataSetBindingSource1.DataSource = this.jobListDataSet;
            this.jobListDataSetBindingSource1.Position = 0;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 38);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeIdTB);
            this.Controls.Add(this.JobListCB);
            this.Controls.Add(this.SignInB);
            this.Name = "CheckIn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check-In";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobListDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobListDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button SignInB;
        private System.Windows.Forms.ComboBox JobListCB;
        private System.Windows.Forms.TextBox EmployeeIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource jobListDataSetBindingSource;
        private JobListDataSet jobListDataSet;
        private System.Windows.Forms.BindingSource jobListDataSetBindingSource1;
    }
}