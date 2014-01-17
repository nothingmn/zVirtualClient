using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace zVirtualAndroid
{
    [Activity(Label = "zVirtualAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            var log = zVirtual.Connect.Logging.LogManager.GetLogger<Activity1>();
            log.Debug("Hello from androiasdfsdfd");


            //button.Click += delegate { button.Text = string.Format(ConnectMe.Class1.Hello); };
        }
    }
}

