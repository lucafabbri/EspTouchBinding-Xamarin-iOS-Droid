using System;
using EspTouchSmartConfigXamarin;

namespace EspTouchBindingExample_Forms
{
    public interface ISmartConfigHelper
	{
		ISmartConfigTask TaskFactory(string ssid, string bssid, string passphrase);
		ISmartConfigTask TaskFactory(string ssid, string bssid, string passphrase, bool isHidden);
		ISmartConfigTask TaskFactory(string ssid, string bssid, string passphrase, bool isHidden, int timeoutMillis);
    }
}
