using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SuperCanlendar
{       
    [Activity(Label = "Activity2")]
    public class Calendar : Activity
    {

        String data = null;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.calendar);
            var calendarView = FindViewById<CalendarView>(Resource.Id.calendarView1);
            var text = FindViewById<TextView>(Resource.Id.text);
            var notebtn = FindViewById<Button>(Resource.Id.notebtn);
            text.Text = "Data:  ";

            calendarView.DateChange += (s, e) =>
            {
                int d = e.DayOfMonth;
                int m = e.Month;
                int y = e.Year;
                data = "Data: " + d + "/" + m + "/" + y;
                text.Text = "Data: " + d + "/" + m + "/" + y;
            };

            notebtn.Click += (s, e) =>
            {
                Intent i = new Intent(this, typeof(NotesActivity));

                if (data == null)
                {
                    Toast.MakeText(Android.App.Application.Context, "You did not pick a data for notes", ToastLength.Long).Show();

                }
                else
                {
                    i.PutExtra("data", data);
                    StartActivity(i);
                }
            };
        }
    }
}