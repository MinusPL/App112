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
    public class BolGlowyPage : ContentPage
    {
        public BolGlowyPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker breathingProblems = new Picker
            {
                Title = "Czy ma trudności w oddychaniu?",
                Items = { "Nie", "Duszność", "Świszczący Oddech" },
                SelectedIndex = 0
            };

            Picker consciousness = new Picker
            {
                Title = "Czy występują zaburzenia świadomości?",
                Items = {"Nie wiem","Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker speakingProblems = new Picker
            {
                Title = "Czy występują zaburzenia mowy lub widzenia?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker isDizzy = new Picker
            {
                Title = "Czy występują zawroty głowy lub zaburzenia równowagi?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker numbness = new Picker
            {
                Title = "Czy występuje odrętwienie?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker isVomitting = new Picker
            {
                Title = "Czy wymiotuje?",
                Items = { "Nie", "Tak" },
                SelectedIndex = 0
            };

            Picker headInjury = new Picker
            {
                Title = "Czy doszło w ostatnim czasie do urazu głowy?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker beforePains = new Picker
            {
                Title = "Czy ból występował wcześniej?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker nowState = new Picker
            {
                Title = "Jaki jest obecny stan, w porównaniu do ostatniego?",
                Items = {"Nie wiem","Taki sam", "Nasilony", "Osłabiony"},
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

            StackLayout numbnessSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Określ miejsce:"
                    },
                    new Entry
                    {

                    }

                }
            };

            StackLayout isVomittingSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Od kiedy?"
                    },
                    new Entry
                    {

                    },
                    new Label
                    {
                        Text = "Ile razy?"
                    },
                    new Entry
                    {

                    },
                    new Label
                    {
                        Text = "Jaki jest rodzaj treści?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout headInjurySection = new StackLayout
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

            StackLayout beforePainSection = new StackLayout
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
                        Text = nowState.Title
                    },
                    nowState
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

            breathingProblems.SelectedIndexChanged += (sender, args) =>
            {
                if (breathingProblems.SelectedIndex == 1)
                    breathingSection.IsVisible = true;
                else
                    breathingSection.IsVisible = false;
            };

            numbness.SelectedIndexChanged += (sender, args) =>
            {
                if (numbness.SelectedIndex == 1)
                    numbnessSection.IsVisible = true;
                else
                    numbnessSection.IsVisible = false;
            };

            isVomitting.SelectedIndexChanged += (sender, args) =>
            {
                if (isVomitting.SelectedIndex == 1)
                    isVomittingSection.IsVisible = true;
                else
                    isVomittingSection.IsVisible = false;
            };

            headInjury.SelectedIndexChanged += (sender, args) =>
            {
                if (headInjury.SelectedIndex == 1)
                    headInjurySection.IsVisible = true;
                else
                    headInjurySection.IsVisible = false;
            };

            beforePains.SelectedIndexChanged += (sender, args) =>
            {
                if (beforePains.SelectedIndex == 1)
                    beforePainSection.IsVisible = true;
                else
                    beforePainSection.IsVisible = false;
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
                            Text = "Od kiedy boli?"
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
                            Text = breathingProblems.Title
                        },
                        breathingProblems,
                        breathingSection,

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
                            Text = numbness.Title
                        },
                        numbness,
                        numbnessSection,

                        new Label
                        {
                            Text = isVomitting.Title
                        },
                        isVomitting,
                        isVomittingSection,

                        new Label
                        {
                            Text = headInjury.Title
                        },
                        headInjury,
                        headInjurySection,

                        new Label
                        {
                            Text = "Jaki jest charakter bólu?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = beforePains.Title
                        },
                        beforePains,
                        beforePainSection,

                        new Label
                        {
                            Text = tookPainkillers.Title
                        },
                        tookPainkillers,
                        tookPainkillersSection,

                        new Label
                        {
                            Text = tookAnticoagulants.Title
                        },
                        tookAnticoagulants,
                        tookAnticoagulantsSection,

                        new Label
                        {
                            Text = isTakingDrugs.Title
                        },
                        isTakingDrugs,
                        isTakingDrugsSection,

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