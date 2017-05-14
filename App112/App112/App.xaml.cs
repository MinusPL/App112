using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App112 {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	#pragma warning disable 1591
	public partial class App : Application {

		public App() {
			InitializeComponent();
			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart() {}
		protected override void OnSleep() {}
		protected override void OnResume() {}

		/// <summary>
		/// Shows a quick debug message
		/// </summary>
		/// <param name="text">Text to be shown</param>
		public static void ShowMessage(string text) {
			GetMessageDependency().ShowMessage(text);
		}

		/// <summary>
		/// Grabs <see cref="IMessage"/> from the <see cref="DependencyService"/> for quicker access
		/// </summary>
		/// <returns><see cref="IMessage"/></returns>
		private static IMessage GetMessageDependency() {
			return DependencyService.Get<IMessage>();
		}
	}
	#pragma warning restore 1591
}
