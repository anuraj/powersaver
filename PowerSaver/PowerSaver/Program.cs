/* Microsoft Public License (Ms-PL) */
namespace PowerSaver
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Windows.Forms;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetCompatibleTextRenderingDefault(false);
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processItems = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process item in processItems)
            {
                if (item.Id != currentProcess.Id)
                {
                    MessageBox.Show(Constants.ApplicationAlreadyRunning, Constants.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Application.Run(new frmMain());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string message = string.Format(CultureInfo.CurrentUICulture, Constants.ApplicationErrorMessage, Environment.NewLine);
            MessageBox.Show(message, Constants.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
