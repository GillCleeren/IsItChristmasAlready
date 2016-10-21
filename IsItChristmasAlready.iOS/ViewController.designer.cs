// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IsItChristmasAlready.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CheckChristmasButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ChristmasValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CrashButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SendFeedbackButton { get; set; }

        [Action ("CheckChristmasButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CheckChristmasButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("CrashButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CrashButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("SendFeedbackButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SendFeedbackButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CheckChristmasButton != null) {
                CheckChristmasButton.Dispose ();
                CheckChristmasButton = null;
            }

            if (ChristmasValueLabel != null) {
                ChristmasValueLabel.Dispose ();
                ChristmasValueLabel = null;
            }

            if (CrashButton != null) {
                CrashButton.Dispose ();
                CrashButton = null;
            }

            if (SendFeedbackButton != null) {
                SendFeedbackButton.Dispose ();
                SendFeedbackButton = null;
            }
        }
    }
}