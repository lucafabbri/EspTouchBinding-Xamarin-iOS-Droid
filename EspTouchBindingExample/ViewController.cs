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
			ett = new ESPTouchTask("Batcave", "Batcave", "elleeffe");
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var result = ett.ExecuteForResult;
			Debug.WriteLine(result.ToString());
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
