using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.App;
using Com.Zepfiro.Android.Esptouch;

namespace EspTouchMultiPlatformLIbrary
{
	public class SmartConfigTask_Droid : ISmartConfigTask
	{
		EsptouchTask _task;

		public SmartConfigTask_Droid() { }

		public void SetSmartConfigTask(string ssid, string bssid, string passphrase)
		{
			_task = new EsptouchTask(ssid, bssid, passphrase, Application.Context);
		}

		public void SetSmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden)
		{
			_task = new EsptouchTask(ssid, bssid, passphrase, isHidden, Application.Context);
		}

		public void SetSmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden, int timeoutMillis)
		{
			_task = new EsptouchTask(ssid, bssid, passphrase, isHidden, timeoutMillis, Application.Context);
		}

		public ISmartConfigResult executeForResult()
		{
			if (_task == null)
			{
				return null;
			}
			return new SmartConfigResult_Droid(_task.ExecuteForResult());
		}

		public List<ISmartConfigResult> executeForResults(int expectTaskResultCount)
		{
			if (_task == null)
			{
				return null;
			}
			var results = new List<ISmartConfigResult>();
			foreach (var result in _task.ExecuteForResults(expectTaskResultCount))
			{
				results.Add(new SmartConfigResult_Droid(result as IEsptouchResult));
			};
			return results;
		}
	}
}
