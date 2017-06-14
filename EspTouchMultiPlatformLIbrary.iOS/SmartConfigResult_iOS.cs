using System;
using System.IO;
using System.Net;
using EspTouchBinding;

namespace EspTouchMultiPlatformLIbrary
{
    internal class SmartConfigResult_iOS : ISmartConfigResult
    {
        private ESPTouchResult eSPTouchResult;

        public SmartConfigResult_iOS(ESPTouchResult eSPTouchResult)
        {
            this.eSPTouchResult = eSPTouchResult;
		}

		public string getBssid()
		{
			return eSPTouchResult.Bssid;
		}

		public string getInetAddress()
		{
			string address = String.Empty;
			using (MemoryStream ms = new MemoryStream())
			{
				eSPTouchResult.IpAddrData.AsStream().CopyTo(ms);
				IPAddress ipaddres = new IPAddress(ms.ToArray());
				address = ipaddres.ToString();
			}
			return address;
		}

		public bool isCancelled()
		{
			return eSPTouchResult.IsCancelled;
		}

		public bool isSuc()
		{
			return eSPTouchResult.IsSuc;
		}
    }
}