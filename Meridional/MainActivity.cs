using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Meridional
{
    [Activity(Label = "Meridional", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var btnHotel = FindViewById<Button>(Resource.Id.btnHotel);
            var btnRestaurant = FindViewById<Button>(Resource.Id.btnRestaurant);

            btnHotel.Click += (s, e) =>
            {
                Intent hotelActivityStart = new Intent(this, typeof(HotelActivity));
                StartActivity(hotelActivityStart);
            };

            btnRestaurant.Click += (s, e) =>
            {
                Intent restaurantActivityStart = new Intent(this, typeof(RestaurantActivity));
                StartActivity(restaurantActivityStart);
            };


        }
    }
}

