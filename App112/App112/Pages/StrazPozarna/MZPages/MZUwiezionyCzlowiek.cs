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
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "MiejscoweZagrozenie"),
                                        new KeyValuePair<string, string>("Podkategoria", "UwiezionyCzlowiek")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("Jak", inWhatWay.Items[inWhatWay.SelectedIndex]));

                                Navigation.PushAsync (new Pages.GPSPage (messageDetails));
                            })
                        }
                    }
                }
            }; // ScrollView
        }
    }
}