using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using static App112.App;

namespace App112
{
#pragma warning disable 1591
    public class BolInnyPage : ContentPage
    {
        public BolInnyPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker isIll = new Picker
            {
                Title = "Czy poszkodowany choruje?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker isTakingDrugs = new Picker
            {
                Title = "Czy przyjmuje leki?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker otherSymptoms = new Picker
            {
                Title = "Czy widzisz dodatkowe niepokojące objawy?",
                Items = { "Nie", "Tak" },
                SelectedIndex = 0
            };

            //Teraz tworze sobie sekcje ktore beda sie ukrywac

            StackLayout isTakingDrugsSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Jakie?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout isIllSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = isTakingDrugs.Title
                    },
                    isTakingDrugs,
                    isTakingDrugsSection
                }
            };

            StackLayout otherSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Opisz:"
                    },
                    new Entry
                    {

                    }
                }
            };

            //A to juz sa Eventy pickerow ktore reaguja na zmiane

            isIll.SelectedIndexChanged += (sender, args) =>
            {
                if (isIll.SelectedIndex == 1)
                    isIllSection.IsVisible = true;
                else
                    isIllSection.IsVisible = false;
            };

            isTakingDrugs.SelectedIndexChanged += (sender, args) =>
            {
                if (isTakingDrugs.SelectedIndex == 1)
                    isTakingDrugsSection.IsVisible = true;
                else
                    isTakingDrugsSection.IsVisible = false;
            };

            otherSymptoms.SelectedIndexChanged += (sender, args) =>
            {
                if (otherSymptoms.SelectedIndex == 1)
                    otherSection.IsVisible = true;
                else
                    otherSection.IsVisible = false;
            };

            //I glowny Page
            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = isIll.Title
                        },
                        isIll,
                        isIllSection,

                        new Label
                        {
                            Text = otherSymptoms.Title
                        },
                        otherSymptoms,
                        otherSection
                    }
                } //StackLayout
            }; // ScrollView
        }
    }
}