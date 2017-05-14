using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591
    public class KomunikacjaDrogowaPages : ContentPage {
        public KomunikacjaDrogowaPages() {
#pragma warning restore 1591
            Picker details = new Picker {
                Title = "W jaki sposób zostały naruszone przepisy?",
                Items = {"Agresywna jazda", "Złe parkowanie", "Nadmierna szybkość", "Przejechanie na czerwonym świetle"},
                SelectedIndex = 0
            };

            Picker canGivePlates = new Picker
            {
                Title = "Czy jesteś w stanie podać numer rejestracyjny pojazdu?",
                Items = { "Nie", "Tak" },
                SelectedIndex = 0
            };

            Picker typeOfVechicle = new Picker
            {
                Title = "Podaj typ pojazdu",
                Items = { "Samochód", "Ciągnik", "Autobus", "Motocykl", "Ciężarówka", "Motorower" },
                SelectedIndex = 0
            };

            Picker isCulpritTaken = new Picker
            {
                Title = "Czy ująłęś sprawcę?",
                Items = { "Nie", "Tak" },
                SelectedIndex = 0
            };

            Entry carBrand = new Entry();
            Entry colorOfCar = new Entry();
            Entry plateNumbers = new Entry();


            StackLayout platesSection = new StackLayout
            {
                IsVisible = false,
                Children = {
                    new Label {
                        Text = "Podaj numer rejestracyjny",
                        VerticalTextAlignment = TextAlignment.End,
                        FontSize = 18
                    },
                    plateNumbers
                }
            };

            canGivePlates.SelectedIndexChanged += (sender, args) => {
                if (canGivePlates.SelectedIndex == 0)
                {
                    platesSection.IsVisible = false;
                }
                else
                {
                    platesSection.IsVisible = true;
                }
            };
            Title = "Naruszenie przepisów drogowych";
            Content = new ScrollView {
                Content = new StackLayout
                {
                    Children = {
                        new Label {
                            Text = details.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        details,
                        new Label {
                            Text = canGivePlates.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        canGivePlates,
                        new Label {
                            Text = typeOfVechicle.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        typeOfVechicle,
                        new Label {
                            Text = "Podaj markę pojazdu (puste jeżeli nie wiesz)",
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        carBrand,
                        new Label {
                            Text = "Podaj kolor pojazdu",
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        colorOfCar,
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