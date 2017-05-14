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
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Kolejowy",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Samolotowy",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button {
                            Text = "Na wodzie",
                            BackgroundColor = Color.White,
                            Command = new Command(() => throw new NotImplementedException())
                        }
                    }
                } // StackLayout
            }; // ScrollView
        } // constructor
    } // class
} // namespace