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
        public Label lab;
        public GPSPage()
        {
            InitializeComponent();
            lab = new Label();
            lab.Text = GetLocation();
        }

        private string GetLocation()
        {
            return GetGPSDependency().GetLocation();
        }

        private static IGPSHandler GetGPSDependency()
        {
            return DependencyService.Get<IGPSHandler>();
        }

    }
}