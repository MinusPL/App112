using System;
using Xamarin.Forms;
using static App112.App;

namespace App112 {

	#pragma warning disable 1591
	public class PogotowiePage : ContentPage {
		public PogotowiePage() {
	#pragma warning restore 1591
			Title = "Pogotowie ratunkowe";
			Content = new ScrollView {
				Content = new StackLayout {
					Padding = new Thickness(0, 0, 0, 0),
					Children = {
						new Button {
							Text = "Ciąża",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("ciaza.png"),
							Command = new Command(() => ShowMessage("Ciąża!"))
						},
						new Button {
							Text = "Wypadek",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("wypadekkomunikacyjny.png"),
							Command = new Command(() => throw new NotImplementedException())
						},
						new Button {
							Text = "Zachorowania lub uszkodzenie ciała",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("zachorowanie.png"),
							Command = new Command(() => Navigation.PushAsync(new ZachorowaniaPage()))
						}
					}
				} // StackLayout
			}; // ScrollView
		} // constructor
	} // class
} // namespace