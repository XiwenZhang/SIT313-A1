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

    public class Info : Java.Lang.Object
    {
        public string Title { get; set; }//setting title of notes
        public string Date { get; set; }//setting date of notes
        public string Des { get; set; }//setting description of notes

     
    }


}