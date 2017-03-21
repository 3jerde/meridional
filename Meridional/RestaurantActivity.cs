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
    [Activity(Label = "Restaurant")]
    public class RestaurantActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.rs0_main);

            var v0btnNext = FindViewById<Button>(Resource.Id.btnRs0Next);
            var v0btnBack = FindViewById<Button>(Resource.Id.btnRs0Back);

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