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


        static readonly List<string> NoteTitle = new List<string>();
        static readonly List<string> NoteDes = new List<string>();
        static readonly List<string> NoteData = new List<string>();

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
                     NoteTitle.Add(t);
                     NoteDes.Add(d);
                     NoteData.Add(datatext1);
                     Intent i = new Intent(this, typeof(NoteCentreActivity));
                     i.PutStringArrayListExtra("title", NoteTitle);
                     i.PutStringArrayListExtra("des", NoteDes);
                     i.PutStringArrayListExtra("data", NoteData);
                     StartActivity(i);


                 }

             };

        }
    }
}