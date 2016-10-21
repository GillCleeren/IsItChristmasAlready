using System;
using Android.App;
using Android.Widget;
using Android.OS;
using HockeyApp;
using HockeyApp.Android;
using IsItChristmasAlready.Core;
using CrashManager = HockeyApp.Android.CrashManager;

namespace IsItChristmasAlready.Droid
{
    [Activity(Label = "Is it Christmas Already", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button _checkChristmasButton;
        private TextView _christmasValueTextView;
        private Button _feedbackButton;
        private Button _crashButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            _checkChristmasButton = FindViewById<Button>(Resource.Id.CheckChristmasButton);
            _christmasValueTextView = FindViewById<TextView>(Resource.Id.ChristmasValueTextView);
            _feedbackButton = FindViewById<Button>(Resource.Id.FeedbackButton);
            _crashButton = FindViewById<Button>(Resource.Id.CrashButton);

            _checkChristmasButton.Click += PerformChristmasCheck;
            _feedbackButton.Click += _feedbackButton_Click;
            _crashButton.Click += _crashButton_Click;

            CrashManager.Register(this, "076aa68d75fe492099bd0413f6ea975c");

            //Alternative way of registering the app
            //CrashManager.Register(this);

            CheckForUpdates();

            MetricsManager.TrackEvent("App started");
        }

        private void _crashButton_Click(object sender, EventArgs e)
        {
            throw new ApplicationException("Things went down the drain...");
        }

        private void _feedbackButton_Click(object sender, EventArgs e)
        {
            FeedbackManager.ShowFeedbackActivity(ApplicationContext);
        }

        private void CheckForUpdates()
        {
            UpdateManager.Register(this, "076aa68d75fe492099bd0413f6ea975c");
        }

        private void PerformChristmasCheck(object sender, EventArgs e)
        {
            var christmasService = new ChristmasService();

            _christmasValueTextView.Text = christmasService.IsItChristmasToday(DateTime.Today) ? "It's Christmas!" : "Not yet... Sorry!";

            MetricsManager.TrackEvent("Christmas Date Checked");
        }

        protected override void OnPause()
        {
            base.OnPause();
            UnregisterManagers();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            UnregisterManagers();
        }

        private void UnregisterManagers()
        {
            UpdateManager.Unregister();
            
        }
    }
}

