using System;
using App112.Pages.Pogotowie;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class ZachorowaniaPage : ContentPage
    {
        public ZachorowaniaPage()
        {
#pragma warning restore 1591
            Title = "Zachorowania";
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(0, 0, 0, 0),
                    Children =
                    {
                        new Button
                        {
                            Text = "Przytomny",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("przytomny.png"),
                            Command = new Command(() => Navigation.PushAsync(new PrzytomnyPage()))
                        },
                        new Button
                        {
                            Text = "Nieprzytomny",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("nieprzytomny.png"),
                            Command = new Command(() => Navigation.PushAsync(new NiePrzytomnyPage()))
                        }
                    }
                }
            };
        }
    }
}