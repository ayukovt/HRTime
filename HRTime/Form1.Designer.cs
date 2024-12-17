using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HRTime
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NotifyIcon1 = new NotifyIcon(components);
            ContextMenuStrip1 = new ContextMenuStrip(components);
            ExitToolStripMenuItem = new ToolStripMenuItem();
            Timer1 = new Timer(components);
            PictureBox1 = new PictureBox();
            Label1 = new Label();
            ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NotifyIcon1
            // 
            NotifyIcon1.ContextMenuStrip = ContextMenuStrip1;
            NotifyIcon1.Icon = (Icon)resources.GetObject("NotifyIcon1.Icon");
            NotifyIcon1.Text = "HRTime";
            NotifyIcon1.Visible = true;
            NotifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { ExitToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(94, 26);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(93, 22);
            ExitToolStripMenuItem.Text = "Exit";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // Timer1
            // 
            Timer1.Tick += Timer1_Tick;
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Location = new Point(-1, 1);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(557, 226);
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(202, 26);
            Label1.Name = "Label1";
            Label1.Size = new Size(41, 15);
            Label1.TabIndex = 2;
            Label1.Text = "Label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 225);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "handler (important thing dont close it pls)";
            Load += Form1_Load;
            ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal NotifyIcon NotifyIcon1;
        internal Timer Timer1;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal PictureBox PictureBox1;
        internal Label Label1;
    }
}