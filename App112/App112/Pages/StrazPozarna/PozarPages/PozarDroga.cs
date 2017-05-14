using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class PozarDroga : ContentPage
    {
        public PozarDroga()
        {
#pragma warning restore 1591

            Picker isVehicleWithChemicalsPicker = new Picker {
                Title = "Czy samochód przewozi substancje niebezpieczne?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            StackLayout chemicalsSection = new StackLayout {
                IsVisible = false,
                Children = {
                    new Label {
                        Text = "O ile masz mozliwosc podaj numer z pomarańczowej tabliczki",
                        VerticalTextAlignment = TextAlignment.End,
                        FontSize = 18
                    },
                    new Entry {
                    }
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

            isVehicleWithChemicalsPicker.SelectedIndexChanged += (sender, args) => {
                if (isVehicleWithChemicalsPicker.SelectedIndex != 0) {
                    chemicalsSection.IsVisible = true;
                }
                else {
                    chemicalsSection.IsVisible = false;
                }
            };

            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = isVehicleWithChemicalsPicker.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        chemicalsSection,
                        victims,
                        trapped,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => throw new NotImplementedException())
                        }
                    }
                }
            }; // ScrollView
        }
    }
}