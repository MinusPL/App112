using System;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591

    public class MZWypadek : ContentPage
    {
        public MZWypadek()
        {
#pragma warning restore 1591
            Title = "Jaki wypadek?";
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(0, 0, 0, 0),
                    Children = {
                        new Button {
                            Text = "Na drodze",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new NaDrodzePage()))
                        },
                        new Button {
                            Text = "Kolejowy",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new KolejowyPage()))
                        },
                        new Button {
                            Text = "Samolotowy",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new SamolotowyPage()))
                        },
                        new Button {
                            Text = "Na wodzie",
                            BackgroundColor = Color.White,
                            Command = new Command(() => Navigation.PushAsync(new NaWodziePage()))
                        }
                    }
                } // StackLayout
            }; // ScrollView
        } // constructor
    } // class
} // namespace