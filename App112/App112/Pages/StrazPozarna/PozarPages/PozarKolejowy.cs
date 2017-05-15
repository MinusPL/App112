using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class PozarKolejowy : ContentPage
    {
        public PozarKolejowy()
        {
#pragma warning restore 1591
            Picker hasDangerousStuff = new Picker {
                Title = "Czy przewozi materiały niebezpieczne?",
                Items = {"Nie", "Tak"},
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

            StackLayout trapped = new StackLayout {
                IsVisible = true,
                Children = {
                    new Label {
                        Text = "Ile jest osob uwiezionych?",
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
                Content = new StackLayout() {
                    Children = {
                        new Label {
                            Text = hasDangerousStuff.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        hasDangerousStuff,
                        victims,
                        trapped,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "Pozar"),
                                        new KeyValuePair<string, string>("Podkategoria", "TransportKolejowy")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("WPoblizuLasu", hasDangerousStuff.Items[hasDangerousStuff.SelectedIndex]));

                                Entry numberOfVictims = (Entry) victims.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("Poszkodowani", numberOfVictims.Text));

                                Entry numberOfTrapped = (Entry) trapped.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("Uwiezieni", numberOfTrapped.Text));

                                Navigation.PushAsync (new Pages.GPSPage (messageDetails));
                            })
                        }
                    }
                }
            }; // ScrollView
        }
    }
}