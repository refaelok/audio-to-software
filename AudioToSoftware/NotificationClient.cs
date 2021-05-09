using AudioToSoftware.Properties;
using MetroFramework;
using NAudio.CoreAudioApi;
using NAudio.CoreAudioApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioToSoftware
{
    class NotificationClient : IMMNotificationClient
    {
        public Process process;
        public MMDeviceEnumerator enumerator;
        public MainForm mainForm;

        public NotificationClient(MMDeviceEnumerator enumerator, MainForm mainForm)
        {
            this.process = null;
            this.enumerator = enumerator;
            this.mainForm = mainForm;
        }

        private Boolean CheckIfProcessOpened()
        {
            if (process != null && Process.GetProcessesByName(process.ProcessName).Length > 0)
            {
                return true;
            }

            process = null;
            return false;
        }

        private string PrepareFriendlyNameToEqual(string str)
        {
            return String.Concat(str.Where(c => !Char.IsWhiteSpace(c))).Trim().ToLower();
        }

        void IMMNotificationClient.OnDeviceStateChanged(string deviceId, DeviceState newState)
        {
            string audioFriendlyName = Settings.Default.AudioFriendlyName.ToString();
            string softwareLocation = Settings.Default.SoftwareLocation.ToString();

            try
            {
                MMDevice currentDevice = enumerator.GetDevice(deviceId);

                if (PrepareFriendlyNameToEqual(currentDevice.FriendlyName) == PrepareFriendlyNameToEqual(audioFriendlyName))
                {
                    if (newState == DeviceState.Active && !String.IsNullOrEmpty(softwareLocation) && !CheckIfProcessOpened())
                    {
                        process = Process.Start(softwareLocation);
                    }
                    else if (Settings.Default.CloseOnUnplugged && process != null)
                    {
                        try
                        {
                            process.CloseMainWindow();
                            process = null;
                        }
                        catch
                        {
                            process = null;
                        }
                    }
                }
            } catch (Exception e)
            {
                MessageBox.Show(
                    "Some Error Occured when try to open the application. Check your location to Software." + e,
                    "Audio to Software",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        void IMMNotificationClient.OnDeviceAdded(string pwstrDeviceId) { }
        void IMMNotificationClient.OnDeviceRemoved(string deviceId) { }
        void IMMNotificationClient.OnDefaultDeviceChanged(DataFlow flow, Role role, string defaultDeviceId) { }
        void IMMNotificationClient.OnPropertyValueChanged(string pwstrDeviceId, PropertyKey key) { }
    }
}
