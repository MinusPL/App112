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
    public class BolKlatkiPiersiowejPage : ContentPage
    {
        public BolKlatkiPiersiowejPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker doesRadiate = new Picker
            {
                Title = "Czy ten ból promieniuje?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker firstTime = new Picker
            {
                Title = "Czy ból wystąpił pierwszy raz?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker hadStroke = new Picker
            {
                Title = "Czy osoba przechodziła zawał?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker hadSurgery = new Picker
            {
                Title = "Czy poszkodowany przechodził zabiegi kardiochirurgiczne?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker hasCardioverter = new Picker
            {
                Title = "Czy osoba posiada wszczepiony kardiowerter lub rozrusznik?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker isInjured = new Picker
            {
                Title = "Czy w ostatnim czasie doszło do urazu?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker isTakingDrugs = new Picker
            {
                Title = "Czy przyjmuje leki?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker coughPain = new Picker
            {
                Title = "Czy występuje nasilenie objawów przy próbie kaszlu?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker pressurePain = new Picker
            {
                Title = "Czy występuje nasilenie bólu przy ucisku klatki piersiowej?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker otherSymptoms = new Picker
            {
                Title = "Czy widzisz dodatkowe niepokojące objawy?",
                Items = { "Nie", "Tak" },
                SelectedIndex = 0
            };


            //Teraz tworze sobie sekcje ktore beda sie ukrywac
            StackLayout doesRadiateSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Gdzie?"
                    },
                    new Entry
                    {

                    }

                }
            };

            StackLayout hadStrokeSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = "Kiedy?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout hadSurgerySection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = "Jakie?"
                    },
                    new Entry
                    {

                    },
                    new Label
                    {
                        Text = "Kiedy?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout isInjuredSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Kiedy?"
                    },
                    new Entry
                    {

                    },
                    new Label
                    {
                        Text = "W jaki sposób doszło do urazu?"
                    },
                    new Entry
                    {

                    }
                }
            };

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
            doesRadiate.SelectedIndexChanged += (sender, args) =>
            {
                if (doesRadiate.SelectedIndex == 1)
                    doesRadiateSection.IsVisible = true;
                else
                    doesRadiateSection.IsVisible = false;
            };

            hadStroke.SelectedIndexChanged += (sender, args) =>
            {
                if (hadStroke.SelectedIndex == 1)
                    hadStrokeSection.IsVisible = true;
                else
                    hadStrokeSection.IsVisible = false;
            };

            hadSurgery.SelectedIndexChanged += (sender, args) =>
            {
                if (hadSurgery.SelectedIndex == 1)
                    hadSurgerySection.IsVisible = true;
                else
                    hadSurgerySection.IsVisible = false;
            };

            isInjured.SelectedIndexChanged += (sender, args) =>
            {
                if (isInjured.SelectedIndex == 1)
                    isInjuredSection.IsVisible = true;
                else
                    isInjuredSection.IsVisible = false;
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
                            Text = "Podaj lokalizację bólu"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = "Jak długo trwa ból?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = "Jaki jest charakter bólu?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = doesRadiate.Title
                        },
                        doesRadiate,
                        doesRadiateSection,

                        new Label
                        {
                            Text = firstTime.Title
                        },
                        firstTime,

                        new Label
                        {
                            Text = "Co towarzyszy bólowi?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = hadStroke.Title
                        },
                        hadStroke,
                        hadStrokeSection,

                        new Label
                        {
                            Text = hadSurgery.Title
                        },
                        hadSurgery,
                        hadSurgerySection,

                        new Label
                        {
                            Text = hasCardioverter.Title
                        },
                        hasCardioverter,

                        new Label
                        {
                            Text = isInjured.Title
                        },
                        isInjured,
                        isInjuredSection,

                        new Label
                        {
                            Text = isTakingDrugs.Title
                        },
                        isTakingDrugs,
                        isTakingDrugsSection,

                        new Label
                        {
                            Text = coughPain.Title
                        },
                        coughPain,

                        new Label
                        {
                            Text = pressurePain.Title
                        },
                        pressurePain,

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