using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591
    public class ZakloceniaNocPage : ContentPage {
        public ZakloceniaNocPage() {
#pragma warning restore 1591
            Picker wherePicker = new Picker {
                Title = "Gdzie się to dzieje?",
                Items = {"W budynku", "Na zewnątrz"},
                SelectedIndex = 0
            };

            Picker isDrunkPeople = new Picker {
                Title = "Czy osoby są pod wpływem alkoholu",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Title = "Zakłócenia spoczynku nocnego";
            Content = new ScrollView {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = wherePicker.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        wherePicker,
                        new Label {
                            Text = isDrunkPeople.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        isDrunkPeople,
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