using System;
using Xamarin.Forms;
using static App112.App;

namespace App112 {

#pragma warning disable 1591
	public partial class SelectPage : ContentPage {
		public SelectPage() {
#pragma warning restore 1591
			Title = "112 Zgłoś Zdarzenie";
			var star = new GridLength(1, GridUnitType.Star);
			var mainGrid = new Grid {
				RowDefinitions = {
					new RowDefinition {Height=star},
					new RowDefinition {Height=star},
					new RowDefinition {Height=star}
				},
				ColumnDefinitions = {
					new ColumnDefinition {Width = star},
					new ColumnDefinition {Width = star},
					new ColumnDefinition {Width = star}
				}
			};
			mainGrid.Children.Add(
				ImageButton.Create(
					"Ustawienia", "ustawienia.png", 64,
					new Command(() => ShowMessage("Ustawienia"))),
				1, 0
			);
			mainGrid.Children.Add(
				ImageButton.Create(
					"Historia", "historia.png", 64,
                    new Command(() => Navigation.PushAsync(new Pages.HistoryPage()))),
                0, 1
			);
			mainGrid.Children.Add(
				ImageButton.Create(
					"Zgłoś zdarzenie", "zglos.png", 192,
					new Command(() => Navigation.PushAsync(new ZglosPage()))),
				1, 1
			);
			mainGrid.Children.Add(
				ImageButton.Create(
					"Użyszkodnik", "uzytkownik.png", 64,
					new Command(() => ShowMessage("Użyszkodnik"))),
				2, 1
			);
			mainGrid.Children.Add(
				ImageButton.Create(
					"Pomoc", "pomoc.png", 64,
					new Command(() => ShowMessage("Pomoc"))),
				1, 2
			);
			Padding = new Thickness(0, 0);
			Content = mainGrid;
		}
	}
}