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
    public class NoteAdapter : BaseAdapter
    {

         List<Info> Notes ;
         Activity Con;
        private LayoutInflater mInflater;
        public NoteAdapter(Activity context, List<Info> items)
        {
            this.Notes = items;//get the data from Intent transmission
            this.Con = context;
            this.mInflater = LayoutInflater.From(context);
        }
        public override int Count
        {
            get
            {
                return Notes.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return Notes[position];
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            StuView stuview;
            if (convertView == null)
            {
                stuview = new StuView();
                //find the layout we need
                convertView = mInflater.Inflate(Resource.Layout.Nadapter, null);
                //bound Controler
                stuview.title = convertView.FindViewById<TextView>(Resource.Id.titleview);
                stuview.date = convertView.FindViewById<TextView>(Resource.Id.dateview);
                stuview.des = convertView.FindViewById<TextView>(Resource.Id.desview);

                //setting the text of each textview
                stuview.title.Text = Notes[position].Title;
                stuview.date.Text = Notes[position].Date;
                stuview.des.Text = Notes[position].Des;
                convertView.Tag = stuview;
            }
            else
            {
                stuview = (StuView)convertView.Tag;
            }
            return convertView;
        }
        //setting the control 
        public class StuView : Java.Lang.Object
        {
            public TextView title;
            public TextView date;
            public TextView des;
        }

    }
}