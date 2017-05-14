using System;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class BolPage : ContentPage
    {
        public BolPage()
        {
#pragma warning restore 1591
            Title = "Wybierz typ bólu";
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(0, 0, 0, 0),
                    Children =
                    {
                        new Button
                        {
                            Text = "Brzucha",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new BolBrzuchaPage()))
                        },
                        new Button
                        {
                            Text = "Głowy",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new BolGlowyPage()))
                        },
                        new Button
                        {
                            Text = "Pleców/Kręgosłupa",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new BolPlecowPage()))
                        },
                        new Button
                        {
                            Text = "Kończyny",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new BolKonczynyPage()))
                        },
                        new Button
                        {
                            Text = "W klatce piersiowej",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new BolKlatkiPiersiowejPage()))
                        },
                        new Button
                        {
                            Text = "Inny",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new BolInnyPage()))
                        }
                    }
                }
            };
        }
    }
}