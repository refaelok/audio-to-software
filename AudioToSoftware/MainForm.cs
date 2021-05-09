using AudioToSoftware.Properties;
using MetroFramework;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioToSoftware
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MMDeviceEnumerator enumerator;
        delegate void SetAudioListCallback(MMDeviceCollection endpoints);

        public MainForm()
        {
            InitializeComponent();

            if (Settings.Default.IsFirstTimeLoaded)
            {
                Settings.Default.IsFirstTimeLoaded = false;
                Settings.Default.Save();
                WindowState = FormWindowState.Normal;
            } else
            {
                WindowState = FormWindowState.Minimized;
            }

            // Listen to audio connection events
            enumerator = new MMDeviceEnumerator();

            enumerator.RegisterEndpointNotificationCallback(new NotificationClient(enumerator, this));
        }

        private void Form_Load(object sender, EventArgs e)
        {
            audioFriendlyNameTextBox.Text = Settings.Default.AudioFriendlyName.ToString();
            softwareLocationTextBox.Text = Settings.Default.SoftwareLocation.ToString();
            closeOnUnpluggedCheckBox.Checked = Settings.Default.CloseOnUnplugged;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon.Visible = true;
            this.Visible = false;

            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                audioFriendlyNameTextBox.Text = Settings.Default.AudioFriendlyName.ToString();
                softwareLocationTextBox.Text = Settings.Default.SoftwareLocation.ToString();
                closeOnUnpluggedCheckBox.Checked = Settings.Default.CloseOnUnplugged;
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.AudioFriendlyName = audioFriendlyNameTextBox.Text;
            Settings.Default.SoftwareLocation = softwareLocationTextBox.Text;
            Settings.Default.CloseOnUnplugged = closeOnUnpluggedCheckBox.Checked;
            Settings.Default.Save();
            MetroMessageBox.Show(this, "Your changes has been saved.", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Question, 120);
            this.Close();
        }

        private void softwareLocationButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                softwareLocationTextBox.Text = openFileDialog.FileName;
            }
        }

        private void audioFriendlyNameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form_ResizeBegin(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            System.Windows.Forms.Application.Exit();
        }

        private void audioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
