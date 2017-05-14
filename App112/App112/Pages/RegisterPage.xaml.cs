using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App112 {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	#pragma warning disable 1591
	public partial class RegisterPage : ContentPage {
		public RegisterPage() {
			InitializeComponent();
			Title = "Rejestracja";
		}
		#pragma warning restore 1591

		/// <summary>
		/// Handles "Register" button, sends SMS message and switches to the main page
		/// </summary>
		private void BtnRegisterClick(object sender, System.EventArgs e) {
			//SendSMS("+48661030549", "+48661030549", "Hello!");
			Application.Current.MainPage = new NavigationPage(new SelectPage());
		}

		/// <summary>
		/// Wrapper for <see cref="ISMSHandler"/>'s SendSMS
		/// </summary>
		/// <param name="destination"></param>
		/// <param name="source"></param>
		/// <param name="text"></param>
		private static void SendSMS(string destination, string source, string text) {
			GetSMSDependency().SendSMS(destination, source, text);
		}

		/// <summary>
		/// Returns ISMSHandler methods from the <see cref="DependencyService"/> for quicker access
		/// </summary>
		/// <returns><see cref="ISMSHandler"/> for quicker access to its methods</returns>
		private static ISMSHandler GetSMSDependency() {
			return DependencyService.Get<ISMSHandler>();
		}
	}
}
