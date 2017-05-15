using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class PozarLasy : ContentPage
    {
        public PozarLasy()
        {
#pragma warning restore 1591
            Picker isNearForest = new Picker {
                Title = "Czy pożar występuje w pobliżu lasu?",
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

            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = isNearForest.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        isNearForest,
                        victims,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>>();

                                messageDetails.Add(new KeyValuePair<string, string>("WPoblizuLasu", isNearForest.Items[isNearForest.SelectedIndex]));

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