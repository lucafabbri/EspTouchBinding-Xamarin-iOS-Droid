using System;
using System.Diagnostics;
using UIKit;
using EspTouchBinding;

namespace EspTouchBindingExample
{
	public partial class ViewController : UIViewController
	{
		ESPTouchTask ett { get; set; }

		protected ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

        partial void SetEspWiFiTouchUpInside(UIButton sender)
		{
            Console.WriteLine(localssid.Text + localpwd.Text);
			ett = new ESPTouchTask(localssid.Text, localssid.Text, localpwd.Text);
			var result = ett.ExecuteForResult;
			TextArea.Text = result.ToString();
        }
    }
}
