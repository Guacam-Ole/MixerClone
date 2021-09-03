using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi.Observables;

using System;
using System.Collections.Generic;

namespace MixerClone
{
    public class SoundDevices
    {
        private CoreAudioController _audioController;
        private CoreAudioDevice _targetDevice;

        public SoundDevices()
        {
            _audioController = new CoreAudioController();
        }

        public Dictionary<Guid, string> RetrieveAllCardNames()
        {
            var allDeviceNames = new Dictionary<Guid, string>();
            var allDevices = _audioController.GetDevices();
            foreach (var device in allDevices)
            {
                allDeviceNames.Add(device.Id, device.FullName);
            }

            return allDeviceNames;
        }

        public void CloneDevice(Guid sourceDeviceId, Guid targetDeviceId)
        {
            _targetDevice = targetDeviceId == Guid.Empty ? _audioController.GetDefaultDevice(DeviceType.Playback, Role.Multimedia) : _audioController.GetDevice(targetDeviceId);

            CloneDevice(_audioController.GetDevice(sourceDeviceId));
        }

        private void CloneDevice(CoreAudioDevice sourceDevice)
        {
            if (sourceDevice == null || _targetDevice == null) throw new Exception("Cannot find device (wrong guid)");
            if (sourceDevice == _targetDevice) throw new Exception("Will not allow for the universe to explode (source=target");
            sourceDevice.VolumeChanged.Subscribe(VolumeChanged);
        }

        private void VolumeChanged(DeviceVolumeChangedArgs volumeChangedArgs)
        {
            _targetDevice.Volume = volumeChangedArgs.Volume;
        }
    }
}

// HeadSet: f536f0af-8645-4446-a9a7-cea066cbcb57
// LG: b63196fe-f158-4751-a300-e89d90173a43

// HeadSet: f536f0af-8645-4446-a9a7-cea066cbcb57 b63196fe-f158-4751-a300-e89d90173a43