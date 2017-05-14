using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112.Pages.Pogotowie
{
#pragma warning disable 1591
    public class NiePrzytomnyPage : ContentPage
    {
        public NiePrzytomnyPage()
        {
#pragma warning restore 1591
            Title = "Nieprzytomny";
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(0, 0, 0, 0),
                    Children =
                    {
                        new Button
                        {
                            Text = "Oddycha",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new OddychaPage()))
                        } ,
                        new Button
                        {
                            Text = "Nie oddycha",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        }
                    }
                }
            };
        }
    }
}