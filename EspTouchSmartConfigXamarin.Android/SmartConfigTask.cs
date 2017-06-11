using System;
using System.Collections.Generic;
using Android.Content;
using Com.Zepfiro.Android.Esptouch;

namespace EspTouchSmartConfigXamarin
{
    public class SmartConfigTask : ISmartConfigTask
    {
		EsptouchTask _task;
		public SmartConfigTask(string ssid, string bssid, string passphrase, Context context)
		{
			_task = new EsptouchTask(ssid, bssid, passphrase, context);
		}

		public SmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden, Context context)
		{
			_task = new EsptouchTask(ssid, bssid, passphrase, isHidden, context);
		}

		public SmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden, int timeoutMillis, Context context)
		{
			_task = new EsptouchTask(ssid, bssid, passphrase, isHidden, timeoutMillis, context);
		}

        public ISmartConfigResult executeForResult()
        {
            return new SmartConfigResult(_task.ExecuteForResult());
        }

        public List<ISmartConfigResult> executeForResults(int expectTaskResultCount)
		{
			var results = new List<ISmartConfigResult>();
			foreach (var result in _task.ExecuteForResults(expectTaskResultCount))
			{
                results.Add(new SmartConfigResult(result as IEsptouchResult));
			};
			return results;
        }
    }
}
