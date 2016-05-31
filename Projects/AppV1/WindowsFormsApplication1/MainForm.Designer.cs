using System;

namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timeSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documnentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saftyMeetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingCodeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biddingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeSheetsToolStripMenuItem,
            this.documnentsToolStripMenuItem,
            this.logInToolStripMenuItem,
            this.biddingToolStripMenuItem,
            this.contactListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // timeSheetsToolStripMenuItem
            // 
            this.timeSheetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInMenuItem,
            this.checkOutToolStripMenuItem});
            this.timeSheetsToolStripMenuItem.Name = "timeSheetsToolStripMenuItem";
            this.timeSheetsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.timeSheetsToolStripMenuItem.Tag = "TimeSheets";
            this.timeSheetsToolStripMenuItem.Text = "TimeSheets";
            // 
            // checkInMenuItem
            // 
            this.checkInMenuItem.Name = "checkInMenuItem";
            this.checkInMenuItem.Size = new System.Drawing.Size(132, 22);
            this.checkInMenuItem.Tag = "CheckIn";
            this.checkInMenuItem.Text = "Check-In";
            this.checkInMenuItem.Click += new System.EventHandler(this.checkInMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // documnentsToolStripMenuItem
            // 
            this.documnentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saftyMeetingsToolStripMenuItem,
            this.incidentReportToolStripMenuItem,
            this.buildingCodeInfoToolStripMenuItem});
            this.documnentsToolStripMenuItem.Name = "documnentsToolStripMenuItem";
            this.documnentsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.documnentsToolStripMenuItem.Text = "Documnents";
            // 
            // saftyMeetingsToolStripMenuItem
            // 
            this.saftyMeetingsToolStripMenuItem.Name = "saftyMeetingsToolStripMenuItem";
            this.saftyMeetingsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saftyMeetingsToolStripMenuItem.Text = "Safty Meetings";
            // 
            // incidentReportToolStripMenuItem
            // 
            this.incidentReportToolStripMenuItem.Name = "incidentReportToolStripMenuItem";
            this.incidentReportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.incidentReportToolStripMenuItem.Text = "Incident Report";
            // 
            // buildingCodeInfoToolStripMenuItem
            // 
            this.buildingCodeInfoToolStripMenuItem.Name = "buildingCodeInfoToolStripMenuItem";
            this.buildingCodeInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buildingCodeInfoToolStripMenuItem.Text = "Building Code Info";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.logInToolStripMenuItem.Text = "Log-In";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // biddingToolStripMenuItem
            // 
            this.biddingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decksToolStripMenuItem,
            this.sidingsToolStripMenuItem});
            this.biddingToolStripMenuItem.Name = "biddingToolStripMenuItem";
            this.biddingToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.biddingToolStripMenuItem.Text = "Bidding";
            this.biddingToolStripMenuItem.Click += new System.EventHandler(this.biddingToolStripMenuItem_Click);
            // 
            // decksToolStripMenuItem
            // 
            this.decksToolStripMenuItem.Name = "decksToolStripMenuItem";
            this.decksToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.decksToolStripMenuItem.Tag = "Decks";
            this.decksToolStripMenuItem.Text = "Decks";
            this.decksToolStripMenuItem.Click += new System.EventHandler(this.decksToolStripMenuItem_Click);
            // 
            // sidingsToolStripMenuItem
            // 
            this.sidingsToolStripMenuItem.Name = "sidingsToolStripMenuItem";
            this.sidingsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sidingsToolStripMenuItem.Text = "Siding";
            this.sidingsToolStripMenuItem.Click += new System.EventHandler(this.sidingsToolStripMenuItem_Click);
            // 
            // contactListToolStripMenuItem
            // 
            this.contactListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.storesToolStripMenuItem});
            this.contactListToolStripMenuItem.Name = "contactListToolStripMenuItem";
            this.contactListToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.contactListToolStripMenuItem.Text = "Contact List";
            this.contactListToolStripMenuItem.Click += new System.EventHandler(this.checkInMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.eployeesListToolStripMenuItem_Click);
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.storesToolStripMenuItem.Text = "Stores";
            this.storesToolStripMenuItem.Click += new System.EventHandler(this.storesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joseph Builders - Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem documnentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingCodeInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biddingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saftyMeetingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decksToolStripMenuItem;
    }
}

