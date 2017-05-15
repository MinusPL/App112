using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class MZPlamaOleju : ContentPage
    {
        public MZPlamaOleju()
        {
#pragma warning restore 1591
            Picker whereSpot = new Picker {
                Title = "Gdzie ta plama występuje?",
                Items = {"Na drodze", "W ziemi", "Na morzu", "Na rzece/potoku", "Na jeziorze/stawie"},
                SelectedIndex = 0
            };

            StackLayout victims = new StackLayout {
                IsVisible = true,
                Children = {
                    new Label {
                        Text = "Ile jest osob poszkodowanych?",
                        VerticalTextAlignment = TextAlignment.End,
                        FontSize = 18
                    },
                    new Entry {
                        Keyboard = Keyboard.Numeric
                    }
                }
            };

            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = whereSpot.Title
                        },
                        whereSpot,
                        victims,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "MiejscoweZagrozenie"),
                                        new KeyValuePair<string, string>("Podkategoria", "PlamaOleju")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("Gdzie", whereSpot.Items[whereSpot.SelectedIndex]));

                                Entry numberOfVictims = (Entry) victims.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("Poszkodowani", numberOfVictims.Text));

                                Navigation.PushAsync (new Pages.GPSPage (messageDetails));
                            })
                        }
                    }
                }
            }; // ScrollView
        }
    }
}