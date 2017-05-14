using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591

    public class MZPodtopieniePage : ContentPage
    {
        public MZPodtopieniePage()
        {
#pragma warning restore 1591
            Picker whatFlooded = new Picker
            {
                Title = "Co zostało zalane?",
                Items = { "Piwnica", "Kondygnacja budynku mieszkalnego", "Posesja", "Pole uprawne lub łąka" },
                SelectedIndex = 0
            };

            StackLayout victims = new StackLayout
            {
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
                Content = new StackLayout
                {
                    Children = {
                        new Label {
                            Text = whatFlooded.Title
                        },
                        whatFlooded,
                        victims,
                        trapped,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "MiejscoweZagrozenie"),
                                        new KeyValuePair<string, string>("Podkategoria", "PodtopieniaPowodz")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("CoZalane", whatFlooded.Items[whatFlooded.SelectedIndex]));

                                Entry numberOfVictims = (Entry) victims.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("Poszkodowani", numberOfVictims.Text));

                                Entry numberOfTrapped = (Entry) trapped.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("Uwiezieni", numberOfTrapped.Text));

                                throw new NotImplementedException();
                            })
                        }
                    }
                }
            }; // ScrollView
        } // constructor
        } // class
    } // namespace