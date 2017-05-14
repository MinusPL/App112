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
                            Command = new Command(() => throw new NotImplementedException())
                        }
                    }
                }
            }; // ScrollView
        }
    }
}