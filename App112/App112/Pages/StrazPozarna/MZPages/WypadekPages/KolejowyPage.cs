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
                            Command = new Command(() => throw new NotImplementedException())
                        }
                    }
                }
            }; // ScrollView
        }
    }
}