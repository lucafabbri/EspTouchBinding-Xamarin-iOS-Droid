using System;

namespace EspTouchMultiPlatformLIbrary
{
    public interface ISmartConfigResult
	{
		bool isSuc();
		String getBssid();
		bool isCancelled();
		string getInetAddress();
    }
}