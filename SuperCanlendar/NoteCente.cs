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
using Java.Util;


namespace SuperCanlendar
{
    [Activity(Label = "NoteCente")]
    public class NoteCente : Activity
    {   
        // names listview and adapter
        public List<Info> notesList;
        public ListView listview;
        public NoteAdapter adapter;
        public List<string> titlelist;
        public List<string> datelist;
        public List<string> deslist;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Listview);


            Button Back = FindViewById<Button>(Resource.Id.back);




            //Initialization data list
            titlelist = new List<string>();
            datelist = new List<string>();
            deslist = new List<string>();

        


            


            notesList = new List<Info>();
            AddNote();

            //set the adapter to list view
            listview = FindViewById<ListView>(Resource.Id.listView1);
            //set the data to adapter
            adapter = new NoteAdapter(this, notesList);
            listview.Adapter = adapter; // set listview data from adapter




            Back.Click += (s, e) =>
            {   //intent jump page
                Intent i = new Intent(this, typeof(SecoundActivity));
                StartActivity(i);
            };


        }

        public void AddNote()
        {   //add the notes to note centre
            //using ISharedPreferences to get data in path 
            // the data path is data/data/supercalendar
            ISharedPreferences sp = this.GetSharedPreferences("abc", FileCreationMode.Private);

            //get the id of each notes the value is size
            int size = sp.GetInt("size", 0);

            //to display every notes on listview
            for(int i = 0; i <= size; i++)
            {   
                string title = sp.GetString("title"+i,"");
                string date = sp.GetString("date" + i, "");
                string des = sp.GetString("des" + i, "");
                Info info = new Info { Title = title, Date = date, Des = des };
                notesList.Add(info);

            }
               
            
        }


     
     

    }
}