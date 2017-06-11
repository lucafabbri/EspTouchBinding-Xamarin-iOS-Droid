using Android.App;
using Android.Widget;
using Android.OS;
using Com.Zepfiro.Android.Esptouch;
using System;
using System.Threading.Tasks;
using System.Threading;
using Android.Net;
using Android.Net.Wifi;

namespace EspTouchBindingExample_Droid
{
    [Activity(Label = "EspTouchBindingExample_Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

		private IEsptouchTask mEsptouchTask;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

			Button setespbutton = FindViewById<Button>(Resource.Id.setesp);
			Button cancelbutton = FindViewById<Button>(Resource.Id.cancel);
            EditText ssidtext = FindViewById<EditText>(Resource.Id.ssid);
			EditText passwordtext = FindViewById<EditText>(Resource.Id.password);
			TextView textareamessage = FindViewById<TextView>(Resource.Id.textarea);
			TextView wifitextview = FindViewById<TextView>(Resource.Id.wifitext);

			WifiManager wifiManager = (WifiManager)(Application.Context.GetSystemService(Android.Content.Context.WifiService));
            bool isOnline = wifiManager.IsWifiEnabled;


			setespbutton.Enabled = isOnline;
            ssidtext.Enabled = isOnline;
            passwordtext.Enabled = isOnline;
            textareamessage.Enabled = isOnline;
            wifitextview.Visibility = (isOnline)?Android.Views.ViewStates.Invisible:Android.Views.ViewStates.Visible;

            ssidtext.Text = wifiManager.ConnectionInfo.SSID;

			setespbutton.Click += async delegate {
				setespbutton.Enabled = false;
                await Task.Run(() =>
				{
                    Console.WriteLine(wifiManager.ConnectionInfo.SSID.Replace("\"", ""));
                    Console.WriteLine(wifiManager.ConnectionInfo.BSSID);
                    mEsptouchTask = new EsptouchTask(wifiManager.ConnectionInfo.SSID.Replace("\"",""), wifiManager.ConnectionInfo.BSSID, passwordtext.Text, true, Application.Context);
					try
					{
						IEsptouchResult result = mEsptouchTask.ExecuteForResult();
						if (result.IsSuc)
						{
							textareamessage.Text = "BSSID: " + result.Bssid + " IP: " + result.InetAddress;
						}
						else
						{
							textareamessage.Text = "failed";
						}
                    }catch(Exception e){
                        Console.WriteLine(e.StackTrace);
                    }
                });
            };
        }
    }

}

