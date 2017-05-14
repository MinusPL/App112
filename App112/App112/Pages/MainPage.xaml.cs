using Xamarin.Forms;

namespace App112 {

	#pragma warning disable 1591
	public partial class MainPage : ContentPage {

		public MainPage() {
			InitializeComponent();
		}

		private void BtnAcceptClick(object sender, System.EventArgs e) {
            //Application.Current.MainPage = new NavigationPage(new RegisterPage());
            Application.Current.MainPage = new NavigationPage(new Pages.GPSDisclaimer());
        }
    }
	#pragma warning restore 1591
}
