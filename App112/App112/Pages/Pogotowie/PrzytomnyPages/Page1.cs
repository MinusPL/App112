using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class Page1 : ContentPage
    {
        public Page1()
        {
#pragma warning restore 1591
            Picker isSomething = new Picker {
                Title = "Kurwa",
                Items = {"Nie i chuj", "Tak i spierdalaj"}
            };

            Entry isSomthingWpisz = new Entry {};
            StackLayout entryDoWpisywania = new StackLayout {
                Children = {
                    new Label {
                        Text = "Tak to właśnie ja!"
                    },
                    isSomthingWpisz
                },
                IsVisible = false 
            };

            isSomething.SelectedIndexChanged += (sender, args) => {
                if (isSomething.SelectedIndex == 1) {
                    entryDoWpisywania.IsVisible = true;
                }
                else {
                    entryDoWpisywania.IsVisible = false;
                }
            };

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" },
                    isSomething, entryDoWpisywania
                }
            };
        }
    }
}