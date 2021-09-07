using MixerClone.Backend;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace McUI
{
    public partial class SoundSelector : Form
    {
        private const string TargetUrl = "https://github.com/OleAlbers/MixerClone";
        private const string Loading = "(Loading, please wait)";
        private const string Disabled = "(disabled) - don't clone output";
        private SoundDevices _soundDevices;
        private Dictionary<Guid, string> _sourceDevices;
        private Dictionary<Guid, string> _targetDevices;

        public SoundSelector()
        {
            InitializeComponent();
            TargetDeviceSelector.Text = Loading;
            SourceDeviceSelector.Text = Loading;
            _soundDevices = new SoundDevices();
        }

        private void RetrieveSoundDevices()
        {
            _targetDevices = _soundDevices.RetrieveAllCardNames();
            _sourceDevices = _soundDevices.RetrieveAllCardNames();
            _sourceDevices.Add(Guid.Empty, Disabled);
            SourceDeviceSelector.DataSource = new BindingSource(_sourceDevices, null);
            TargetDeviceSelector.DataSource = new BindingSource(_targetDevices, null);

            TargetDeviceSelector.SelectedValue = _soundDevices.GetDefaultDeviceId();
            SourceDeviceSelector.SelectedValue = Guid.Empty;
        }


        private void CallGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(TargetUrl);
        }

        private void SoundSelector_Load(object sender, EventArgs e)
        {
            RetrieveSoundDevices();
        }
        private void LoadSettings()
        {
            // TODO: retrieve old settings
        }

        private void SaveSettings()
        {
            // TODO: Save Settings
        }

        private void EnableCloning(Guid source, Guid target)
        {
            // TODO: Throw event
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            var sourceDevice = (Guid)SourceDeviceSelector.SelectedValue;
            var targetDevice = (Guid)TargetDeviceSelector.SelectedValue;

            if (sourceDevice == Guid.Empty)
            {
                SaveSettings();
                MessageBox.Show("Cloning disabled");
                Close();
            }
            SaveSettings();
            EnableCloning(sourceDevice, targetDevice);
            MessageBox.Show("Volume will be cloed");
        }

        private void ComboChanged(object sender, EventArgs e)
        {
            Ok.Enabled = !SourceDeviceSelector.SelectedValue.Equals(TargetDeviceSelector.SelectedValue);
        }
    }
}