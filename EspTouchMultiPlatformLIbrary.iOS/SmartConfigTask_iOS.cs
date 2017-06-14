using System;
using System.Collections.Generic;
using EspTouchBinding;

namespace EspTouchMultiPlatformLIbrary
{
	public class SmartConfigTask_iOS : ISmartConfigTask
	{
		ESPTouchTask _task { get; set; }
		public SmartConfigTask_iOS() { }
		public void SetSmartConfigTask(string ssid, string bssid, string passphrase)
		{
			_task = new ESPTouchTask(ssid, bssid, passphrase);
		}

		public void SetSmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden)
		{
			_task = new ESPTouchTask(ssid, bssid, passphrase, isHidden);
		}

		public void SetSmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden, int timeoutMillis)
		{
			_task = new ESPTouchTask(ssid, bssid, passphrase, isHidden, timeoutMillis);
		}

		public ISmartConfigResult executeForResult()
		{
			return new SmartConfigResult_iOS(_task.ExecuteForResult);
		}

		public List<ISmartConfigResult> executeForResults(int expectTaskResultCount)
		{
			var results = new List<ISmartConfigResult>();
			foreach (var result in _task.ExecuteForResults(expectTaskResultCount))
			{
				results.Add(new SmartConfigResult_iOS(result as ESPTouchResult));
			};
			return results;
		}
	}
}
