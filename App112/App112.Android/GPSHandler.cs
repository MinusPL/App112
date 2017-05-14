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
using Android.Locations;
using App112.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(GPSHandler))]
namespace App112.Droid
{
    public class GPSHandler : IGPSHandler
    {
        public bool IsGPSEnabled()
        {
            LocationManager _locationManager = (LocationManager)GetContext().GetSystemService(Context.LocationService);
            if (_locationManager.IsProviderEnabled(LocationManager.GpsProvider))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OpenGPSSettings()
        {
            var intent = new Intent(Android.Provider.Settings.ActionLocationSourceSettings);
            intent.SetFlags(ActivityFlags.NewTask);
            GetContext().StartActivity(intent);
            Xamarin.Forms.Application.Current.MainPage = new NavigationPage(new Pages.GPSDisclaimer());
        }

        private static Context GetContext()
        {
            return Android.App.Application.Context;
        }
    }
}