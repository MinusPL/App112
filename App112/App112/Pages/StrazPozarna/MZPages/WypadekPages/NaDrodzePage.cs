using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class NaDrodzePage : ContentPage
    {
        public NaDrodzePage()
        {
#pragma warning restore 1591
            Picker typeOfEvent = new Picker {
                Title = "Rodzaj zdarzenia",
                Items = {"Kolizja", "Wypadek", "Zdarzenie mnogie"},
                SelectedIndex = 0
            };

            Picker isFire = new Picker {
                Title = "Czy doszło do pożaru pojazdu?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker isHugeVehicle = new Picker {
                Title = "Czy w wypadku uczestniczył autobus lub ciężarówka?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker isVehicleHasDangerousStuff = new Picker {
                Title = "Czy któryś z pojazdów przewozi materiały niebezpieczne?",
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

            StackLayout acciddentSection = new StackLayout {
				IsVisible = false,
				Children = {
				    new Label {
				        Text = isFire.Title,
				        VerticalTextAlignment = TextAlignment.End,
				        FontSize = 18
				    },
					isFire,
				    new Label {
				        Text = isHugeVehicle.Title,
				        VerticalTextAlignment = TextAlignment.End,
				        FontSize = 18
				    },
					isHugeVehicle,
				    new Label {
				        Text = isVehicleHasDangerousStuff.Title,
				        VerticalTextAlignment = TextAlignment.End,
				        FontSize = 18
				    },
					isVehicleHasDangerousStuff,
					trapped,
				}
            };

            typeOfEvent.SelectedIndexChanged += (sender, args) => {
                if (typeOfEvent.SelectedIndex == 0) {
                    acciddentSection.IsVisible = false;
                }
                else {
                    acciddentSection.IsVisible = true;
                }
            };

            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = typeOfEvent.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
						typeOfEvent,
						acciddentSection,
						victims,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "KolizjaWypadek"),
                                        new KeyValuePair<string, string>("Podkategoria", "NaDrodze")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("TypZdarzenia", typeOfEvent.Items[typeOfEvent.SelectedIndex]));
                                if (typeOfEvent.SelectedIndex != 0) {
                                    messageDetails.Add(new KeyValuePair<string, string>("Pozar", isFire.Items[isFire.SelectedIndex]));
                                    messageDetails.Add(new KeyValuePair<string, string>("CiezarowkaAutobus", isHugeVehicle.Items[isHugeVehicle.SelectedIndex]));
                                    messageDetails.Add(new KeyValuePair<string, string>("NiebezpieczneMaterialy", isVehicleHasDangerousStuff.Items[isVehicleHasDangerousStuff.SelectedIndex]));
                                }


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
        }
    }
}