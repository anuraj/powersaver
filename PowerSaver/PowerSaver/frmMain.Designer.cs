namespace PowerSaver
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.chkRunOnWindowsStartup = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppDesc = new System.Windows.Forms.Label();
            this.lblAppDev = new System.Windows.Forms.Label();
            this.linkUrl = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.SysTrayNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.SysTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runWhenWindowsStartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LockSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SysTrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRunOnWindowsStartup
            // 
            this.chkRunOnWindowsStartup.AutoSize = true;
            this.chkRunOnWindowsStartup.Location = new System.Drawing.Point(10, 131);
            this.chkRunOnWindowsStartup.Name = "chkRunOnWindowsStartup";
            this.chkRunOnWindowsStartup.Size = new System.Drawing.Size(150, 17);
            this.chkRunOnWindowsStartup.TabIndex = 0;
            this.chkRunOnWindowsStartup.Text = "&Run when Windows starts";
            this.chkRunOnWindowsStartup.UseVisualStyleBackColor = true;
            this.chkRunOnWindowsStartup.CheckedChanged += new System.EventHandler(this.chkRunOnWindowsStartup_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PowerSaver.Properties.Resources.savepower;
            this.pictureBox1.Location = new System.Drawing.Point(7, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(52, 23);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(101, 13);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Power Saver 1.0";
            // 
            // lblAppDesc
            // 
            this.lblAppDesc.Location = new System.Drawing.Point(52, 42);
            this.lblAppDesc.Name = "lblAppDesc";
            this.lblAppDesc.Size = new System.Drawing.Size(251, 31);
            this.lblAppDesc.TabIndex = 2;
            this.lblAppDesc.Text = "A simple utility, which will turn off your monitor when you lock your work statio" +
    "n.";
            // 
            // lblAppDev
            // 
            this.lblAppDev.AutoSize = true;
            this.lblAppDev.Location = new System.Drawing.Point(52, 73);
            this.lblAppDev.Name = "lblAppDev";
            this.lblAppDev.Size = new System.Drawing.Size(109, 13);
            this.lblAppDev.TabIndex = 2;
            this.lblAppDev.Text = "Developed by Anuraj ";
            // 
            // linkUrl
            // 
            this.linkUrl.AutoSize = true;
            this.linkUrl.Location = new System.Drawing.Point(52, 91);
            this.linkUrl.Name = "linkUrl";
            this.linkUrl.Size = new System.Drawing.Size(123, 13);
            this.linkUrl.TabIndex = 3;
            this.linkUrl.TabStop = true;
            this.linkUrl.Text = "www.dotnetthoughts.net";
            this.linkUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUrl_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLicense);
            this.groupBox1.Controls.Add(this.linkUrl);
            this.groupBox1.Controls.Add(this.lblAppDesc);
            this.groupBox1.Controls.Add(this.lblAppDev);
            this.groupBox1.Controls.Add(this.lblAppName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(52, 110);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(237, 13);
            this.lblLicense.TabIndex = 4;
            this.lblLicense.Text = "Licensed under Microsoft Public License (Ms-PL)";
            // 
            // SysTrayNotification
            // 
            this.SysTrayNotification.ContextMenuStrip = this.SysTrayContextMenu;
            this.SysTrayNotification.Text = "Power saver - Running";
            this.SysTrayNotification.Visible = true;
            this.SysTrayNotification.DoubleClick += new System.EventHandler(this.SysTrayNotification_DoubleClick);
            // 
            // SysTrayContextMenu
            // 
            this.SysTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runWhenWindowsStartsToolStripMenuItem,
            this.toolStripSeparator1,
            this.LockSystemToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.SysTrayContextMenu.Name = "SysTrayContextMenu";
            this.SysTrayContextMenu.Size = new System.Drawing.Size(212, 132);
            this.SysTrayContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.SysTrayContextMenu_Opening);
            // 
            // runWhenWindowsStartsToolStripMenuItem
            // 
            this.runWhenWindowsStartsToolStripMenuItem.CheckOnClick = true;
            this.runWhenWindowsStartsToolStripMenuItem.Name = "runWhenWindowsStartsToolStripMenuItem";
            this.runWhenWindowsStartsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.runWhenWindowsStartsToolStripMenuItem.Text = "&Run when Windows Starts";
            this.runWhenWindowsStartsToolStripMenuItem.Click += new System.EventHandler(this.runWhenWindowsStartsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::PowerSaver.Properties.Resources.savepower;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // LockSystemToolStripMenuItem
            // 
            this.LockSystemToolStripMenuItem.Name = "LockSystemToolStripMenuItem";
            this.LockSystemToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.LockSystemToolStripMenuItem.Text = "&Lock this System";
            this.LockSystemToolStripMenuItem.Click += new System.EventHandler(this.LockSystemToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 151);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkRunOnWindowsStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Saver - About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SysTrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRunOnWindowsStartup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppDesc;
        private System.Windows.Forms.Label lblAppDev;
        private System.Windows.Forms.LinkLabel linkUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon SysTrayNotification;
        private System.Windows.Forms.ContextMenuStrip SysTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem runWhenWindowsStartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LockSystemToolStripMenuItem;
    }
}

