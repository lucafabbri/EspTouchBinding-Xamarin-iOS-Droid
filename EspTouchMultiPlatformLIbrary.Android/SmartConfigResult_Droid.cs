using Com.Zepfiro.Android.Esptouch;

namespace EspTouchMultiPlatformLIbrary
{
    internal class SmartConfigResult_Droid : ISmartConfigResult
    {
        private IEsptouchResult esptouchResult;

        public SmartConfigResult_Droid(IEsptouchResult esptouchResult)
        {
            this.esptouchResult = esptouchResult;
		}

		public string getBssid()
		{
			return esptouchResult.Bssid;
		}

		public string getInetAddress()
		{
			return esptouchResult.InetAddress.HostAddress;
		}

		public bool isCancelled()
		{
			return esptouchResult.IsCancelled;
		}

		public bool isSuc()
		{
			return esptouchResult.IsSuc;
		}
    }
}