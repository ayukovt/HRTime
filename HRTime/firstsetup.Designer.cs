using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HRTime
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class firstsetup : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstsetup));
            MaterialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            TabPage1 = new TabPage();
            FoxButton1 = new ReaLTaiizor.Controls.FoxButton();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            TabPage2 = new TabPage();
            FoxButton2 = new ReaLTaiizor.Controls.FoxButton();
            ForeverTextBox1 = new ReaLTaiizor.Controls.ForeverTextBox();
            Label5 = new Label();
            Label4 = new Label();
            TabPage3 = new TabPage();
            FoxButton3 = new ReaLTaiizor.Controls.FoxButton();
            DungeonNumeric1 = new ReaLTaiizor.Controls.DungeonNumeric();
            DungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            Label8 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            TabPage4 = new TabPage();
            FoxButton5 = new ReaLTaiizor.Controls.FoxButton();
            FoxButton4 = new ReaLTaiizor.Controls.FoxButton();
            ForeverTextBox2 = new ReaLTaiizor.Controls.ForeverTextBox();
            Label10 = new Label();
            Label9 = new Label();
            TabPage5 = new TabPage();
            FoxButton7 = new ReaLTaiizor.Controls.FoxButton();
            FoxButton6 = new ReaLTaiizor.Controls.FoxButton();
            Label12 = new Label();
            Label11 = new Label();
            TabPage6 = new TabPage();
            FoxButton8 = new ReaLTaiizor.Controls.FoxButton();
            Label14 = new Label();
            Label13 = new Label();
            OpenFileDialog1 = new OpenFileDialog();
            ForeverButton8 = new ReaLTaiizor.Controls.ForeverButton();
            ForeverButton7 = new ReaLTaiizor.Controls.ForeverButton();
            MaterialTabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            TabPage4.SuspendLayout();
            TabPage5.SuspendLayout();
            TabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // MaterialTabControl1
            // 
            MaterialTabControl1.Controls.Add(TabPage1);
            MaterialTabControl1.Controls.Add(TabPage2);
            MaterialTabControl1.Controls.Add(TabPage3);
            MaterialTabControl1.Controls.Add(TabPage4);
            MaterialTabControl1.Controls.Add(TabPage5);
            MaterialTabControl1.Controls.Add(TabPage6);
            MaterialTabControl1.Depth = 0;
            MaterialTabControl1.Location = new Point(12, 12);
            MaterialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MaterialTabControl1.Multiline = true;
            MaterialTabControl1.Name = "MaterialTabControl1";
            MaterialTabControl1.SelectedIndex = 0;
            MaterialTabControl1.Size = new Size(776, 426);
            MaterialTabControl1.TabIndex = 0;
            MaterialTabControl1.TabStop = false;
            // 
            // TabPage1
            // 
            TabPage1.BackColor = Color.FromArgb(24, 20, 30);
            TabPage1.Controls.Add(FoxButton1);
            TabPage1.Controls.Add(Label3);
            TabPage1.Controls.Add(Label2);
            TabPage1.Controls.Add(Label1);
            TabPage1.ForeColor = Color.White;
            TabPage1.Location = new Point(4, 24);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(768, 398);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "TabPage1";
            // 
            // FoxButton1
            // 
            FoxButton1.BackColor = Color.Transparent;
            FoxButton1.BaseColor = Color.FromArgb(42, 32, 59);
            FoxButton1.BorderColor = Color.FromArgb(42, 32, 59);
            FoxButton1.DisabledBaseColor = Color.FromArgb(42, 32, 59);
            FoxButton1.DisabledBorderColor = Color.FromArgb(42, 32, 59);
            FoxButton1.DisabledTextColor = Color.FromArgb(98, 84, 129);
            FoxButton1.DownColor = Color.FromArgb(52, 42, 69);
            FoxButton1.EnabledCalc = true;
            FoxButton1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton1.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton1.Location = new Point(538, 337);
            FoxButton1.Name = "FoxButton1";
            FoxButton1.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton1.Size = new Size(179, 55);
            FoxButton1.TabIndex = 4;
            FoxButton1.Text = "Let's go :3";
            FoxButton1.Click += FoxButton1_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.FromArgb(98, 84, 129);
            Label3.Location = new Point(26, 118);
            Label3.Name = "Label3";
            Label3.Size = new Size(504, 37);
            Label3.TabIndex = 2;
            Label3.Text = "Let's set up a few things first to get you started.";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.FromArgb(98, 84, 129);
            Label2.Location = new Point(26, 88);
            Label2.Name = "Label2";
            Label2.Size = new Size(486, 37);
            Label2.TabIndex = 1;
            Label2.Text = "It seems to be your first time running HRTime.";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Poppins SemiBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.ForeColor = Color.FromArgb(199, 175, 255);
            Label1.Location = new Point(16, 18);
            Label1.Name = "Label1";
            Label1.Size = new Size(173, 84);
            Label1.TabIndex = 0;
            Label1.Text = "Hello!";
            Label1.Click += Label1_Click;
            // 
            // TabPage2
            // 
            TabPage2.BackColor = Color.FromArgb(24, 20, 30);
            TabPage2.Controls.Add(FoxButton2);
            TabPage2.Controls.Add(ForeverTextBox1);
            TabPage2.Controls.Add(Label5);
            TabPage2.Controls.Add(Label4);
            TabPage2.Location = new Point(4, 24);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(768, 398);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "TabPage2";
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
            FoxButton2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton2.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton2.Location = new Point(538, 337);
            FoxButton2.Name = "FoxButton2";
            FoxButton2.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton2.Size = new Size(179, 55);
            FoxButton2.TabIndex = 7;
            FoxButton2.Text = "Next";
            FoxButton2.Click += FoxButton2_Click;
            // 
            // ForeverTextBox1
            // 
            ForeverTextBox1.BackColor = Color.Transparent;
            ForeverTextBox1.BaseColor = Color.FromArgb(42, 32, 59);
            ForeverTextBox1.BorderColor = Color.FromArgb(42, 32, 59);
            ForeverTextBox1.FocusOnHover = false;
            ForeverTextBox1.ForeColor = Color.FromArgb(98, 84, 129);
            ForeverTextBox1.Location = new Point(30, 116);
            ForeverTextBox1.MaxLength = 32767;
            ForeverTextBox1.Multiline = false;
            ForeverTextBox1.Name = "ForeverTextBox1";
            ForeverTextBox1.ReadOnly = false;
            ForeverTextBox1.Size = new Size(206, 29);
            ForeverTextBox1.TabIndex = 6;
            ForeverTextBox1.TextAlign = HorizontalAlignment.Left;
            ForeverTextBox1.UseSystemPasswordChar = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.FromArgb(98, 84, 129);
            Label5.Location = new Point(26, 69);
            Label5.Name = "Label5";
            Label5.Size = new Size(505, 22);
            Label5.TabIndex = 1;
            Label5.Text = "Your name will display in things like the confirmation popup that you took your HRT.";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Poppins SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label4.ForeColor = Color.FromArgb(199, 175, 255);
            Label4.Location = new Point(22, 26);
            Label4.Name = "Label4";
            Label4.Size = new Size(549, 48);
            Label4.TabIndex = 0;
            Label4.Text = "What do you want to be referred to as?";
            // 
            // TabPage3
            // 
            TabPage3.BackColor = Color.FromArgb(24, 20, 30);
            TabPage3.Controls.Add(FoxButton3);
            TabPage3.Controls.Add(DungeonNumeric1);
            TabPage3.Controls.Add(DungeonComboBox1);
            TabPage3.Controls.Add(Label8);
            TabPage3.Controls.Add(Label7);
            TabPage3.Controls.Add(Label6);
            TabPage3.Location = new Point(4, 24);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(768, 398);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "TabPage3";
            // 
            // FoxButton3
            // 
            FoxButton3.BackColor = Color.Transparent;
            FoxButton3.BaseColor = Color.FromArgb(42, 32, 59);
            FoxButton3.BorderColor = Color.FromArgb(42, 32, 59);
            FoxButton3.DisabledBaseColor = Color.FromArgb(42, 32, 59);
            FoxButton3.DisabledBorderColor = Color.FromArgb(42, 32, 59);
            FoxButton3.DisabledTextColor = Color.FromArgb(98, 84, 129);
            FoxButton3.DownColor = Color.FromArgb(52, 42, 69);
            FoxButton3.EnabledCalc = true;
            FoxButton3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton3.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton3.Location = new Point(538, 337);
            FoxButton3.Name = "FoxButton3";
            FoxButton3.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton3.Size = new Size(179, 55);
            FoxButton3.TabIndex = 8;
            FoxButton3.Text = "Next";
            FoxButton3.Click += FoxButton3_Click;
            // 
            // DungeonNumeric1
            // 
            DungeonNumeric1.BackColor = Color.Transparent;
            DungeonNumeric1.BackColorA = Color.FromArgb(42, 32, 59);
            DungeonNumeric1.BackColorB = Color.FromArgb(42, 32, 59);
            DungeonNumeric1.BorderColor = Color.FromArgb(98, 84, 129);
            DungeonNumeric1.ButtonForeColorA = Color.FromArgb(98, 84, 129);
            DungeonNumeric1.ButtonForeColorB = Color.FromArgb(98, 84, 129);
            DungeonNumeric1.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DungeonNumeric1.ForeColor = Color.FromArgb(98, 84, 129);
            DungeonNumeric1.Location = new Point(79, 114);
            DungeonNumeric1.Maximum = 100L;
            DungeonNumeric1.Minimum = 0L;
            DungeonNumeric1.MinimumSize = new Size(93, 28);
            DungeonNumeric1.Name = "DungeonNumeric1";
            DungeonNumeric1.Size = new Size(93, 28);
            DungeonNumeric1.TabIndex = 7;
            DungeonNumeric1.Text = "DungeonNumeric1";
            DungeonNumeric1.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            DungeonNumeric1.Value = 0L;
            // 
            // DungeonComboBox1
            // 
            DungeonComboBox1.BackColor = Color.FromArgb(42, 32, 59);
            DungeonComboBox1.ColorA = Color.FromArgb(52, 42, 69);
            DungeonComboBox1.ColorB = Color.FromArgb(62, 47, 87);
            DungeonComboBox1.ColorC = Color.FromArgb(42, 32, 59);
            DungeonComboBox1.ColorD = Color.FromArgb(42, 32, 59);
            DungeonComboBox1.ColorE = Color.FromArgb(42, 32, 59);
            DungeonComboBox1.ColorF = Color.FromArgb(42, 32, 59);
            DungeonComboBox1.ColorG = Color.FromArgb(98, 84, 129);
            DungeonComboBox1.ColorH = Color.FromArgb(98, 84, 129);
            DungeonComboBox1.ColorI = Color.FromArgb(98, 84, 129);
            DungeonComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            DungeonComboBox1.DropDownHeight = 100;
            DungeonComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            DungeonComboBox1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DungeonComboBox1.ForeColor = Color.FromArgb(98, 84, 129);
            DungeonComboBox1.FormattingEnabled = true;
            DungeonComboBox1.HoverSelectionColor = Color.Empty;
            DungeonComboBox1.IntegralHeight = false;
            DungeonComboBox1.ItemHeight = 20;
            DungeonComboBox1.Items.AddRange(new object[] { "day(s)", "week(s)", "month(s)" });
            DungeonComboBox1.Location = new Point(182, 115);
            DungeonComboBox1.Name = "DungeonComboBox1";
            DungeonComboBox1.Size = new Size(106, 26);
            DungeonComboBox1.StartIndex = 0;
            DungeonComboBox1.TabIndex = 5;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label8.ForeColor = Color.FromArgb(98, 84, 129);
            Label8.Location = new Point(27, 117);
            Label8.Name = "Label8";
            Label8.Size = new Size(43, 22);
            Label8.TabIndex = 2;
            Label8.Text = "every";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.ForeColor = Color.FromArgb(98, 84, 129);
            Label7.Location = new Point(27, 69);
            Label7.Name = "Label7";
            Label7.Size = new Size(294, 22);
            Label7.TabIndex = 1;
            Label7.Text = "don't worry, you can change it later in settings :)";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Poppins SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label6.ForeColor = Color.FromArgb(199, 175, 255);
            Label6.Location = new Point(22, 26);
            Label6.Name = "Label6";
            Label6.Size = new Size(618, 48);
            Label6.TabIndex = 0;
            Label6.Text = "How often do you want the reminder to run?";
            // 
            // TabPage4
            // 
            TabPage4.BackColor = Color.FromArgb(24, 20, 30);
            TabPage4.Controls.Add(FoxButton5);
            TabPage4.Controls.Add(FoxButton4);
            TabPage4.Controls.Add(ForeverTextBox2);
            TabPage4.Controls.Add(Label10);
            TabPage4.Controls.Add(Label9);
            TabPage4.Location = new Point(4, 24);
            TabPage4.Name = "TabPage4";
            TabPage4.Padding = new Padding(3);
            TabPage4.Size = new Size(768, 398);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "TabPage4";
            // 
            // FoxButton5
            // 
            FoxButton5.BackColor = Color.Transparent;
            FoxButton5.BaseColor = Color.FromArgb(42, 32, 59);
            FoxButton5.BorderColor = Color.FromArgb(42, 32, 59);
            FoxButton5.DisabledBaseColor = Color.FromArgb(42, 32, 59);
            FoxButton5.DisabledBorderColor = Color.FromArgb(42, 32, 59);
            FoxButton5.DisabledTextColor = Color.FromArgb(98, 84, 129);
            FoxButton5.DownColor = Color.FromArgb(52, 42, 69);
            FoxButton5.EnabledCalc = true;
            FoxButton5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton5.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton5.Location = new Point(374, 115);
            FoxButton5.Name = "FoxButton5";
            FoxButton5.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton5.Size = new Size(81, 27);
            FoxButton5.TabIndex = 8;
            FoxButton5.Text = "Browse";
            FoxButton5.Click += FoxButton5_Click;
            // 
            // FoxButton4
            // 
            FoxButton4.BackColor = Color.Transparent;
            FoxButton4.BaseColor = Color.FromArgb(42, 32, 59);
            FoxButton4.BorderColor = Color.FromArgb(42, 32, 59);
            FoxButton4.DisabledBaseColor = Color.FromArgb(42, 32, 59);
            FoxButton4.DisabledBorderColor = Color.FromArgb(42, 32, 59);
            FoxButton4.DisabledTextColor = Color.FromArgb(98, 84, 129);
            FoxButton4.DownColor = Color.FromArgb(52, 42, 69);
            FoxButton4.EnabledCalc = true;
            FoxButton4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton4.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton4.Location = new Point(538, 337);
            FoxButton4.Name = "FoxButton4";
            FoxButton4.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton4.Size = new Size(179, 55);
            FoxButton4.TabIndex = 7;
            FoxButton4.Text = "Next";
            FoxButton4.Click += FoxButton4_Click;
            // 
            // ForeverTextBox2
            // 
            ForeverTextBox2.BackColor = Color.Transparent;
            ForeverTextBox2.BaseColor = Color.FromArgb(42, 32, 59);
            ForeverTextBox2.BorderColor = Color.FromArgb(42, 32, 59);
            ForeverTextBox2.FocusOnHover = false;
            ForeverTextBox2.ForeColor = Color.FromArgb(98, 84, 129);
            ForeverTextBox2.Location = new Point(31, 114);
            ForeverTextBox2.MaxLength = 32767;
            ForeverTextBox2.Multiline = false;
            ForeverTextBox2.Name = "ForeverTextBox2";
            ForeverTextBox2.ReadOnly = false;
            ForeverTextBox2.Size = new Size(337, 29);
            ForeverTextBox2.TabIndex = 5;
            ForeverTextBox2.TextAlign = HorizontalAlignment.Left;
            ForeverTextBox2.UseSystemPasswordChar = false;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label10.ForeColor = Color.FromArgb(98, 84, 129);
            Label10.Location = new Point(27, 69);
            Label10.Name = "Label10";
            Label10.Size = new Size(233, 22);
            Label10.TabIndex = 1;
            Label10.Text = "this can also be changed in settings :)";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Poppins", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label9.ForeColor = Color.FromArgb(199, 175, 255);
            Label9.Location = new Point(22, 26);
            Label9.Name = "Label9";
            Label9.Size = new Size(586, 48);
            Label9.TabIndex = 0;
            Label9.Text = "What do you want your alert sound to be?";
            // 
            // TabPage5
            // 
            TabPage5.BackColor = Color.FromArgb(24, 20, 30);
            TabPage5.Controls.Add(FoxButton7);
            TabPage5.Controls.Add(FoxButton6);
            TabPage5.Controls.Add(Label12);
            TabPage5.Controls.Add(Label11);
            TabPage5.Location = new Point(4, 24);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(768, 398);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "TabPage5";
            // 
            // FoxButton7
            // 
            FoxButton7.BackColor = Color.Transparent;
            FoxButton7.BaseColor = Color.FromArgb(42, 32, 59);
            FoxButton7.BorderColor = Color.FromArgb(42, 32, 59);
            FoxButton7.DisabledBaseColor = Color.FromArgb(42, 32, 59);
            FoxButton7.DisabledBorderColor = Color.FromArgb(42, 32, 59);
            FoxButton7.DisabledTextColor = Color.FromArgb(98, 84, 129);
            FoxButton7.DownColor = Color.FromArgb(52, 42, 69);
            FoxButton7.EnabledCalc = true;
            FoxButton7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton7.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton7.Location = new Point(184, 111);
            FoxButton7.Name = "FoxButton7";
            FoxButton7.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton7.Size = new Size(120, 40);
            FoxButton7.TabIndex = 9;
            FoxButton7.Text = "No";
            FoxButton7.Click += FoxButton7_Click;
            // 
            // FoxButton6
            // 
            FoxButton6.BackColor = Color.Transparent;
            FoxButton6.BaseColor = Color.FromArgb(42, 32, 59);
            FoxButton6.BorderColor = Color.FromArgb(42, 32, 59);
            FoxButton6.DisabledBaseColor = Color.FromArgb(42, 32, 59);
            FoxButton6.DisabledBorderColor = Color.FromArgb(42, 32, 59);
            FoxButton6.DisabledTextColor = Color.FromArgb(98, 84, 129);
            FoxButton6.DownColor = Color.FromArgb(52, 42, 69);
            FoxButton6.EnabledCalc = true;
            FoxButton6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton6.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton6.Location = new Point(27, 111);
            FoxButton6.Name = "FoxButton6";
            FoxButton6.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton6.Size = new Size(120, 40);
            FoxButton6.TabIndex = 8;
            FoxButton6.Text = "Yes";
            FoxButton6.Click += FoxButton6_Click;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label12.ForeColor = Color.FromArgb(98, 84, 129);
            Label12.Location = new Point(27, 69);
            Label12.Name = "Label12";
            Label12.Size = new Size(444, 22);
            Label12.TabIndex = 1;
            Label12.Text = "if yes, HRTime will run the updater as soon as a new update gets detected.";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Poppins SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label11.ForeColor = Color.FromArgb(199, 175, 255);
            Label11.Location = new Point(22, 26);
            Label11.Name = "Label11";
            Label11.Size = new Size(652, 48);
            Label11.TabIndex = 0;
            Label11.Text = "Do you want HRTime to automatically update?";
            // 
            // TabPage6
            // 
            TabPage6.BackColor = Color.FromArgb(24, 20, 30);
            TabPage6.Controls.Add(FoxButton8);
            TabPage6.Controls.Add(Label14);
            TabPage6.Controls.Add(Label13);
            TabPage6.Location = new Point(4, 24);
            TabPage6.Name = "TabPage6";
            TabPage6.Padding = new Padding(3);
            TabPage6.Size = new Size(768, 398);
            TabPage6.TabIndex = 5;
            TabPage6.Text = "TabPage6";
            // 
            // FoxButton8
            // 
            FoxButton8.BackColor = Color.Transparent;
            FoxButton8.BaseColor = Color.FromArgb(42, 32, 59);
            FoxButton8.BorderColor = Color.FromArgb(42, 32, 59);
            FoxButton8.DisabledBaseColor = Color.FromArgb(42, 32, 59);
            FoxButton8.DisabledBorderColor = Color.FromArgb(42, 32, 59);
            FoxButton8.DisabledTextColor = Color.FromArgb(98, 84, 129);
            FoxButton8.DownColor = Color.FromArgb(52, 42, 69);
            FoxButton8.EnabledCalc = true;
            FoxButton8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoxButton8.ForeColor = Color.FromArgb(98, 84, 129);
            FoxButton8.Location = new Point(538, 337);
            FoxButton8.Name = "FoxButton8";
            FoxButton8.OverColor = Color.FromArgb(62, 47, 87);
            FoxButton8.Size = new Size(179, 55);
            FoxButton8.TabIndex = 8;
            FoxButton8.Text = "Close";
            FoxButton8.Click += FoxButton8_Click;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label14.ForeColor = Color.FromArgb(98, 84, 129);
            Label14.Location = new Point(27, 69);
            Label14.Name = "Label14";
            Label14.Size = new Size(645, 22);
            Label14.TabIndex = 1;
            Label14.Text = "To change any of the settings, you can access the dashboard by double clicking the icon in the system tray";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Poppins SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label13.ForeColor = Color.FromArgb(199, 175, 255);
            Label13.Location = new Point(22, 26);
            Label13.Name = "Label13";
            Label13.Size = new Size(150, 48);
            Label13.TabIndex = 0;
            Label13.Text = "That's all!";
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "OpenFileDialog1";
            OpenFileDialog1.FileOk += OpenFileDialog1_FileOk;
            // 
            // ForeverButton8
            // 
            ForeverButton8.BackColor = Color.Transparent;
            ForeverButton8.BackgroundImage = (Image)resources.GetObject("ForeverButton8.BackgroundImage");
            ForeverButton8.BaseColor = Color.Transparent;
            ForeverButton8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeverButton8.Location = new Point(675, 2);
            ForeverButton8.Name = "ForeverButton8";
            ForeverButton8.Rounded = false;
            ForeverButton8.Size = new Size(60, 60);
            ForeverButton8.TabIndex = 10;
            ForeverButton8.TextColor = Color.FromArgb(243, 243, 243);
            ForeverButton8.Click += ForeverButton8_Click;
            // 
            // ForeverButton7
            // 
            ForeverButton7.BackColor = Color.Transparent;
            ForeverButton7.BackgroundImage = (Image)resources.GetObject("ForeverButton7.BackgroundImage");
            ForeverButton7.BaseColor = Color.Transparent;
            ForeverButton7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeverButton7.Location = new Point(738, 2);
            ForeverButton7.Name = "ForeverButton7";
            ForeverButton7.Rounded = false;
            ForeverButton7.Size = new Size(60, 60);
            ForeverButton7.TabIndex = 9;
            ForeverButton7.TextColor = Color.FromArgb(243, 243, 243);
            ForeverButton7.Click += ForeverButton7_Click;
            // 
            // firstsetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(ForeverButton8);
            Controls.Add(ForeverButton7);
            Controls.Add(MaterialTabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "firstsetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HRTime First Setup";
            MouseDown += firstsetup_MouseDown;
            MaterialTabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            TabPage4.ResumeLayout(false);
            TabPage4.PerformLayout();
            TabPage5.ResumeLayout(false);
            TabPage5.PerformLayout();
            TabPage6.ResumeLayout(false);
            TabPage6.PerformLayout();
            ResumeLayout(false);
        }

        internal ReaLTaiizor.Controls.MaterialTabControl MaterialTabControl1;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal Label Label1;
        internal Label Label3;
        internal Label Label2;
        internal Label Label4;
        internal Label Label5;
        internal TabPage TabPage3;
        internal TabPage TabPage4;
        internal TabPage TabPage5;
        internal TabPage TabPage6;
        internal Label Label6;
        internal Label Label8;
        internal Label Label7;
        internal ReaLTaiizor.Controls.DungeonComboBox DungeonComboBox1;
        internal ReaLTaiizor.Controls.DungeonNumeric DungeonNumeric1;
        internal Label Label10;
        internal Label Label9;
        internal OpenFileDialog OpenFileDialog1;
        internal Label Label12;
        internal Label Label11;
        internal Label Label14;
        internal Label Label13;
        internal ReaLTaiizor.Controls.ForeverButton ForeverButton8;
        internal ReaLTaiizor.Controls.ForeverButton ForeverButton7;
        internal ReaLTaiizor.Controls.ForeverTextBox ForeverTextBox1;
        internal ReaLTaiizor.Controls.ForeverTextBox ForeverTextBox2;
        internal ReaLTaiizor.Controls.FoxButton FoxButton1;
        internal ReaLTaiizor.Controls.FoxButton FoxButton2;
        internal ReaLTaiizor.Controls.FoxButton FoxButton3;
        internal ReaLTaiizor.Controls.FoxButton FoxButton5;
        internal ReaLTaiizor.Controls.FoxButton FoxButton4;
        internal ReaLTaiizor.Controls.FoxButton FoxButton7;
        internal ReaLTaiizor.Controls.FoxButton FoxButton6;
        internal ReaLTaiizor.Controls.FoxButton FoxButton8;
    }
}