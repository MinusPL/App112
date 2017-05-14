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
    public class BolKonczynyPage : ContentPage
    {
        public BolKonczynyPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker isInjured = new Picker
            {
                Title = "Czy doszło do urazu?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker numbness = new Picker
            {
                Title = "Czy występuje drętwienie kończyn?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker breathingProblems = new Picker
            {
                Title = "Czy ma trudności w oddychaniu?",
                Items = { "Nie", "Duszność", "Świszczący Oddech" },
                SelectedIndex = 0
            };

            Picker tookPainkillers = new Picker
            {
                Title = "Czy osoba przyjmowała leki przeciwbólowe?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker tookAnticoagulants = new Picker
            {
                Title = "Czy osoba przyjmowała leki przeciwzakrzepowe?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker hadSurgery = new Picker
            {
                Title = "Czy osoba przechodziła operację tej kończyny?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

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
            StackLayout breathingSection = new StackLayout
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

            StackLayout isInjuredSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "W jaki sposób doszło do urazu?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout tookPainkillersSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Kiedy"
                    },
                    new Entry
                    {

                    },
                    new Label
                    {
                        Text = "Jakie?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout tookAnticoagulantsSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Kiedy"
                    },
                    new Entry
                    {

                    },
                    new Label
                    {
                        Text = "Jakie?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout hadSurgerySection = new StackLayout
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

            isInjured.SelectedIndexChanged += (sender, args) =>
            {
                if (isInjured.SelectedIndex == 1)
                    isInjuredSection.IsVisible = true;
                else
                    isInjuredSection.IsVisible = false;
            };

            breathingProblems.SelectedIndexChanged += (sender, args) =>
            {
                if (breathingProblems.SelectedIndex == 1)
                    breathingSection.IsVisible = true;
                else
                    breathingSection.IsVisible = false;
            };

            tookPainkillers.SelectedIndexChanged += (sender, args) =>
            {
                if (tookPainkillers.SelectedIndex == 1)
                    tookPainkillersSection.IsVisible = true;
                else
                    tookPainkillersSection.IsVisible = false;
            };

            tookAnticoagulants.SelectedIndexChanged += (sender, args) =>
            {
                if (tookAnticoagulants.SelectedIndex == 1)
                    tookAnticoagulantsSection.IsVisible = true;
                else
                    tookAnticoagulantsSection.IsVisible = false;
            };

            hadSurgery.SelectedIndexChanged += (sender, args) =>
            {
                if (hadSurgery.SelectedIndex == 1)
                    hadSurgerySection.IsVisible = true;
                else
                    hadSurgerySection.IsVisible = false;
            };

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
                            Text = "Wskaż obolałą kończynę"
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
                            Text = "W jakich okolicznościach pojawił się ból?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = isInjured.Title
                        },
                        isInjured,
                        isInjuredSection,

                        new Label
                        {
                            Text = numbness.Title
                        },
                        numbness,

                        new Label
                        {
                            Text = breathingProblems.Title
                        },
                        breathingProblems,
                        breathingSection,

                        new Label
                        {
                            Text = tookPainkillers.Title
                        },
                        tookPainkillers,
                        tookPainkillersSection,

                        new Label
                        {
                            Text = hadSurgery.Title
                        },
                        hadSurgery,
                        hadSurgerySection,

                        new Label
                        {
                            Text = tookAnticoagulants.Title
                        },
                        tookAnticoagulants,
                        tookAnticoagulantsSection,

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