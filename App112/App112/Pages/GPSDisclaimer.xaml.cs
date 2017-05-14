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
using Plugin.Geolocator;

namespace App112.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GPSDisclaimer : ContentPage
    {
        public GPSDisclaimer()
        {
            InitializeComponent();
        }

        private void BtnRegisterClick(object sender, System.EventArgs e)
        {
            if(IsGPSEnabled())
            {
                Application.Current.MainPage = new NavigationPage(new RegisterPage());
            }
            else
            {
                Application.Current.MainPage = new NavigationPage(new GPSPage());
            }
        }

        private bool IsGPSEnabled()
        {
            return GetGPSDependency().IsGPSEnabled();
        }


        private static IGPSHandler GetGPSDependency()
        {
            return DependencyService.Get<IGPSHandler>();
        }
    }
}