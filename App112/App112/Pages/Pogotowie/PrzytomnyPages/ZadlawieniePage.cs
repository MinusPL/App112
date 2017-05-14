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
    public class ZadlawieniePage : ContentPage
    {
        public ZadlawieniePage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker whatHappened = new Picker
            {
                Title = "Co się stało?",
                Items = {"Zakrztuszenie", "Zachłyśnięcie"},
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

            Picker isDizzy = new Picker
            {
                Title = "Czy występują zawroty głowy lub zaburzenia równowagi?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker isVomit = new Picker
            {
                Title = "Czy występują nudności lub wymioty?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker isPain = new Picker
            {
                Title = "Czy poszkodowany zgłasza dolegliwości bólowe?",
                Items = {"Nie wiem", "Tak", "Nie"},
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

            StackLayout foodChokingSection = new StackLayout {
                IsVisible = true, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = "Czym?"
                    },
                    new Entry
                    {

                    }

                }
            };

            StackLayout waterChokingSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = "W jakich okolicznościach?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout isPainSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = "Jaki to ból?"
                    },
                    new Entry
                    {

                    },
                    new Label
                    {
                        Text = "Od kiedy?"
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

            whatHappened.SelectedIndexChanged += (sender, args) =>
            {
                if (whatHappened.SelectedIndex == 1)
                {
                    waterChokingSection.IsVisible = true;
                    foodChokingSection.IsVisible = false;
                }
                else
                {
                    waterChokingSection.IsVisible = false;
                    foodChokingSection.IsVisible = true;
                }
            };

            isPain.SelectedIndexChanged += (sender, args) =>
            {
                if (isPain.SelectedIndex == 1)
                    isPainSection.IsVisible = true;
                else
                    isPainSection.IsVisible = false;
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
                            Text = whatHappened.Title
                        },
                        whatHappened,
                        foodChokingSection,
                        waterChokingSection,

                        new Label
                        {
                            Text = "Jaki jest wiek poszkodowanego?"
                        },
                        new Entry
                        {

                        },

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
                            Text = isDizzy.Title
                        },
                        isDizzy,

                        new Label
                        {
                            Text = isVomit.Title
                        },
                        isVomit,

                        new Label
                        {
                            Text = isPain.Title
                        },
                        isPain,
                        isPainSection,

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