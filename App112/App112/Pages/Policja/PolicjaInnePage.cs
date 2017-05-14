using System;
using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591

	public class PolicjaInnePage : ContentPage {
		public PolicjaInnePage() {
#pragma warning restore 1591
			Title = "Policja - Inne";
			Content = new ScrollView {
				Content = new StackLayout {
					Padding = new Thickness(0, 0, 0, 0),
					Children = {
						new Label {
							Text = "Opisz szczegóły zdarzenia"
						},
						new Editor {
							MinimumHeightRequest = 100
						},
						new Button {
							Text = "Zapisz",
							Command = new Command(() => throw new NotImplementedException())
						}
					}
				} // StackLayout
			}; // ScrollView
		} // constructor
	} // class
} // namespace