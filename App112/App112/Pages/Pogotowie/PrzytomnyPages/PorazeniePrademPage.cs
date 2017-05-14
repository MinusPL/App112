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
    public class PorazeniePrademPage : ContentPage
    {
        public PorazeniePrademPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker breathingProblems = new Picker
            {
                Title = "Czy ma trudności w oddychaniu?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker isInjured = new Picker
            {
                Title = "Czy widzisz jakieś obrażenia?",
                Items = { "Nie", "Tak" },
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

            Picker movingLimbs = new Picker
            {
                Title = "Czy porusza kończynami i ma zachowane czucie?",
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

            StackLayout injuredSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = "Określ rodzaj obrażeń:"
                    },
                    new Entry
                    {

                    },

                    new Label
                    {
                        Text = "Podaj lokalizację"
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
            breathingProblems.SelectedIndexChanged += (sender, args) =>
            {
                if (breathingProblems.SelectedIndex == 1)
                    breathingSection.IsVisible = true;
                else
                    breathingSection.IsVisible = false;
            };

            isInjured.SelectedIndexChanged += (sender, args) =>
            {
                if (isInjured.SelectedIndex == 1)
                    injuredSection.IsVisible = true;
                else
                    injuredSection.IsVisible = false;
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
                            Text = isInjured.Title
                        },
                        isInjured,
                        injuredSection,

                        new Label
                        {
                            Text = consciousness.Title
                        },
                        consciousness,

                        new Label
                        {
                            Text = speakingProblems.Title
                        },
                        speakingProblems,

                        new Label
                        {
                            Text = movingLimbs.Title
                        },
                        movingLimbs,

                        new Label
                        {
                            Text = "Jakie zgłasza dolegliwości?"
                        },
                        new Entry
                        {

                        },

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