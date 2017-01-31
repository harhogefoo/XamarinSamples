using System;
using UIKit;
using NetworkExtension;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(XamarinSamples.iOS.DeviceState))]
namespace XamarinSamples.iOS
{
    public class DeviceState : IDeviceState
    {
        public DeviceState()
        {
        }

        public bool isNetworkReachable()
        {
            return false;
        }
    }
}
