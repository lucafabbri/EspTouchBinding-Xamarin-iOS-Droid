using System;
using System.Collections.Generic;
using EspTouchBinding;

namespace EspTouchSmartConfigXamarin
{
    public class SmartConfigTask:ISmartConfigTask
	{
		ESPTouchTask _task { get; set; }
		public SmartConfigTask(string ssid, string bssid, string passphrase)
		{
			_task = new ESPTouchTask(ssid, bssid, passphrase);
		}

		public SmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden)
		{
            _task = new ESPTouchTask(ssid, bssid, passphrase, isHidden);
		}

		public SmartConfigTask(string ssid, string bssid, string passphrase, bool isHidden, int timeoutMillis)
		{
            _task = new ESPTouchTask(ssid, bssid, passphrase, isHidden, timeoutMillis);
		}

        public ISmartConfigResult executeForResult()
        {
            return new SmartConfigResult(_task.ExecuteForResult);
        }

        public List<ISmartConfigResult> executeForResults(int expectTaskResultCount)
		{
            var results = new List<ISmartConfigResult>();
            foreach(var result in _task.ExecuteForResults(expectTaskResultCount)){
                results.Add(new SmartConfigResult(result as ESPTouchResult));
            };
			return results;
        }
    }
}
