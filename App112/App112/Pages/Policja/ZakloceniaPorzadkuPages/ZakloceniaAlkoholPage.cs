using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591
    public class ZakloceniaAlkoholPage : ContentPage {
        public ZakloceniaAlkoholPage() {
#pragma warning restore 1591
            Picker where = new Picker {
                Title = "Wybierz miejsce",
                Items = {"Sklep", "Przystanek", "Instytucja", "Stadion", "Inne"},
                SelectedIndex = 0
            };    

            Title = "Spożywanie alkoholu w miejscu publicznym";
            Content = new ScrollView {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = where.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        where,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => throw new NotImplementedException())
                        }
                    }
                }
            }; // ScrollView
        }
    }
}