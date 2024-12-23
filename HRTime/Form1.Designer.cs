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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PictureBox1 = new PictureBox();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Location = new Point(-1, 1);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(629, 226);
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 18);
            Label1.Name = "Label1";
            Label1.Size = new Size(570, 15);
            Label1.TabIndex = 2;
            Label1.Text = "if you see this, i fucked smth up bc this shouldnt run in bg it literally shoud run checks on startup and close\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 225);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "handler";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox PictureBox1;
        internal Label Label1;
    }
}