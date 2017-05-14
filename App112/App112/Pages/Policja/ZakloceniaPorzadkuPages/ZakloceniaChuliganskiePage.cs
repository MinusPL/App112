using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591
    public class ZakloceniaChuliganskiePage : ContentPage {
        public ZakloceniaChuliganskiePage() {
#pragma warning restore 1591
            Entry howMany = new Entry {
                Keyboard = Keyboard.Numeric
            };

            Picker hasDangerousStuff = new Picker {
                Title = "Czy te osoby są wyposażone w przedmioty niebezpieczne?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker hasMask = new Picker {
                Title = "Czy te osoby są zamaskowane?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Title = "Zbiorowe ekscesy chuligańskie";
            Content = new ScrollView {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = "Określ liczbeność grupy",
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        howMany,
                        new Label {
                            Text = hasDangerousStuff.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        hasDangerousStuff,
                        new Label {
                            Text = hasMask.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        hasMask,
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