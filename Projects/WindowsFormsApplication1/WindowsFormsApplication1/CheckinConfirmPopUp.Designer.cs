namespace WindowsFormsApplication1
{
    partial class CheckinConfirmPopUp
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
            this.JobL = new System.Windows.Forms.Label();
            this.EmployeeId = new System.Windows.Forms.Label();
            this.TimeStamp = new System.Windows.Forms.Label();
            this.CancelB = new System.Windows.Forms.Button();
            this.OkCheckInB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JobL
            // 
            this.JobL.AutoSize = true;
            this.JobL.Location = new System.Drawing.Point(12, 9);
            this.JobL.Name = "JobL";
            this.JobL.Size = new System.Drawing.Size(25, 13);
            this.JobL.TabIndex = 0;
            this.JobL.Tag = "Job";
            this.JobL.Text = "Null";
            this.JobL.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Location = new System.Drawing.Point(112, 9);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(25, 13);
            this.EmployeeId.TabIndex = 1;
            this.EmployeeId.Tag = "Id";
            this.EmployeeId.Text = "Null";
            // 
            // TimeStamp
            // 
            this.TimeStamp.AutoSize = true;
            this.TimeStamp.Location = new System.Drawing.Point(225, 9);
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Size = new System.Drawing.Size(25, 13);
            this.TimeStamp.TabIndex = 2;
            this.TimeStamp.Tag = "TimeStamp";
            this.TimeStamp.Text = "Null";
            // 
            // CancelB
            // 
            this.CancelB.Location = new System.Drawing.Point(44, 60);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 3;
            this.CancelB.Tag = "Cancel";
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            // 
            // OkCheckInB
            // 
            this.OkCheckInB.Location = new System.Drawing.Point(164, 60);
            this.OkCheckInB.Name = "OkCheckInB";
            this.OkCheckInB.Size = new System.Drawing.Size(75, 23);
            this.OkCheckInB.TabIndex = 4;
            this.OkCheckInB.Tag = "Ok";
            this.OkCheckInB.Text = "Ok";
            this.OkCheckInB.UseVisualStyleBackColor = true;
            // 
            // CheckinConfirmPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 95);
            this.ControlBox = false;
            this.Controls.Add(this.OkCheckInB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.TimeStamp);
            this.Controls.Add(this.EmployeeId);
            this.Controls.Add(this.JobL);
            this.Name = "CheckinConfirmPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirm Check-In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JobL;
        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.Label TimeStamp;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button OkCheckInB;
    }
}