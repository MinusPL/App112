using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591

    public class MZPowaloneDrzewoPage : ContentPage
    {
        public MZPowaloneDrzewoPage()
        {
#pragma warning restore 1591
            Picker stateOfTree = new Picker {
                Title = "W jakim stanie jest drzewo?",
                Items = {"Pochylone", "Powalone"},
                SelectedIndex = 0
            };

            Picker whereFall = new Picker {
                Title = "Gdzie opadło/pochylone jest drzewo?",
                Items = {"Na drogę", "Na samochód", "Na budynek", "Inne"},
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
                            Text = stateOfTree.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        stateOfTree,
                        new Label {
                            Text = whereFall.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        whereFall,
                        victims,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "MiejscoweZagrozenie"),
                                        new KeyValuePair<string, string>("Podkategoria", "Drzewo")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("StanDrzewa", stateOfTree.Items[stateOfTree.SelectedIndex]));

                                messageDetails.Add(new KeyValuePair<string, string>("Gdzie", whereFall.Items[whereFall.SelectedIndex]));

                                Entry numberOfVictims = (Entry) victims.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("Poszkodowani", numberOfVictims.Text));

                                Navigation.PushAsync (new Pages.GPSPage (messageDetails));
                            })
                        }
                    }
                }
            }; // ScrollView
            } // constructor
        } // class
    } // namespace