using System;
using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591

	public class ZglosPage : ContentPage {
		public ZglosPage() {
#pragma warning restore 1591
			Title = "Zgłoś zdarzenie";
			Content = new ScrollView {
				Content = new StackLayout {
					Padding = new Thickness(0, 0, 0, 0),
					Children = {
						new Button {
							Text = "Straż pożarna", BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("pozar.png"),
							Command = new Command(() => Navigation.PushAsync(new StrazPozarnaPage()))
						}, new Button {
							Text = "Policja", BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("policja.png"),
							Command = new Command(() => Navigation.PushAsync(new PolicjaPage()))
						}, new Button() {
							Text = "Pogotowie", BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("pogotowie.png"),
							Command = new Command(() => Navigation.PushAsync(new PogotowiePage()))
						}
					}
				} // StackLayout
			}; // ScrollView
		} // constructor
	} // class
} // namespace