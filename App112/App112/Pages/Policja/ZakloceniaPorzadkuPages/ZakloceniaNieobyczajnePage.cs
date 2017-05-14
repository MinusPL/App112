using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class ZakloceniaNieobyczajnePage : ContentPage
    {
        public ZakloceniaNieobyczajnePage()
        {
#pragma warning restore 1591
            Picker isDrunk = new Picker {
                Title = "Czy ta osoba jest pod wpływem alkoholu?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker whatType = new Picker {
                Title = "Wybierz typ zachowania",
                Items = {"Nieprzyzwoite napisy", "Proponowanie nierządu", "Czyny na tle seksualnym w miejscu publicznym", "Inne"},
                SelectedIndex = 0
            };

            Title = "Zachowania nieobyczajne";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = isDrunk.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
						isDrunk,
                        new Label {
                            Text = whatType.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
						whatType,
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