using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace App112
{
#pragma warning disable 1591

    public class MZKatastrofaBudowlanaPage : ContentPage
    {
        public MZKatastrofaBudowlanaPage()
        {
#pragma warning restore 1591
            Picker isCollapsedBuilding = new Picker {
                Title = "Czy doszło do zawalenia budynku?",
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
                            Text = isCollapsedBuilding.Title  
                        },
                        isCollapsedBuilding,
                        victims,
                        trapped,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "MiejscoweZagrozenie"),
                                        new KeyValuePair<string, string>("Podkategoria", "KatastrofaBudowlana")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("ZawalonyBudynek", isCollapsedBuilding.Items[isCollapsedBuilding.SelectedIndex]));

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
        } // constructor
    } // class
} // namespace