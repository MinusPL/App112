using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591
    public class ZakloceniaOgniskaPage : ContentPage {
        public ZakloceniaOgniskaPage() {
#pragma warning restore 1591
            Picker wherePicker = new Picker {
                Title = "Wybierz w jaki miejscu?",
                Items = {"Las lub w pobliżu", "Park", "W pobliżu materiałów łatwopalnych i wybuchowych", "Inne"},
                SelectedIndex = 0
            };
            Title = "Palenie ognisk w miejscu niedozwolonym";
            Content = new ScrollView {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = wherePicker.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        wherePicker,
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