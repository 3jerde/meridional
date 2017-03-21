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

namespace Meridional
{
    [Activity(Label = "Hotel")]
    public class HotelActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.hs0_main);

            var v0btnNext = FindViewById<Button>(Resource.Id.btnHs0Next);
            var v0btnBack = FindViewById<Button>(Resource.Id.btnHs0Back);

            v0btnNext.Click += (s, e) =>
            {
                //SetContentView(Resource.Layout.hs1_rcp);
            };
            v0btnBack.Click += delegate
            {
                this.Finish();
            };
        }
    }
}