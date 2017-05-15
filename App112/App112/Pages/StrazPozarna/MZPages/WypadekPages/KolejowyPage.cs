using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class KolejowyPage : ContentPage
    {
        public KolejowyPage()
        {
#pragma warning restore 1591
            Picker isCrashWithCar = new Picker {
                Title = "Czy doszło do zderzenia z samochodem?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker isVehicleHasDangerousStuff = new Picker
            {
                Title = "Czy były przewożone materiały niebezpieczne?",
                Items = { "Nie", "Tak" },
                SelectedIndex = 0
            };

            Picker isFire = new Picker
            {
                Title = "Czy doszło do pożaru?",
                Items = { "Nie", "Tak" },
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
                            Text = isCrashWithCar.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
						isCrashWithCar,
                        new Label {
                            Text = isVehicleHasDangerousStuff.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
						isVehicleHasDangerousStuff,
                        new Label {
                            Text = isFire.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
						isFire,
						victims,
						trapped,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "Wypadek"),
                                        new KeyValuePair<string, string>("Podkategoria", "Kolejowy")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("ZderzenieZSamochodem", isCrashWithCar.Items[isCrashWithCar.SelectedIndex]));
                                messageDetails.Add(new KeyValuePair<string, string>("MaterialyNiebezpieczne", isVehicleHasDangerousStuff.Items[isVehicleHasDangerousStuff.SelectedIndex]));
                                messageDetails.Add(new KeyValuePair<string, string>("Pozar", isFire.Items[isFire.SelectedIndex]));

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