namespace ConManApp
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftPanelMenu = new System.Windows.Forms.MenuStrip();
            this.clockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safetyMeetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biddingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClockInPanel = new System.Windows.Forms.Panel();
            this.clockInB = new System.Windows.Forms.Button();
            this.enterIdTB = new System.Windows.Forms.TextBox();
            this.enterIdL = new System.Windows.Forms.Label();
            this.SelectJobL = new System.Windows.Forms.Label();
            this.JobListCB = new System.Windows.Forms.ComboBox();
            this.ClockOutPanel = new System.Windows.Forms.Panel();
            this.clockOutB = new System.Windows.Forms.Button();
            this.workDescpL = new System.Windows.Forms.Label();
            this.workDescpCB = new System.Windows.Forms.ComboBox();
            this.clockOutIdTB = new System.Windows.Forms.TextBox();
            this.ClockOutIdLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelMenu.SuspendLayout();
            this.ClockInPanel.SuspendLayout();
            this.ClockOutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.AutoSize = true;
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LeftPanel.Controls.Add(this.LeftPanelMenu);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPanel.MaximumSize = new System.Drawing.Size(125, 1600);
            this.LeftPanel.MinimumSize = new System.Drawing.Size(125, 365);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(125, 365);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Tag = "LeftPanel";
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            // 
            // LeftPanelMenu
            // 
            this.LeftPanelMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftPanelMenu.AutoSize = false;
            this.LeftPanelMenu.BackColor = System.Drawing.Color.Gray;
            this.LeftPanelMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.LeftPanelMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.LeftPanelMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockInToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.biddingToolStripMenuItem,
            this.contactListToolStripMenuItem,
            this.signInToolStripMenuItem});
            this.LeftPanelMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.LeftPanelMenu.Location = new System.Drawing.Point(10, 10);
            this.LeftPanelMenu.MaximumSize = new System.Drawing.Size(105, 1590);
            this.LeftPanelMenu.MinimumSize = new System.Drawing.Size(105, 345);
            this.LeftPanelMenu.Name = "LeftPanelMenu";
            this.LeftPanelMenu.Padding = new System.Windows.Forms.Padding(0);
            this.LeftPanelMenu.ShowItemToolTips = true;
            this.LeftPanelMenu.Size = new System.Drawing.Size(105, 345);
            this.LeftPanelMenu.TabIndex = 0;
            this.LeftPanelMenu.Text = "LeftPanelMenu";
            // 
            // clockInToolStripMenuItem
            // 
            this.clockInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockInToolStripMenuItem1,
            this.clockOutToolStripMenuItem});
            this.clockInToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.clockInToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.clockInToolStripMenuItem.Name = "clockInToolStripMenuItem";
            this.clockInToolStripMenuItem.Size = new System.Drawing.Size(103, 19);
            this.clockInToolStripMenuItem.Text = "Time Recording";
            // 
            // clockInToolStripMenuItem1
            // 
            this.clockInToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.clockInToolStripMenuItem1.Name = "clockInToolStripMenuItem1";
            this.clockInToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.clockInToolStripMenuItem1.Text = "Clock-In";
            this.clockInToolStripMenuItem1.Click += new System.EventHandler(this.MenuItemHandler);
            // 
            // clockOutToolStripMenuItem
            // 
            this.clockOutToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.clockOutToolStripMenuItem.Name = "clockOutToolStripMenuItem";
            this.clockOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clockOutToolStripMenuItem.Text = "Clock-Out";
            this.clockOutToolStripMenuItem.Click += new System.EventHandler(this.MenuItemHandler);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.safetyMeetingsToolStripMenuItem,
            this.incidentReportToolStripMenuItem,
            this.buildingCodesToolStripMenuItem});
            this.documentsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // safetyMeetingsToolStripMenuItem
            // 
            this.safetyMeetingsToolStripMenuItem.Name = "safetyMeetingsToolStripMenuItem";
            this.safetyMeetingsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.safetyMeetingsToolStripMenuItem.Text = "Safety Meetings";
            // 
            // incidentReportToolStripMenuItem
            // 
            this.incidentReportToolStripMenuItem.Name = "incidentReportToolStripMenuItem";
            this.incidentReportToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.incidentReportToolStripMenuItem.Text = "Incident Report";
            // 
            // buildingCodesToolStripMenuItem
            // 
            this.buildingCodesToolStripMenuItem.Name = "buildingCodesToolStripMenuItem";
            this.buildingCodesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.buildingCodesToolStripMenuItem.Text = "Building Codes";
            // 
            // biddingToolStripMenuItem
            // 
            this.biddingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decksToolStripMenuItem,
            this.sidingToolStripMenuItem});
            this.biddingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.biddingToolStripMenuItem.Name = "biddingToolStripMenuItem";
            this.biddingToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.biddingToolStripMenuItem.Text = "Bidding";
            // 
            // decksToolStripMenuItem
            // 
            this.decksToolStripMenuItem.Name = "decksToolStripMenuItem";
            this.decksToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.decksToolStripMenuItem.Text = "Decks";
            // 
            // sidingToolStripMenuItem
            // 
            this.sidingToolStripMenuItem.Name = "sidingToolStripMenuItem";
            this.sidingToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sidingToolStripMenuItem.Text = "Siding";
            // 
            // contactListToolStripMenuItem
            // 
            this.contactListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.storesToolStripMenuItem});
            this.contactListToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.contactListToolStripMenuItem.Name = "contactListToolStripMenuItem";
            this.contactListToolStripMenuItem.Size = new System.Drawing.Size(82, 19);
            this.contactListToolStripMenuItem.Text = "Contact List";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.storesToolStripMenuItem.Text = "Stores";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem1,
            this.adminToolStripMenuItem});
            this.signInToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.signInToolStripMenuItem.Text = "Sign-In";
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem1.Text = "Employee";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // ClockInPanel
            // 
            this.ClockInPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.ClockInPanel.Controls.Add(this.ClockOutPanel);
            this.ClockInPanel.Controls.Add(this.clockInB);
            this.ClockInPanel.Controls.Add(this.enterIdTB);
            this.ClockInPanel.Controls.Add(this.enterIdL);
            this.ClockInPanel.Controls.Add(this.SelectJobL);
            this.ClockInPanel.Controls.Add(this.JobListCB);
            this.ClockInPanel.Location = new System.Drawing.Point(125, 0);
            this.ClockInPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ClockInPanel.Name = "ClockInPanel";
            this.ClockInPanel.Size = new System.Drawing.Size(259, 365);
            this.ClockInPanel.TabIndex = 1;
            this.ClockInPanel.Visible = false;
            // 
            // clockInB
            // 
            this.clockInB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInB.Location = new System.Drawing.Point(94, 80);
            this.clockInB.Name = "clockInB";
            this.clockInB.Size = new System.Drawing.Size(75, 23);
            this.clockInB.TabIndex = 4;
            this.clockInB.Text = "Clock-In";
            this.clockInB.UseVisualStyleBackColor = true;
            this.clockInB.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // enterIdTB
            // 
            this.enterIdTB.Location = new System.Drawing.Point(94, 46);
            this.enterIdTB.Name = "enterIdTB";
            this.enterIdTB.Size = new System.Drawing.Size(160, 20);
            this.enterIdTB.TabIndex = 3;
            this.enterIdTB.Text = "Ex: \"1234\"";
            // 
            // enterIdL
            // 
            this.enterIdL.AutoSize = true;
            this.enterIdL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterIdL.Location = new System.Drawing.Point(18, 46);
            this.enterIdL.Name = "enterIdL";
            this.enterIdL.Size = new System.Drawing.Size(73, 20);
            this.enterIdL.TabIndex = 2;
            this.enterIdL.Text = "Enter ID:";
            // 
            // SelectJobL
            // 
            this.SelectJobL.AutoSize = true;
            this.SelectJobL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectJobL.Location = new System.Drawing.Point(3, 11);
            this.SelectJobL.Name = "SelectJobL";
            this.SelectJobL.Size = new System.Drawing.Size(88, 20);
            this.SelectJobL.TabIndex = 1;
            this.SelectJobL.Text = "Select Job:";
            // 
            // JobListCB
            // 
            this.JobListCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JobListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobListCB.FormattingEnabled = true;
            this.JobListCB.Location = new System.Drawing.Point(94, 10);
            this.JobListCB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.JobListCB.Name = "JobListCB";
            this.JobListCB.Size = new System.Drawing.Size(160, 21);
            this.JobListCB.TabIndex = 0;
            this.JobListCB.Tag = "JobListCB";
            // 
            // ClockOutPanel
            //
            this.ClockOutPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.ClockOutPanel.Controls.Add(this.clockOutB);
            this.ClockOutPanel.Controls.Add(this.workDescpL);
            this.ClockOutPanel.Controls.Add(this.workDescpCB);
            this.ClockOutPanel.Controls.Add(this.clockOutIdTB);
            this.ClockOutPanel.Controls.Add(this.ClockOutIdLabel);
            this.ClockOutPanel.Location = new System.Drawing.Point(125, 0);
            this.ClockOutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ClockOutPanel.Name = "ClockOutPanel";
            this.ClockOutPanel.Size = new System.Drawing.Size(259, 365);
            this.ClockOutPanel.TabIndex = 1;
            this.ClockOutPanel.Visible = false;
            // 
            // clockOutB
            // 
            this.clockOutB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOutB.Location = new System.Drawing.Point(94, 80);
            this.clockOutB.Name = "clockOutB";
            this.clockOutB.Size = new System.Drawing.Size(75, 23);
            this.clockOutB.TabIndex = 4;
            this.clockOutB.Text = "Clock-Out";
            this.clockOutB.UseVisualStyleBackColor = true;
            this.clockOutB.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // workDescpL
            // 
            this.workDescpL.AutoSize = true;
            this.workDescpL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workDescpL.Location = new System.Drawing.Point(3, 40);
            this.workDescpL.Name = "workDescpL";
            this.workDescpL.Size = new System.Drawing.Size(130, 20);
            this.workDescpL.TabIndex = 3;
            this.workDescpL.Text = "Work Description";
            // 
            // workDescpCB
            // 
            this.workDescpCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workDescpCB.FormattingEnabled = true;
            this.workDescpCB.Location = new System.Drawing.Point(139, 37);
            this.workDescpCB.Name = "workDescpCB";
            this.workDescpCB.Size = new System.Drawing.Size(115, 23);
            this.workDescpCB.TabIndex = 2;
            // 
            // clockOutIdTB
            // 
            this.clockOutIdTB.Location = new System.Drawing.Point(114, 10);
            this.clockOutIdTB.Name = "clockOutIdTB";
            this.clockOutIdTB.Size = new System.Drawing.Size(140, 20);
            this.clockOutIdTB.TabIndex = 1;
            // 
            // ClockOutIdLabel
            // 
            this.ClockOutIdLabel.AutoSize = true;
            this.ClockOutIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockOutIdLabel.Location = new System.Drawing.Point(3, 9);
            this.ClockOutIdLabel.Name = "ClockOutIdLabel";
            this.ClockOutIdLabel.Size = new System.Drawing.Size(104, 20);
            this.ClockOutIdLabel.TabIndex = 0;
            this.ClockOutIdLabel.Text = "Employee ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.ClockInPanel);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "MainForm";
            this.Text = "Joseph Builders";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanelMenu.ResumeLayout(false);
            this.LeftPanelMenu.PerformLayout();
            this.ClockInPanel.ResumeLayout(false);
            this.ClockInPanel.PerformLayout();
            this.ClockOutPanel.ResumeLayout(false);
            this.ClockOutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.MenuStrip LeftPanelMenu;
        private System.Windows.Forms.ToolStripMenuItem clockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clockInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safetyMeetingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biddingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel ClockInPanel;
        private System.Windows.Forms.ComboBox JobListCB;
        private System.Windows.Forms.Label enterIdL;
        private System.Windows.Forms.Label SelectJobL;
        private System.Windows.Forms.Button clockInB;
        private System.Windows.Forms.TextBox enterIdTB;
        private System.Windows.Forms.Panel ClockOutPanel;
        private System.Windows.Forms.Button clockOutB;
        private System.Windows.Forms.Label workDescpL;
        private System.Windows.Forms.ComboBox workDescpCB;
        private System.Windows.Forms.TextBox clockOutIdTB;
        private System.Windows.Forms.Label ClockOutIdLabel;
    }
}

