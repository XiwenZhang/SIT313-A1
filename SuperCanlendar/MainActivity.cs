using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using SuperCanlendar;
using Android.Content;
using System.Collections.Generic;


namespace Assignment_1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            Button start = FindViewById<Button>(Resource.Id.start);
            Button about = FindViewById<Button>(Resource.Id.about);
            Button exit = FindViewById<Button>(Resource.Id.exit);

            start.Click += (s, e) =>
            {

                Intent intent = new Intent(this, typeof(SecoundActivity));
                StartActivity(intent);



            };

        }

    }
}