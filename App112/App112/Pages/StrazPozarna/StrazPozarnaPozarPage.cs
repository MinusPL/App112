using System;
using Xamarin.Forms;

namespace App112 {
#pragma warning disable 1591

    public class StrazPozarnaPozarPage : ContentPage {
        public StrazPozarnaPozarPage() {
#pragma warning restore 1591
            Title = "Co się pali?";
            Content = new ScrollView {
                Content = new StackLayout {
                    Padding = new Thickness(0, 0, 0, 0),
                    Children = {
                        new Button {
                            Text = "Budynek mieszkalny",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new PozarBudynekMieszkalny()))
                        },
                        new Button {
                            Text = "Obiekty gospodarcze i rolnicze",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Instytucje lub obiekty użyteczności publicznej",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Obiekty produkcyjne, instalacje technologiczne, rurociągi lub urządzenia",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Obiekty magazynowe, place składowe",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Trawy, lasy i podobne",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Środki transportu drogowego",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Środki transportu kolejowego",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Środki transportu lotniczego",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Środki transportu wodnego",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Śmietniki i wysypiska",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Inne",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        }
                    }
                } // StackLayout
            }; // ScrollView
        } // constructor
    } // class
} // namespace