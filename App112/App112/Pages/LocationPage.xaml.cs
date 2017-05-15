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
    public partial class LocationPage : ContentPage
    {
        private List<KeyValuePair<string, string>> _list;
        public LocationPage(List<KeyValuePair<string, string>> _tempList)
        {
            _list = _tempList;
            InitializeComponent();
        }

        private void BtnLocationSend(object sender, System.EventArgs e)
        {
            _list.Add(new KeyValuePair<string, string>("Miejsce zdarzenia", editLoc.Text));
            string message = "";
            foreach (var entry in _list)
            {
                message += string.Format("{0}: {1}; ", entry.Key, entry.Value);
            }
            Application.Current.MainPage = new NavigationPage(new ConfirmPage(message));
        }
    }
}