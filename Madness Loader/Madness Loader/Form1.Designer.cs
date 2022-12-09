namespace Madness_Loader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.frmTheme = new CS_ClassLibraryTester.NYX_Theme();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new CS_ClassLibraryTester.CrystalClearTextBox();
            this.lblBrows = new CS_ClassLibraryTester.NYX_Button();
            this.btnInject = new CS_ClassLibraryTester.NYX_Button();
            this.nyX_ControlBox1 = new CS_ClassLibraryTester.NYX_ControlBox();
            this.nyX_GroupBox1 = new CS_ClassLibraryTester.NYX_GroupBox();
            this.nyX_Button1 = new CS_ClassLibraryTester.NYX_Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.frmTheme.SuspendLayout();
            this.nyX_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmTheme
            // 
            this.frmTheme.Animated = true;
            this.frmTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.frmTheme.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.frmTheme.Controls.Add(this.label1);
            this.frmTheme.Controls.Add(this.txtPath);
            this.frmTheme.Controls.Add(this.lblBrows);
            this.frmTheme.Controls.Add(this.btnInject);
            this.frmTheme.Controls.Add(this.nyX_ControlBox1);
            this.frmTheme.Controls.Add(this.nyX_GroupBox1);
            this.frmTheme.Customization = "";
            this.frmTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmTheme.Font = new System.Drawing.Font("Verdana", 8F);
            this.frmTheme.Image = null;
            this.frmTheme.Location = new System.Drawing.Point(0, 0);
            this.frmTheme.Movable = true;
            this.frmTheme.Name = "frmTheme";
            this.frmTheme.NoRounding = false;
            this.frmTheme.Sizable = false;
            this.frmTheme.Size = new System.Drawing.Size(603, 365);
            this.frmTheme.SmartBounds = true;
            this.frmTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.frmTheme.TabIndex = 4;
            this.frmTheme.Text = "Madness Hack";
            this.frmTheme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.frmTheme.Transparent = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Counter Strike Path (hl.exe)";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPath.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.txtPath.Customization = "";
            this.txtPath.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtPath.Image = null;
            this.txtPath.Location = new System.Drawing.Point(21, 61);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Multiline = false;
            this.txtPath.Name = "txtPath";
            this.txtPath.NoRounding = false;
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(513, 24);
            this.txtPath.TabIndex = 3;
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPath.Transparent = false;
            this.txtPath.UseSystemPasswordChar = false;
            // 
            // lblBrows
            // 
            this.lblBrows.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.lblBrows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBrows.Customization = "";
            this.lblBrows.Font = new System.Drawing.Font("Arial", 8F);
            this.lblBrows.Image = null;
            this.lblBrows.Location = new System.Drawing.Point(540, 61);
            this.lblBrows.Name = "lblBrows";
            this.lblBrows.NoRounding = false;
            this.lblBrows.Size = new System.Drawing.Size(51, 24);
            this.lblBrows.TabIndex = 2;
            this.lblBrows.Text = "...";
            this.lblBrows.Transparent = false;
            this.lblBrows.Click += new System.EventHandler(this.lblBrows_Click);
            // 
            // btnInject
            // 
            this.btnInject.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.btnInject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInject.Customization = "";
            this.btnInject.Font = new System.Drawing.Font("Arial", 8F);
            this.btnInject.Image = null;
            this.btnInject.Location = new System.Drawing.Point(12, 91);
            this.btnInject.Name = "btnInject";
            this.btnInject.NoRounding = false;
            this.btnInject.Size = new System.Drawing.Size(579, 25);
            this.btnInject.TabIndex = 2;
            this.btnInject.Text = "INJECTING";
            this.btnInject.Transparent = false;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // nyX_ControlBox1
            // 
            this.nyX_ControlBox1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_ControlBox1.Customization = "";
            this.nyX_ControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_ControlBox1.Image = null;
            this.nyX_ControlBox1.Location = new System.Drawing.Point(547, 3);
            this.nyX_ControlBox1.Name = "nyX_ControlBox1";
            this.nyX_ControlBox1.NoRounding = false;
            this.nyX_ControlBox1.Size = new System.Drawing.Size(44, 20);
            this.nyX_ControlBox1.TabIndex = 1;
            this.nyX_ControlBox1.Text = "nyX_ControlBox1";
            this.nyX_ControlBox1.Transparent = false;
            // 
            // nyX_GroupBox1
            // 
            this.nyX_GroupBox1.Animated = true;
            this.nyX_GroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.nyX_GroupBox1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_GroupBox1.Controls.Add(this.nyX_Button1);
            this.nyX_GroupBox1.Controls.Add(this.txtLog);
            this.nyX_GroupBox1.Customization = "";
            this.nyX_GroupBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.nyX_GroupBox1.Image = null;
            this.nyX_GroupBox1.Location = new System.Drawing.Point(12, 122);
            this.nyX_GroupBox1.Movable = true;
            this.nyX_GroupBox1.Name = "nyX_GroupBox1";
            this.nyX_GroupBox1.NoRounding = true;
            this.nyX_GroupBox1.Sizable = true;
            this.nyX_GroupBox1.Size = new System.Drawing.Size(579, 231);
            this.nyX_GroupBox1.SmartBounds = true;
            this.nyX_GroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.nyX_GroupBox1.TabIndex = 0;
            this.nyX_GroupBox1.Text = "Log";
            this.nyX_GroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.nyX_GroupBox1.Transparent = false;
            // 
            // nyX_Button1
            // 
            this.nyX_Button1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nyX_Button1.Customization = "";
            this.nyX_Button1.Font = new System.Drawing.Font("Arial", 8F);
            this.nyX_Button1.Image = null;
            this.nyX_Button1.Location = new System.Drawing.Point(528, 0);
            this.nyX_Button1.Name = "nyX_Button1";
            this.nyX_Button1.NoRounding = false;
            this.nyX_Button1.Size = new System.Drawing.Size(45, 18);
            this.nyX_Button1.TabIndex = 5;
            this.nyX_Button1.Text = "C";
            this.nyX_Button1.Transparent = false;
            this.nyX_Button1.Click += new System.EventHandler(this.nyX_Button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(9, 24);
            this.txtLog.MaxLength = 5233223;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(564, 197);
            this.txtLog.TabIndex = 0;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 365);
            this.Controls.Add(this.frmTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Madness Loader";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.frmTheme.ResumeLayout(false);
            this.frmTheme.PerformLayout();
            this.nyX_GroupBox1.ResumeLayout(false);
            this.nyX_GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme frmTheme;
        private CS_ClassLibraryTester.NYX_GroupBox nyX_GroupBox1;
        private CS_ClassLibraryTester.NYX_ControlBox nyX_ControlBox1;
        private CS_ClassLibraryTester.CrystalClearTextBox txtPath;
        private CS_ClassLibraryTester.NYX_Button lblBrows;
        private CS_ClassLibraryTester.NYX_Button btnInject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtLog;
        private CS_ClassLibraryTester.NYX_Button nyX_Button1;
    }
}

