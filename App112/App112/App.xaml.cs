using App112.Database;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App112 {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	#pragma warning disable 1591
	public partial class App : Application {

        static DDatabase database;


        public App() {
			InitializeComponent();
			MainPage = new NavigationPage(new MainPage());
		}

        public static DDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("reports.db3"));
                }
                return database;
            }
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
