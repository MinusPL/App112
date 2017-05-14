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
    public class UrazyPage : ContentPage
    {
        public UrazyPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker breathingProblems = new Picker
            {
                Title = "Czy ma trudności w oddychaniu?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker bleeding = new Picker
            {
                Title = "Czy występuje krwotok?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker isLimb = new Picker
            {
                Title = "Czy urazowi uległa kończyna?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker isAmputated = new Picker
            {
                Title = "Czy doszło do amputacji?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker noFeel = new Picker
            {
                Title = "Czy występuje niedowład lub brak czucia?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker consciousness = new Picker
            {
                Title = "Czy występują zaburzenia świadomości?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker speakingProblems = new Picker
            {
                Title = "Czy występują zaburzenia mowy lub widzenia?",
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
                        Text = "Określ, jakie:"
                    },
                    new Entry
                    {

                    }

                }
            };


            
            StackLayout bleedingSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = "Od kiedy?"
                    },
                    new Entry
                    {

                    },

                    new Label
                    {
                        Text = "Jak mocny?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout notAmputatedSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = noFeel.Title
                    },
                    noFeel
                }
            };

            StackLayout isLimbSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = isAmputated.Title
                    },
                    isAmputated,
                    notAmputatedSection
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

            breathingProblems.SelectedIndexChanged += (sender, args) =>
            {
                if (breathingProblems.SelectedIndex == 1)
                    breathingSection.IsVisible = true;
                else
                    breathingSection.IsVisible = false;
            };

            bleeding.SelectedIndexChanged += (sender, args) =>
            {
                if (bleeding.SelectedIndex == 1)
                    bleedingSection.IsVisible = true;
                else
                    bleedingSection.IsVisible = false;
            };

            isLimb.SelectedIndexChanged += (sender, args) =>
            {
                if (isLimb.SelectedIndex == 1)
                    isLimbSection.IsVisible = true;
                else
                    isLimbSection.IsVisible = false;
            };

            isAmputated.SelectedIndexChanged += (sender, args) =>
            {
                if (isAmputated.SelectedIndex == 2)
                    notAmputatedSection.IsVisible = true;
                else
                    notAmputatedSection.IsVisible = false;
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
                            Text = breathingProblems.Title
                        },
                        breathingProblems,
                        breathingSection,

                        new Label
                        {
                            Text = "Jak doszło do urazu?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = bleeding.Title
                        },
                        bleeding,
                        bleedingSection,

                        new Label
                        {
                            Text = "Podaj lokalizację urazu"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = isLimb.Title
                        },
                        isLimb,
                        new Label
                        {
                            Text = "Podaj lokalizację urazu"
                        },
                        new Entry
                        {

                        },
                        isLimbSection,

                        new Label
                        {
                            Text = consciousness.Title
                        },
                        consciousness,

                        new Label
                        {
                            Text = speakingProblems.Title
                        },

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