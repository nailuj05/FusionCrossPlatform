using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace FusionCrossPlatform
{
    public enum Platform
    {
        Vive,
        Index,
        Rift,
        RiftS,
        Quest,
        Quest2,
        WMR,

    }

    public class PlatformHandler : MonoBehaviour
    {
        void OnEnable()
        {
            InputDevices.deviceConnected += DeviceConnected;
            List<InputDevice> devices = new List<InputDevice>();
            InputDevices.GetDevices(devices);
            foreach (var device in devices)
                DeviceConnected(device);
        }

        void OnDisable()
        {
            InputDevices.deviceConnected -= DeviceConnected;
        }

        void DeviceConnected(InputDevice device)
        {
            // The Left Hand
            if ((device.characteristics & InputDeviceCharacteristics.Left) != 0)
            {
                print(device.name);
            }
            // The Right hand
            else if ((device.characteristics & InputDeviceCharacteristics.Right) != 0)
            {
                print(device.name);
            }
        }
    }
}