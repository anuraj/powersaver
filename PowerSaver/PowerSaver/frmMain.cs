namespace PowerSaver
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;
    using Microsoft.Win32;

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Minimized;
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler((sender, e) =>
            {
                switch (e.Reason)
                {
                    case SessionSwitchReason.SessionLock:
                        NativeMethods.TurnOffMonitor();
                        break;
                }
            });
        }

        private void chkRunOnWindowsStartup_CheckedChanged(object sender, EventArgs e)
        {
            NativeMethods.RegisterInStartup(chkRunOnWindowsStartup.Checked);
            Properties.Settings.Default.RunOnStartup = chkRunOnWindowsStartup.Checked;
            Properties.Settings.Default.Save();
        }

        private void linkUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.dotnetthoughts.net");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void runWhenWindowsStartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NativeMethods.RegisterInStartup(runWhenWindowsStartsToolStripMenuItem.Checked);
            Properties.Settings.Default.RunOnStartup = runWhenWindowsStartsToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            Visible = false;
            SysTrayNotification.Icon = Icon;
            SysTrayNotification.BalloonTipText = "Power Saver - Running...";
            SysTrayNotification.BalloonTipTitle = "Power Saver";
            SysTrayNotification.ShowBalloonTip(2);
            chkRunOnWindowsStartup.Checked = runWhenWindowsStartsToolStripMenuItem.Checked = Properties.Settings.Default.RunOnStartup;
        }

        private void SysTrayNotification_DoubleClick(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void ShowAbout()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SysTrayContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            chkRunOnWindowsStartup.Checked = runWhenWindowsStartsToolStripMenuItem.Checked = Properties.Settings.Default.RunOnStartup;
        }
    }
}
