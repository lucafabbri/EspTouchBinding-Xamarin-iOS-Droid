using System;
using System.Collections.Generic;

namespace EspTouchMultiPlatformLIbrary
{
    public interface ISmartConfigTask
	{
		ISmartConfigResult executeForResult();
		List<ISmartConfigResult> executeForResults(int expectTaskResultCount);
		void SetSmartConfigTask(string ssid, string bssid, string passphrase);
		void SetSmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden);
		void SetSmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden, int timeoutMillis);
    }
}
