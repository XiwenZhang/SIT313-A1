using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using SuperCanlendar;
using Android.Content;
namespace SuperCanlendar
{
    [Activity(Label = "Activity2")]
    public class SecoundActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.secondly);


            Button Centre = FindViewById<Button>(Resource.Id.centre);
            Button Exit = FindViewById<Button>(Resource.Id.back);
            Button Notes = FindViewById<Button>(Resource.Id.makenotes);


            Notes.Click += (s, e) =>
            {
                Intent intent = new Intent(this, typeof(Calendar));
                StartActivity(intent);
            };
            Centre.Click += (s, e) =>
            {
                Intent intent = new Intent(this, typeof(NoteCente));
                StartActivity(intent);
            };

        }
    }
}