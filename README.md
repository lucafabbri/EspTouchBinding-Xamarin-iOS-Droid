# EspTouch Binding Library for Xamarin iOS and Android

This is a porting of [EsptouchForIOS](https://github.com/EspressifApp/EsptouchForIOS.git) and [EsptouchForAndroid](https://github.com/EspressifApp/EsptouchForAndroid.git)

## XAMARIN IOS

```csharp
    ESPTouchTask ett = new ESPTouchTask("<SSID>", "<BSSID>", "<PASSPHRASE>");
    var result = ett.ExecuteForResult;
```
      
## XAMARIN DROID

```csharp
    EsptouchTask mEsptouchTask = new EsptouchTask("<SSID>", "<BSSID>", "<PASSPHRASE>", true, Application.Context);
    IEsptouchResult result = mEsptouchTask.ExecuteForResult();
```
