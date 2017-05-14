using System;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class PrzytomnyPage : ContentPage
    {
        public PrzytomnyPage()
        {
#pragma warning restore 1591
            Title = "Przytomny";
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(0, 0, 0, 0),
                    Children =
                    {
                        new Button
                        {
                            Text = "Alergia",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("alergia.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        } ,
                        new Button
                        {
                            Text = "Drgawki",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("drgawki.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Ból",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("bol.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Duszności",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("dusznosci.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Tonięcie",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("toniecie.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Porażenie prądem",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("porazenie.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Urazy",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("uraz.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Krwotok",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("krwawienie.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Zachłyśnięcie lub zadławienie",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("zadlawienie.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Problemy kardiologiczne",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("kardiologiczne.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Paraliż, Bełkotliwa mowa lub Udar",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("udar.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Oparzenie",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("oparzenie.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Odmrożenie",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("odmrozenie.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Zasłabnięcie",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("zaslabniecie.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Cukrzyca",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("cukrzyca.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        },
                        new Button
                        {
                            Text = "Inne",
                            BackgroundColor = Color.White,
                            Image = (FileImageSource) ImageSource.FromFile("inne.png"),
                            Command = new Command(() => throw new NotImplementedException())
                        }
                    }
                }
            };
        }
    }
}