namespace AudioToSoftware
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.softwareLocationLabel = new MetroFramework.Controls.MetroLabel();
            this.softwareLocationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.softwareLocationButton = new MetroFramework.Controls.MetroButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioFriendlyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.closeOnUnpluggedCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.notifyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Audio Friendly Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(46, 236);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(69, 29);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // softwareLocationLabel
            // 
            this.softwareLocationLabel.AutoSize = true;
            this.softwareLocationLabel.Location = new System.Drawing.Point(46, 133);
            this.softwareLocationLabel.Name = "softwareLocationLabel";
            this.softwareLocationLabel.Size = new System.Drawing.Size(113, 19);
            this.softwareLocationLabel.TabIndex = 4;
            this.softwareLocationLabel.Text = "Software Location";
            // 
            // softwareLocationTextBox
            // 
            // 
            // 
            // 
            this.softwareLocationTextBox.CustomButton.Image = null;
            this.softwareLocationTextBox.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.softwareLocationTextBox.CustomButton.Name = "";
            this.softwareLocationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.softwareLocationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.softwareLocationTextBox.CustomButton.TabIndex = 1;
            this.softwareLocationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.softwareLocationTextBox.CustomButton.UseSelectable = true;
            this.softwareLocationTextBox.CustomButton.Visible = false;
            this.softwareLocationTextBox.Lines = new string[0];
            this.softwareLocationTextBox.Location = new System.Drawing.Point(46, 155);
            this.softwareLocationTextBox.MaxLength = 32767;
            this.softwareLocationTextBox.Name = "softwareLocationTextBox";
            this.softwareLocationTextBox.PasswordChar = '\0';
            this.softwareLocationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.softwareLocationTextBox.SelectedText = "";
            this.softwareLocationTextBox.SelectionLength = 0;
            this.softwareLocationTextBox.SelectionStart = 0;
            this.softwareLocationTextBox.ShortcutsEnabled = true;
            this.softwareLocationTextBox.Size = new System.Drawing.Size(163, 23);
            this.softwareLocationTextBox.TabIndex = 3;
            this.softwareLocationTextBox.UseSelectable = true;
            this.softwareLocationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.softwareLocationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // softwareLocationButton
            // 
            this.softwareLocationButton.Location = new System.Drawing.Point(215, 155);
            this.softwareLocationButton.Name = "softwareLocationButton";
            this.softwareLocationButton.Size = new System.Drawing.Size(68, 23);
            this.softwareLocationButton.TabIndex = 5;
            this.softwareLocationButton.Text = "Browse";
            this.softwareLocationButton.UseSelectable = true;
            this.softwareLocationButton.Click += new System.EventHandler(this.softwareLocationButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Audio to Software";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyMenuStrip
            // 
            this.notifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.notifyMenuStrip.Name = "notifyMenuStrip";
            this.notifyMenuStrip.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // audioFriendlyNameTextBox
            // 
            // 
            // 
            // 
            this.audioFriendlyNameTextBox.CustomButton.Image = null;
            this.audioFriendlyNameTextBox.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.audioFriendlyNameTextBox.CustomButton.Name = "";
            this.audioFriendlyNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.audioFriendlyNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.audioFriendlyNameTextBox.CustomButton.TabIndex = 1;
            this.audioFriendlyNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.audioFriendlyNameTextBox.CustomButton.UseSelectable = true;
            this.audioFriendlyNameTextBox.CustomButton.Visible = false;
            this.audioFriendlyNameTextBox.Lines = new string[0];
            this.audioFriendlyNameTextBox.Location = new System.Drawing.Point(46, 107);
            this.audioFriendlyNameTextBox.MaxLength = 32767;
            this.audioFriendlyNameTextBox.Name = "audioFriendlyNameTextBox";
            this.audioFriendlyNameTextBox.PasswordChar = '\0';
            this.audioFriendlyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.audioFriendlyNameTextBox.SelectedText = "";
            this.audioFriendlyNameTextBox.SelectionLength = 0;
            this.audioFriendlyNameTextBox.SelectionStart = 0;
            this.audioFriendlyNameTextBox.ShortcutsEnabled = true;
            this.audioFriendlyNameTextBox.Size = new System.Drawing.Size(163, 23);
            this.audioFriendlyNameTextBox.TabIndex = 6;
            this.audioFriendlyNameTextBox.UseSelectable = true;
            this.audioFriendlyNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.audioFriendlyNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // closeOnUnpluggedCheckBox
            // 
            this.closeOnUnpluggedCheckBox.AutoSize = true;
            this.closeOnUnpluggedCheckBox.Location = new System.Drawing.Point(46, 193);
            this.closeOnUnpluggedCheckBox.Name = "closeOnUnpluggedCheckBox";
            this.closeOnUnpluggedCheckBox.Size = new System.Drawing.Size(131, 15);
            this.closeOnUnpluggedCheckBox.TabIndex = 7;
            this.closeOnUnpluggedCheckBox.Text = "Close on Unplugged";
            this.closeOnUnpluggedCheckBox.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 302);
            this.Controls.Add(this.closeOnUnpluggedCheckBox);
            this.Controls.Add(this.audioFriendlyNameTextBox);
            this.Controls.Add(this.softwareLocationButton);
            this.Controls.Add(this.softwareLocationLabel);
            this.Controls.Add(this.softwareLocationTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Audio to Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResizeBegin += new System.EventHandler(this.Form_ResizeBegin);
            this.notifyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroLabel softwareLocationLabel;
        private MetroFramework.Controls.MetroTextBox softwareLocationTextBox;
        private MetroFramework.Controls.MetroButton softwareLocationButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox audioFriendlyNameTextBox;
        private System.ServiceProcess.ServiceController serviceController1;
        private MetroFramework.Controls.MetroCheckBox closeOnUnpluggedCheckBox;
    }
}

