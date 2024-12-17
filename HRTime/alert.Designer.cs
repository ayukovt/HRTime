using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HRTime
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class alert : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(alert));
            Panel1 = new Panel();
            PictureBox1 = new PictureBox();
            MoonLabel1 = new ReaLTaiizor.Controls.MoonLabel();
            FoxButton2 = new ReaLTaiizor.Controls.FoxButton();
            FoxButton2.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(FoxButton2_Click);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(17, 15, 22);
            Panel1.Controls.Add(PictureBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(117, 117);
            Panel1.TabIndex = 0;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(0, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(117, 117);
            PictureBox1.TabIndex = 2;
            PictureBox1.TabStop = false;
            // 
            // MoonLabel1
            // 
            MoonLabel1.AutoSize = true;
            MoonLabel1.BackColor = Color.Transparent;
            MoonLabel1.Font = new Font("Poppins", 15.75f, FontStyle.Bold, GraphicsUnit.Point);
            MoonLabel1.ForeColor = Color.FromArgb(199, 175, 255);
            MoonLabel1.Location = new Point(136, 25);
            MoonLabel1.Name = "MoonLabel1";
            MoonLabel1.Size = new Size(254, 37);
            MoonLabel1.TabIndex = 1;
            MoonLabel1.Text = "Time to take your HRT!";
            // 
            // FoxButton2
            // 
            FoxButton2.BackColor = Color.Transparent;
            FoxButton2.BaseColor = Color.FromArgb(42, 32, 59);
            FoxButton2.BorderColor = Color.FromArgb(42, 32, 59);
            FoxButton2.DisabledBaseColor = Color.FromArgb(42, 32, 59);
            FoxButton2.DisabledBorderColor = Color.FromArgb(42, 32, 59);
            FoxButton2.DisabledTextColor = Color.FromArgb(98, 84, 129);
            FoxButton2.DownColor = Color.FromArgb(52, 42, 69);
            FoxButton2.EnabledCalc = true;
            FoxButton2.Font = new Font("Poppins", 9.75f, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton2.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton2.Location = new Point(144, 65);
            FoxButton2.Name = "FoxButton2";
            FoxButton2.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton2.Size = new Size(92, 24);
            FoxButton2.TabIndex = 3;
            FoxButton2.Text = "Okay";
            // 
            // alert
            // 
            AutoScaleDimensions = new SizeF(7f, 15f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 19, 29);
            ClientSize = new Size(477, 117);
            Controls.Add(FoxButton2);
            Controls.Add(MoonLabel1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "alert";
            StartPosition = FormStartPosition.Manual;
            Text = "alert";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(alert_Load);
            Closed += new EventHandler(alert_Close);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel1;
        internal ReaLTaiizor.Controls.MoonLabel MoonLabel1;
        internal PictureBox PictureBox1;
        internal ReaLTaiizor.Controls.FoxButton FoxButton2;
    }
}