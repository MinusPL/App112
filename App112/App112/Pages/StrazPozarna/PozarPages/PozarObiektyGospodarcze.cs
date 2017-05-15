using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{

#pragma warning disable 1591
    public class PozarObiektyGospodarcze : ContentPage
    {
        public PozarObiektyGospodarcze()
        {
#pragma warning restore 1591
            Picker whatType = new Picker {
                Title = "Wskaż typ obiektu",
                Items = {"Stodoła", "Stajnia", "Stogi siana", "Pola i uprawy"},
                SelectedIndex = 0
            };

            Picker animalsInObject = new Picker {
                Title = "Czy znajdują się tam zwierzęta?",
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
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = whatType.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        whatType,
                        new Label {
                            Text = animalsInObject.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        animalsInObject,
                        victims,
                        trapped,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "Pozar"),
                                        new KeyValuePair<string, string>("Podkategoria", "ObiektGospodarczy")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("TypObiektu", whatType.Items[whatType.SelectedIndex]));

                                messageDetails.Add(new KeyValuePair<string, string>("SaZwierzeta", animalsInObject.Items[animalsInObject.SelectedIndex]));

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