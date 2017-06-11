using System;
using System.Net;
using Com.Zepfiro.Android.Esptouch;

namespace EspTouchSmartConfigXamarin
{
    public class SmartConfigResult : ISmartConfigResult
	{
		IEsptouchResult _result;
		public SmartConfigResult(IEsptouchResult result)
		{
			_result = result;
		}

        public string getBssid()
        {
            return _result.Bssid;
        }

        public byte[] getInetAddress()
        {
            return _result.InetAddress.GetAddress();
        }

        public bool isCancelled()
        {
            return _result.IsCancelled;
        }

        public bool isSuc()
        {
            return _result.IsSuc;
        } 
    }
}
