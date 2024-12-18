using System;
using System.Windows.Forms;

namespace HRTime
{
    public partial class TrayApplicationManager : System.ComponentModel.Component
    {
        // Static instance to ensure only one instance is created
        private static TrayApplicationManager _instance;

        public static TrayApplicationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TrayApplicationManager();
                }
                return _instance;
            }
        }

        // Tray icon
        public NotifyIcon TrayIcon { get; private set; }

        // Context menu for tray icon
        public ContextMenuStrip RightClickMenu { get; private set; }

        // Menu items
        public ToolStripMenuItem OpenMenuItem { get; private set; }
        public ToolStripSeparator MenuSeparator { get; private set; }
        public ToolStripMenuItem ExitMenuItem { get; private set; }

        public TrayApplicationManager()
        {
            InitializeComponent();

            // Initialize the tray icon
            TrayIcon.Visible = true;

            // Event handlers
            TrayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            OpenMenuItem.Click += OpenMenuItem_Click;
            ExitMenuItem.Click += ExitMenuItem_Click;
        }

        // Menu item click event handlers
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            HRTime.My.MyProject.Forms.dashboard.Show();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HRTime.My.MyProject.Forms.dashboard.Show();
        }

        // This ensures the TrayIcon and MenuItems are properly disposed when the application exits
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (TrayIcon != null)
                {
                    TrayIcon.Dispose();
                }

                if (RightClickMenu != null)
                {
                    RightClickMenu.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayApplicationManager));
            TrayIcon = new NotifyIcon(components);
            RightClickMenu = new ContextMenuStrip(components);
            OpenMenuItem = new ToolStripMenuItem();
            MenuSeparator = new ToolStripSeparator();
            ExitMenuItem = new ToolStripMenuItem();
            RightClickMenu.SuspendLayout();
            
            // Tray Icon
            TrayIcon.ContextMenuStrip = RightClickMenu;
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Text = "HRTime";

            // Right-click menu
            RightClickMenu.Items.AddRange(new ToolStripItem[] { OpenMenuItem, MenuSeparator, ExitMenuItem });
            RightClickMenu.Name = "RightClickMenu";
            RightClickMenu.Size = new Size(117, 54);

            // Open menu item
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.Size = new Size(116, 22);
            OpenMenuItem.Text = "&Settings";

            // Exit menu item
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(116, 22);
            ExitMenuItem.Text = "E&xit";

            RightClickMenu.ResumeLayout(false);
        }

        // Other necessary designer components
        private System.ComponentModel.IContainer components;
    }
}