using Android.App;
using Android.Widget;
using App112.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(Message))]
namespace App112.Droid {
	#pragma warning disable 1591
	public class Message : IMessage {
	#pragma warning restore 1591

		/// <summary>
		/// Shows a quick debug message
		/// </summary>
		/// <param name="text">Text to show</param>
		public void ShowMessage(string text) {
			Toast.MakeText(Application.Context, text, ToastLength.Short).Show();
		}
	}
}