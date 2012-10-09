/* Microsoft Public License (Ms-PL) */
namespace PowerSaver
{
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Microsoft.Win32;

    internal sealed class NativeMethods
    {
        private const int HWND_BROADCAST = 0xFFFF;
        private const int SC_MONITORPOWER = 0xF170;
        private const int WM_SYSCOMMAND = 0x112;

        private const int MONITOR_ON = -1;
        private const int MONITOR_OFF = 2;
        private const int MONITOR_STANBY = 1;

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        internal static void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("ApplicationName", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ApplicationName");
            }
        }

        internal static void TurnOffMonitor()
        {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
        }
    }
}
