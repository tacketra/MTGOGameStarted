using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Drawing;

namespace MtgoGame
{
    class MTGIcon : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        /* creates the mtgo icon for this tray application*/
        public MTGIcon()
        {
            trayIcon = new NotifyIcon();
            trayIcon.Text = "MTGO Game started notifier";
            trayIcon.Icon = new Icon("mtg_icon.ico", 40, 40);

            trayIcon.Visible = true;

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add(0,
                new MenuItem("Settings", new System.EventHandler(Settings)));
            trayMenu.MenuItems.Add(1,
                new MenuItem("Exit", new System.EventHandler(Exit)));
            trayIcon.ContextMenu = trayMenu;

            this.SetStyle(ControlStyles.EnableNotifyMessage, true);

            //Application.Run();
        }

        protected void Exit(Object sender, System.EventArgs e)
        {
            Close();
        }

        protected void Settings(Object sender, System.EventArgs e)
        {
            //SettingsForm settingsForm = new SettingsForm();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SettingsForm());

            /*settings view on the mtgo icon drop down*/
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        }
}
