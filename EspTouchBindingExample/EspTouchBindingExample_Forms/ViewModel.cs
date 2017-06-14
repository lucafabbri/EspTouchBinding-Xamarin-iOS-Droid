using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EspTouchMultiPlatformLIbrary;
using Xamarin.Forms;

namespace EspTouchBindingExample_Forms
{
    public class ViewModel : INotifyPropertyChanged
	{
		String _ssid, _bssid, _passphrase, _message;
		public String Ssid { get { return _ssid; } set { _ssid = value; NotifyPropertyChanged(); } }
		//public String Bssid { get { return _bssid; } set { _bssid = value; NotifyPropertyChanged(); } }
		public String Passphrase { get { return _passphrase; } set { _passphrase = value; NotifyPropertyChanged(); } }
		public String Message { get { return _message; } set { _message = value; NotifyPropertyChanged(); } }

		ISmartConfigTask smartconfig;

		public ViewModel()
		{
			smartconfig = DependencyService.Get<ISmartConfigHelper>().CreatePlatformTask();
		}

		public async Task ConfigDevice()
		{
			smartconfig.SetSmartConfigTask(Ssid, Ssid, Passphrase);
			Message = "running configuration";
			await Task.Run(() =>
			{
				var result = smartconfig.executeForResult();
				Message = Message + "Device address set up: " + result.getInetAddress() + "\r\n";
			});
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
    }
}

