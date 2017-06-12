# EspTouch Binding Library for Xamarin iOS and Android

This is a porting of <a href="https://github.com/EspressifApp/EsptouchForIOS.git">EsptouchForIOS</a> and <a href="https://github.com/EspressifApp/EsptouchForAndroid.git">EsptouchForAndroid</a>

<h2>#XAMARIN IOS</h2>

```csharp
	ESPTouchTask ett = new ESPTouchTask("<SSID>", "<BSSID>", "<PASSPHRASE>");
	var result = ett.ExecuteForResult;
```
      
<h2>#XAMARIN DROID</h2>

```csharp
	EsptouchTask mEsptouchTask = new EsptouchTask("<SSID>", "<BSSID>", "<PASSPHRASE>", true, Application.Context);
	IEsptouchResult result = mEsptouchTask.ExecuteForResult();
```

<h2>#XAMARIN FORMS</h2>

<p>In order to use the library in a Xamarin.Forms project we are going to create an Helper. We will then instantiate it with a specific platform implementation</p>

```csharp
    public interface ISmartConfigHelper
    {
        ISmartConfigTask TaskFactory(string ssid, string bssid, string passphrase);
        ISmartConfigTask TaskFactory(string ssid, string bssid, string passphrase, bool isHidden);
        ISmartConfigTask TaskFactory(string ssid, string bssid, string passphrase, bool isHidden, int timeoutMillis);
    }
```
