using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using EspTouchBinding;
using Foundation;

namespace EspTouchSmartConfigXamarin
{
    public class SmartConfigResult : ISmartConfigResult
	{
        ESPTouchResult _result;
        public SmartConfigResult(ESPTouchResult result)
		{
            _result = result;
        }

        public string getBssid()
        {
            return _result.Bssid;
        }

        public IPAddress getInetAddress()
        {
            return NSDataToIPAddress(_result.IpAddrData);
        }

        public bool isCancelled()
        {
            return _result.IsCancelled;
        }

        public bool isSuc()
        {
            return _result.IsSuc;
        }

		IPAddress NSDataToIPAddress(NSData data)
		{
			byte[] address = null;
			using (MemoryStream ms = new MemoryStream())
			{
				data.AsStream().CopyTo(ms);
				address = ms.ToArray();
			}
			SocketAddress sa = new SocketAddress(AddressFamily.InterNetwork, address.Length);
			// do not overwrite the AddressFamily we provided
			for (int i = 2; i < address.Length; i++)
				sa[i] = address[i];
			IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
			return (ep.Create(sa) as IPEndPoint).Address;
		}
    }
}
