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
    [Activity(Label = "NotesActivity")]
    public class NotesActivity : Activity
    {


        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.notespage);

            Button save = FindViewById<Button>(Resource.Id.savebtn);
            EditText title = FindViewById<EditText>(Resource.Id.edt1);
            EditText des = FindViewById<EditText>(Resource.Id.edt2);
            TextView data = FindViewById<TextView>(Resource.Id.textdata);

            String datatext1 = Intent.GetStringExtra("data");
            data.Text = datatext1;


            save.Click += (s, e) =>
             {
                 String t = title.Text;
                 String d = des.Text;
                 if (t=="" || d =="")
                 {
                     Toast.MakeText(Android.App.Application.Context, "You did not input Title or Description", ToastLength.Long).Show();

                 }else
                 {
                    
                     Intent i = new Intent(this, typeof(NoteCente));
                     i.PutExtra("title", t);
                     i.PutExtra("des", d);
                     i.PutExtra("date", datatext1);
                     StartActivity(i);


                 }

             };

        }
    }
}