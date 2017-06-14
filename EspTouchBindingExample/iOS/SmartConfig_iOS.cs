using System;
using EspTouchBindingExample_Forms;
using EspTouchMultiPlatformLIbrary;
using Xamarin.Forms;

[assembly: Dependency(typeof(EspTouchBindingExample_Forms.iOS.SmartConfig_iOS))]
namespace EspTouchBindingExample_Forms.iOS
{
	public class SmartConfig_iOS : ISmartConfigHelper
	{
		public SmartConfig_iOS()
		{
		}

		public ISmartConfigTask CreatePlatformTask()
		{
			return new SmartConfigTask_iOS();
		}
	}
}
