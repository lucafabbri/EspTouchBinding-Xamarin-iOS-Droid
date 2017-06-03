// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace EspTouchBindingExample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField localpwd { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField localssid { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton setbutton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TextArea { get; set; }

        [Action ("SetEspWiFiTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SetEspWiFiTouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (localpwd != null) {
                localpwd.Dispose ();
                localpwd = null;
            }

            if (localssid != null) {
                localssid.Dispose ();
                localssid = null;
            }

            if (setbutton != null) {
                setbutton.Dispose ();
                setbutton = null;
            }

            if (TextArea != null) {
                TextArea.Dispose ();
                TextArea = null;
            }
        }
    }
}