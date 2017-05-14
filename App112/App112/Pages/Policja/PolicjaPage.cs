using System;
using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591

	public class PolicjaPage : ContentPage {
		public PolicjaPage() {
#pragma warning restore 1591
			Title = "Policja";
			Content = new ScrollView {
				Content = new StackLayout {
					Padding = new Thickness(0, 0, 0, 0),
					Children = {
						new Button {
							Text = "Komunikacja drogowa",
							BackgroundColor = Color.White,
							Image = (FileImageSource) ImageSource.FromFile("drogowe.png"),
							Command = new Command(() => throw new NotImplementedException())
						},
					    new Button
					    {
					        Text = "Zakłócenia porządku publicznego",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("porzadekpubliczny.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    } ,
					    new Button
					    {
					        Text = "Incydenty z materiałami wybuchowymi",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("materialywybuchowe.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Kradzież lub rozbój",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("kradziez.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Przemoc",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("przemoc.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Zaginięcie lub uprowadzenie",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("zaginiecie.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Przestępstwa seksualne",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("seksualne.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Przestępstwa narkotykowe",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("narkotyki.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Zabójstwo lub samobójstwo",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("zabojstwo.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Interwencje domowe",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("interwencjadomowa.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Oszustwa",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("oszustwo.png"),
					        Command = new Command(() => throw new NotImplementedException())
					    },
					    new Button
					    {
					        Text = "Inne",
					        BackgroundColor = Color.White,
					        Image = (FileImageSource) ImageSource.FromFile("inne.png"),
					        Command = new Command(() => Navigation.PushAsync(new PolicjaInnePage()))
					    }
					}
				} // StackLayout
			}; // ScrollView
		} // constructor
	} // class
} // namespace