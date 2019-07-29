using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;

namespace SuperCanlendar
{
    [Activity(Label = "NoteCentreActivity")]
    public class NoteCentreActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            var NoteTitle = Intent.Extras.GetStringArrayList("title") ?? new string[0];
            var NoteDes = Intent.Extras.GetStringArrayList("des") ?? new string[0];
            var NoteData = Intent.Extras.GetStringArrayList("data") ?? new string[0];
            this.ListAdapter = new ArrayAdapter<string>(this,
            Android.Resource.Layout.SimpleListItem1, NoteTitle);

        }
    }
}