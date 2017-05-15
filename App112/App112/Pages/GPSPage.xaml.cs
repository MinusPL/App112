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
        private List<KeyValuePair<string, string>> _list;
        public GPSPage(List<KeyValuePair<string, string>> _tempList)
        {
            _list = _tempList;
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            Application.Current.MainPage = new NavigationPage(new LocationPage(_list));
            /*base.OnAppearing();
            try
            { 
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;               
                var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

                //dataCoords.Text = string.Format("LATT: {0}, LONT: {1}", position.Latitude, position.Longitude);
            }
            catch(Exception e)
            { 
                throw;
            }*/
        }
    }
}