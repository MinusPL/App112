using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591
    public class MaterialyWybuchowePodlozeniePage : ContentPage {
        public MaterialyWybuchowePodlozeniePage() {
#pragma warning restore 1591
            Picker isDangerForPeoplePicker = new Picker {
                Title = "Czy są osoby zagrożone?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker isCulpritTaken = new Picker
            {
                Title = "Czy ująłęś sprawcę?",
                Items = { "Nie", "Tak" },
                SelectedIndex = 0
            };

            Title = "Ktoś podkłada materiały wybuchowe";
            Content = new ScrollView {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = isDangerForPeoplePicker.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        isDangerForPeoplePicker,
                        new Label {
                            Text = isCulpritTaken.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        isCulpritTaken,
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