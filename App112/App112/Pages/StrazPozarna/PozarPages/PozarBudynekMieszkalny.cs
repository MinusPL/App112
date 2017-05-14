using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591

    public class PozarBudynekMieszkalny : ContentPage {
        public PozarBudynekMieszkalny()
        {
#pragma warning restore 1591
            Picker isOneFamilyHouse = new Picker {
                Title = "Jaki budynek się pali?",
                Items = {"Dom jednorodzinny", "Blok"},
                SelectedIndex = 0
            };

            Picker isfireInChimney = new Picker{
                Title = "Czy jest to pożar sadzy w kominie?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker typeOfBuilding = new Picker {
                Title = "Jaki jest rodzaj budynku?",
                Items = {"Dom murowany", "Dom drewniany"},
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

            StackLayout floors = new StackLayout {
                Children = {
                    new Label {
                        Text = "Ile pięter ma budynek?",
                        VerticalTextAlignment = TextAlignment.End,
                        FontSize = 18
                    },
                    new Entry {
                        Keyboard = Keyboard.Numeric
                    }
                }
            };

            StackLayout whichFloor = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Na którym piętrze występuje pożar?",
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

            StackLayout oneFamilyHouseSection = new StackLayout {
                IsVisible = true,
                Children = {
                    new Label{
                        Text = isfireInChimney.Title,
                        VerticalTextAlignment = TextAlignment.End,
                        FontSize = 18
                    },
                    isfireInChimney,
                    new Label {
                        Text = typeOfBuilding.Title,
                        VerticalTextAlignment = TextAlignment.End,
                        FontSize = 18
                    },
                    typeOfBuilding,
                    floors,
                }
            };

            StackLayout flatHouseSection = new StackLayout {
                IsVisible = false,
                Children = {
                    floors,
                    whichFloor
                }
            };

            isOneFamilyHouse.SelectedIndexChanged += (sender, args) => {
                if (isOneFamilyHouse.SelectedIndex == 0) {
                    oneFamilyHouseSection.IsVisible = true;
                    flatHouseSection.IsVisible = false;
                }
                else {
                    oneFamilyHouseSection.IsVisible = false;
                    flatHouseSection.IsVisible = true;
                }
            };
            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = isOneFamilyHouse.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        isOneFamilyHouse,
                        oneFamilyHouseSection,
                        flatHouseSection,
                        victims,
                        trapped,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "Pozar"),
                                        new KeyValuePair<string, string>("Podkategoria", "BudynekMieszkalny")
                                    };
                                    messageDetails.Add(new KeyValuePair<string, string>("TypBudynku", isOneFamilyHouse.Items[isOneFamilyHouse.SelectedIndex]));
                                if (isOneFamilyHouse.SelectedIndex == 0) {
                                    messageDetails.Add(new KeyValuePair<string, string>("Komin",
                                        isfireInChimney.Items[isfireInChimney.SelectedIndex]));
                                    messageDetails.Add(new KeyValuePair<string, string>("Material",
                                        typeOfBuilding.Items[typeOfBuilding.SelectedIndex]));

                                    Entry entry = (Entry) floors.Children[1];
                                    messageDetails.Add(new KeyValuePair<string, string>("IloscPieter", entry.Text));
                                }
                                else {
                                    Entry entry = (Entry) floors.Children[1];
                                    messageDetails.Add(new KeyValuePair<string, string>("IloscPieter", entry.Text));

                                    Entry entrys = (Entry) whichFloor.Children[1];
                                    messageDetails.Add(new KeyValuePair<string, string>("KtorePietro", entrys.Text));
                                }
                                Entry numberOfVictims = (Entry) victims.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("Poszkodowani", numberOfVictims.Text));

                                Entry numberOfTrapped = (Entry) trapped.Children[1];
                                messageDetails.Add(new KeyValuePair<string, string>("Uwiezieni", numberOfTrapped.Text));

                                throw new NotImplementedException();
                            })
                        }
                    }
                } // StackLayout
            }; // ScrollView
        } // constructor
    } // class
} // namespace