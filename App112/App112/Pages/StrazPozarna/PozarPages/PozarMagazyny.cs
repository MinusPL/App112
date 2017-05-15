using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class PozarMagazyny : ContentPage
    {
        public PozarMagazyny()
        {
#pragma warning restore 1591
            Picker typeOfBuilding = new Picker {
                Title = "Wskaż typ obiektu",
                Items = {"Hala magazynowa", "Hala produkcyjna", "Plac", "Składowisko"},
                SelectedIndex = 0
            };

            Picker isKnowingMaterialPicker = new Picker {
                Title = "Czy jesteś w stanie określić jaki to materiał?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker whatColorOfFog = new Picker {
                Title = "Jaki jest kolor dymu?",
                Items = {"Czarny", "Biały", "Szary"},
                SelectedIndex = 0
            };

            StackLayout materialSection = new StackLayout {
                IsVisible = false,
                Children = {
                    new Label {
                        Text = "Jaki to materiał?",
                        VerticalTextAlignment = TextAlignment.End,
                        FontSize = 18
                    },
                    new Entry {
                        
                    }
                }
            };

            StackLayout colorOfFogSection = new StackLayout {
                IsVisible = true,
                Children = {
                    new Label {
                        Text = whatColorOfFog.Title,
                        VerticalTextAlignment = TextAlignment.End,
                        FontSize = 18
                    },
                    whatColorOfFog
                }
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

            isKnowingMaterialPicker.SelectedIndexChanged += (sender, args) => {
                if (isKnowingMaterialPicker.SelectedIndex != 0) {
                    colorOfFogSection.IsVisible = false;
                    materialSection.IsVisible = true;
                }
                else {
                    colorOfFogSection.IsVisible = true;
                    materialSection.IsVisible = false;
                }
            };

            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout() {
                    Children = {
                        new Label {
                            Text = typeOfBuilding.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        typeOfBuilding,
                        new Label {
                            Text = isKnowingMaterialPicker.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        isKnowingMaterialPicker,
                        colorOfFogSection,
                        materialSection,
                        victims,
                        trapped,
                        new Button {
                        Text = "Zatwierdź",
                        Command = new Command(() => {
                            List<KeyValuePair<string, string>> messageDetails =
                                new List<KeyValuePair<string, string>> {
                                    new KeyValuePair<string, string>("Kategioria", "Pozar"),
                                    new KeyValuePair<string, string>("Podkategoria", "ObiektyMagazynowy")
                                };

                            messageDetails.Add(new KeyValuePair<string, string>("TypObiektu", typeOfBuilding.Items[typeOfBuilding.SelectedIndex]));

                            messageDetails.Add(new KeyValuePair<string, string>("CzyZnanyMaterial", isKnowingMaterialPicker.Items[isKnowingMaterialPicker.SelectedIndex]));

                            if (isKnowingMaterialPicker.SelectedIndex == 0) {
                                Entry colorOfFog = (Entry) colorOfFogSection.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("KolorDymu", colorOfFog.Text));
                            }
                            else {
                                Entry material = (Entry) materialSection.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("PalaczySieNaterial", material.Text));
                            }

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