using System;
using System.Net;

namespace EspTouchSmartConfigXamarin
{
    public interface ISmartConfigResult
	{

		/**
		 * check whether the esptouch task is executed suc
		 * 
		 * @return whether the esptouch task is executed suc
		 */
		bool isSuc();

		/**
		 * get the device's bssid
		 * 
		 * @return the device's bssid
		 */
		String getBssid();

		/**
		 * check whether the esptouch task is cancelled by user
		 * 
		 * @return whether the esptouch task is cancelled by user
		 */
		bool isCancelled();

		/**
		 * get the ip address of the device
		 * 
		 * @return the ip device of the device
		 */
		IPAddress getInetAddress();
    }
}
