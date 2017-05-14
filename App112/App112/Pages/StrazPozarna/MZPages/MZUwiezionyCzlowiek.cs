using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class MZUwiezionyCzlowiek : ContentPage
    {
        public MZUwiezionyCzlowiek()
        {
#pragma warning restore 1591
            Picker inWhatWay = new Picker {
                Title = "W jaki sposób został uwięziony?",
                Items = {"W otworze", "Na drzewie", "W Studni", "Przysypany", "Przygnieciony przez drzewo", "Przygnieciony przez pojazd"},
                SelectedIndex = 0
            };

            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = inWhatWay.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        inWhatWay,
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