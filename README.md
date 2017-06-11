# EspTouch Binding Library for Xamarin iOS and Android

This is a porting of <a href="https://github.com/EspressifApp/EsptouchForIOS.git">EsptouchForIOS</a> and <a href="https://github.com/EspressifApp/EsptouchForAndroid.git">EsptouchForAndroid</a>

#XAMARIN IOS

ESPTouchTask ett = new ESPTouchTask("<SSID>", "<BSSID>", "<PASSPHRASE>");
var result = ett.ExecuteForResult;
      
#XAMARIN DROID

EsptouchTask mEsptouchTask = new EsptouchTask("<SSID>", "<BSSID>", "<PASSPHRASE>", true, Application.Context);
IEsptouchResult result = mEsptouchTask.ExecuteForResult();
