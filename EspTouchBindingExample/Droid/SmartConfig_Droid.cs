using System;
using EspTouchMultiPlatformLIbrary;
using Xamarin.Forms;

[assembly: Dependency(typeof(EspTouchBindingExample_Forms.Droid.SmartConfig_Droid))]
namespace EspTouchBindingExample_Forms.Droid
{
	public class SmartConfig_Droid:ISmartConfigHelper
	{
		public SmartConfig_Droid()
		{
		}

		public ISmartConfigTask CreatePlatformTask()
		{
			return new SmartConfigTask_Droid();
		}
	}
}
