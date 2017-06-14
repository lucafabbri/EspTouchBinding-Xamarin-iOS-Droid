# EspTouch Binding Library for Xamarin iOS and Android

This is a porting of [EsptouchForIOS](https://github.com/EspressifApp/EsptouchForIOS.git) and [EsptouchForAndroid](https://github.com/EspressifApp/EsptouchForAndroid.git)

# INSTALL

Please use NuGet to installa the library in your Xamarin.iOS, Xamarin.Droid or Xamarin.Forms project. This Library does not support Windows Phone yet.

```nuget
Install-Package EspTouchSmartConfigXamarin
```
# USE

## XAMARIN FORMS

You need to use Dependency Service to get a Platform specific implementation of the SmartConfigTask

### PCL Project
Define the Interface

```csharp
public interface ISmartConfigHelper
{
	ISmartConfigTask CreatePlatformTask();
}
```

### IOS Project

```csharp
using System;
using EspTouchBindingExample_Forms;
using EspTouchMultiPlatformLIbrary;
using Xamarin.Forms;

[assembly: Dependency(typeof(EspTouchBindingExample_Forms.iOS.SmartConfig_iOS))]
namespace EspTouchBindingExample_Forms.iOS
{
	public class SmartConfig_iOS : ISmartConfigHelper
	{
		public SmartConfig_iOS()
		{
		}

		public ISmartConfigTask CreatePlatformTask()
		{
			return new SmartConfigTask_iOS();
		}
	}
}
```

### ANDROID Project

```csharp
using System;
using EspTouchMultiPlatformLIbrary;
using Xamarin.Forms;

[assembly: Dependency(typeof(EspTouchBindingExample_Forms.Droid.SmartConfig_Droid))]
namespace EspTouchBindingExample_Forms.Droid
{
	public class SmartConfig_Droid:ISmartConfigHelper
	{
		public SmartConfig_Droid()
		{
		}

		public ISmartConfigTask CreatePlatformTask()
		{
			return new SmartConfigTask_Droid();
		}
	}
}
```

### Instantiate the ISmartConfigTask and use it

You can now instantiate the class in your code (code behind or viewmodel)

```csharp
String Ssid = "network ssid";
String Bssid = "network bssid";
String Passphrase = "network passphrase"

ISmartConfigTask smartconfig;
smartconfig = DependencyService.Get<ISmartConfigHelper>().CreatePlatformTask();
smartconfig.SetSmartConfigTask(Ssid, Bssid, Passphrase);
await Task.Run(() =>
{
	var result = smartconfig.executeForResult();
	//handle your result
});

```
-------------
## USING IN SINGLE PROJECTS

### XAMARIN IOS

```csharp
ESPTouchTask ett = new ESPTouchTask("<SSID>", "<BSSID>", "<PASSPHRASE>");
var result = ett.ExecuteForResult;
```
      
### XAMARIN DROID

```csharp
EsptouchTask mEsptouchTask = new EsptouchTask("<SSID>", "<BSSID>", "<PASSPHRASE>", true, Application.Context);
IEsptouchResult result = mEsptouchTask.ExecuteForResult();
```
