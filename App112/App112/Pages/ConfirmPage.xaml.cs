using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace App112.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmPage : ContentPage
    {
        private string _message;
        public ConfirmPage(string message)
        {
            _message = message;
            InitializeComponent();
            MSGText.Text = _message;
        }

        private void BtnMessageSend()
        {
            SendSMS("0048661030549", null, _message);
            Database.DReport msg = new Database.DReport();
            msg.reportID = "SIalala";
            msg.reportDate = string.Format("{0} - {1}", DependencyService.Get<IDeviceServiceInfo>()?.ConvertToDeviceShortDateFormat(DateTime.Now), DependencyService.Get<IDeviceServiceInfo>()?.ConvertToDeviceTimeFormat(DateTime.Now));
            App.Database.AddReport(msg);
            Application.Current.MainPage = new NavigationPage(new SelectPage());
            DisplayAlert("Zgłoszenie wysłane", "Twoje zgłoszenie zostało wysłane", "Zamknij");
        }

        /// <summary>
        /// Wrapper for <see cref="ISMSHandler"/>'s SendSMS
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="source"></param>
        /// <param name="text"></param>
        private static void SendSMS(string destination, string source, string text)
        {
            GetSMSDependency().SendSMS(destination, source, text);
        }

        /// <summary>
        /// Returns ISMSHandler methods from the <see cref="DependencyService"/> for quicker access
        /// </summary>
        /// <returns><see cref="ISMSHandler"/> for quicker access to its methods</returns>
        private static ISMSHandler GetSMSDependency()
        {
            return DependencyService.Get<ISMSHandler>();
        }
    }
}