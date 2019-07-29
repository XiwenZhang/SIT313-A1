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
        public List<Info> notesList;//定义一个列表
        public ListView listview;//定义控件
        public NoteAdapter adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Listview);

            notesList = new List<Info>();
            AddNote();
            listview = FindViewById<ListView>(Resource.Id.listView1);
            adapter = new NoteAdapter(this, notesList);
            listview.Adapter = adapter; // set listview data from adapter



        }

        public void AddNote()
        {
            var title = Intent.GetStringExtra("title");
            var date = Intent.GetStringExtra("date");
            var des = Intent.GetStringExtra("des");

            
                Info i = new Info { Title = title, Date = date , Des = des};

                notesList.Add(i);
               
            
        }
    }
}