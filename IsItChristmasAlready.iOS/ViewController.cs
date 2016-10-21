using System;
using HockeyApp.iOS;
using IsItChristmasAlready.Core;
using UIKit;

namespace IsItChristmasAlready.iOS
{
    public partial class ViewController : UIViewController
    {
		private BITMetricsManager _bitMatricsManager;
		private BITUpdateManager _bitUpdateManager;

        public ViewController(IntPtr handle) : base(handle)
        {
			_bitMatricsManager = BITHockeyManager.SharedHockeyManager.MetricsManager;
			_bitUpdateManager = BITHockeyManager.SharedHockeyManager.UpdateManager;
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			_bitMatricsManager.TrackEvent ("Main controller loaded");

			CheckForUpdates ();
        }

		void CheckForUpdates ()
		{
			_bitUpdateManager.CheckForUpdate ();
		}

		public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

		partial void CheckChristmasButton_TouchUpInside (UIButton sender)
		{
			var christmasService = new ChristmasService ();

			ChristmasValueLabel.Text = christmasService.IsItChristmasToday (DateTime.Today) ? "It's Christmas!" : "Not yet... Sorry!";
			_bitMatricsManager.TrackEvent ("Check button used");

		}

		partial void CrashButton_TouchUpInside (UIButton sender)
		{
			throw new ApplicationException ("Things went down the drain...");
		}

		partial void SendFeedbackButton_TouchUpInside (UIButton sender)
		{
			var feedbackManager = BITHockeyManager.SharedHockeyManager.FeedbackManager;

			// Send new feedback
			feedbackManager.ShowFeedbackComposeView ();
		}
	}
}