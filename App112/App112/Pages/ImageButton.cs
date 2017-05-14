using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static App112.App;

namespace App112 {
	/// <summary>
	/// A custom button with a <see cref="Label"/> and <see cref="Image"/> below it, plus tap callbacks
	/// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]

	public static class ImageButton {
		/// <summary>
		/// Creates a new <see cref="StackLayout"/> ("ImageButton") with given text, background color and image
		/// </summary>
		/// <param name="text">Text to be shown</param>
		/// <param name="image">Image file to use (required)</param>
		/// <param name="width">Image width</param>
		/// <param name="onTap">Callback <see cref="Command"/></param>
		/// <returns></returns>
		public static StackLayout Create(string text, string image, double width, Command onTap) {
			var img = new Image {
				WidthRequest = width,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				Source = (FileImageSource) ImageSource.FromFile(image)
			};
			var label = new Label {
				Text = text,
//				FontSize = 16,
				HorizontalOptions = LayoutOptions.Center
			};
			var slayout = new StackLayout {
				Spacing = 10,
				Padding = new Thickness(10),
				VerticalOptions = LayoutOptions.Center,
				Children = { label, img },
			};
			var tapHandler = new TapGestureRecognizer {
				Command = onTap
			};
			img.GestureRecognizers.Add(tapHandler);
			label.GestureRecognizers.Add(tapHandler);
			slayout.GestureRecognizers.Add(tapHandler);
			return slayout;
		}
	}
}