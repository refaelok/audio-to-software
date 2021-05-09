using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioToSoftware
{
    [RunInstaller(true)]
    public partial class AudioToSoftwareInstaller : System.Configuration.Install.Installer
    {
        public AudioToSoftwareInstaller()
        {
            InitializeComponent();
        }

        protected override void OnAfterInstall(IDictionary savedState)
        {
            base.OnAfterInstall(savedState);

            Process.Start(Assembly.GetExecutingAssembly().Location);
        }
    }
}
