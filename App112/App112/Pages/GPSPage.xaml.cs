using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App112.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GPSPage : ContentPage
    {
        public GPSPage()
        {
            InitializeComponent();
            //dataCoords.Text = "KURWA JEGO MAć PIERDOLONA";
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            { 
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;               
                var position = await locator.GetPositionAsync(timeoutMilliseconds: 50000);

                dataCoords.Text = string.Format("LATT: {0}, LONT: {1}", position.Latitude, position.Longitude);
            }
            catch(Exception e)
            { 
                throw;
            }
            /*var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            dataCoords.Text = "Getting gps";

            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            if (position == null)
            {
                dataCoords.Text = "null gps :(";
                return;
            }
            else
            {
                dataCoords.Text = "JEEEST";
            }*/
        }

        private string GetLocation()
        {
            return "";
            //return GetGPSDependency().GetLocation();
        }

        private static IGPSHandler GetGPSDependency()
        {
            return DependencyService.Get<IGPSHandler>();
        }

    }
}