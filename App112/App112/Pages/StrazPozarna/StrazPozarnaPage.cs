using System;
using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591

	public class StrazPozarnaPage : ContentPage {
		public StrazPozarnaPage() {
#pragma warning restore 1591
			Title = "Straż pożarna";
			Content = new ScrollView {
				Content = new StackLayout {
					Padding = new Thickness(0, 0, 0, 0),
					Children = {
						new Button {
							Text = "Pożar",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("pozar.png"),
							Command = new Command(() => Navigation.PushAsync(new StrazPozarnaPozarPage()))
						},
						new Button {
							Text = "Wypadek",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("wypadekkomunikacyjny.png"),
							Command = new Command(() => Navigation.PushAsync(new MZWypadek()))
						},
						new Button {
							Text = "Awaria/Katastrofa budowlana",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("katastrofabudowlana.png"),
							Command = new Command(() => Navigation.PushAsync(new MZKatastrofaBudowlanaPage()))
						},
						new Button {
							Text = "Podtopienie/Powódź",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("powodz.png"),
							Command = new Command(() => Navigation.PushAsync(new MZPodtopieniePage()))
						},
						new Button {
							Text = "Drzewo",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("zawalonedrzewo.png"),
							Command = new Command(() => Navigation.PushAsync(new MZPowaloneDrzewoPage()))
						},
						new Button {
							Text = "Plama oleju",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("plamaoleju.png"),
							Command = new Command(() => Navigation.PushAsync(new MZPlamaOleju()))
						},
						new Button {
							Text = "Uszkodzenia obiektów technicznych",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("techniczne.png"),
							Command = new Command(() => Navigation.PushAsync(new MZUszkodzeniaObiektowTech()))
						},
						new Button {
							Text = "Uwięzione zwierzę",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("uwiezionezwierze.png"),
							Command = new Command(() => Navigation.PushAsync(new MZUwiezioneZwierze()))
						},
						new Button {
							Text = "Uwięziony człowiek",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("uwiezionyczlowiek.png"),
							Command = new Command(() => Navigation.PushAsync(new MZUwiezionyCzlowiek()))
						}
					}
				}	// StackLayout
			};		// ScrollView
		}			// constructor
	}				// class
}					// namespace