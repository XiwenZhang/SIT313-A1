using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace SuperCanlendar
{
    [Activity(Label = "NotesActivity")]
    public class NotesActivity : Activity
    {
        public List<string> titlelist;
        public List<string> datelist;
        public List<string> deslist;
        int size = -1;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.notespage);


            //get the size index
            ISharedPreferences sp = this.GetSharedPreferences("abc", FileCreationMode.Private);
            size = sp.GetInt("size", 0);
           







            //find control 
            Button save = FindViewById<Button>(Resource.Id.savebtn);
            EditText title = FindViewById<EditText>(Resource.Id.edt1);
            EditText des = FindViewById<EditText>(Resource.Id.edt2);
            TextView data = FindViewById<TextView>(Resource.Id.textdata);

            String datatext1 = Intent.GetStringExtra("data");
            data.Text = datatext1;

            


            //Button on click
            save.Click += (s, e) =>
             {
                 String t = title.Text;
                 String d = des.Text;
                 if (t=="" || d =="")
                 {  //makte toast for didnt save notes
                     Toast.MakeText(Android.App.Application.Context, "You did not input Title or Description", ToastLength.Long).Show();

                 }else
                 {
                     //save data 
                     sp = this.GetSharedPreferences("abc", FileCreationMode.Private);
                     ISharedPreferencesEditor editor = sp.Edit();

                     size++;
                     editor.PutInt("size", size);
                     editor.PutString("title"+size, t);
                     editor.PutString("date"+size, datatext1);
                     editor.PutString("des"+size, d);

                     editor.Apply();




                     //Intent page 
                     Intent i = new Intent(this, typeof(NoteCente));

                     StartActivity(i);


                 }

             };

        }


            


      

    }
}