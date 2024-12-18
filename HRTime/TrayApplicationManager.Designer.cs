//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace HRTime
{
    public partial class TrayApplicationManager : System.ComponentModel.Component
    {

        [System.Diagnostics.DebuggerNonUserCode()]
        public TrayApplicationManager(System.ComponentModel.IContainer container) : this()
        //INSTANT C# TODO TASK: C# does not have an equivalent to VB's 'MyClass' keyword
        //ORIGINAL LINE: MyClass.New()
        {

            //Required for Windows.Forms Class Composition Designer support
            if (container != null)
            {
                container.Add(this);
            }

        }

        [System.Diagnostics.DebuggerNonUserCode()]
        public TrayApplicationManager() : base()
        {

            //This call is required by the Component Designer.
            InitializeComponent();

        }

        //Component overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Component Designer
        private System.ComponentModel.IContainer components;

        //NOTE: The following procedure is required by the Component Designer
        //It can be modified using the Component Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
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
            // 
            // TrayIcon
            // 
            TrayIcon.ContextMenuStrip = RightClickMenu;
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Text = "HRTime";
            TrayIcon.Visible = true;
            TrayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            // 
            // RightClickMenu
            // 
            RightClickMenu.Items.AddRange(new ToolStripItem[] { OpenMenuItem, MenuSeparator, ExitMenuItem });
            RightClickMenu.Name = "RightClickMenu";
            RightClickMenu.Size = new Size(117, 54);
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.Size = new Size(116, 22);
            OpenMenuItem.Text = "&Settings";
            OpenMenuItem.Click += OpenMenuItem_Click;
            // 
            // MenuSeparator
            // 
            MenuSeparator.Name = "MenuSeparator";
            MenuSeparator.Size = new Size(113, 6);
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(116, 22);
            ExitMenuItem.Text = "E&xit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            RightClickMenu.ResumeLayout(false);
        }

        internal NotifyIcon TrayIcon;
        internal ContextMenuStrip RightClickMenu;
        internal ToolStripMenuItem OpenMenuItem;
        internal ToolStripSeparator MenuSeparator;
        internal ToolStripMenuItem ExitMenuItem;

    }

} //end of root namespace