using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

namespace Nano_Windows_Timer
{
    internal class TrayApp
    {
        private NotifyIcon notifyIcon;
        private bool isExit;
        public TrayApp()
        {
            notifyIcon = new NotifyIcon();

            notifyIcon.Icon = SystemIcons.Application;

            notifyIcon.Text = "Nano Windows Timer";
            notifyIcon.Visible = true;

            notifyIcon.DoubleClick += (s, e) => ShowMainWindow();

            var menu = new ContextMenuStrip();
            var showItem = new ToolStripMenuItem("Show");
            showItem.Click += (s, e) => ShowMainWindow();
            var exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += (s, e) => ExitApplication();

            menu.Items.Add(showItem);
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add(exitItem);

            notifyIcon.ContextMenuStrip = menu;
        }

        private void ShowMainWindow()
        {

        }
        private void ExitApplication()
        {

        }
    }
}
