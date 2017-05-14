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
    public class AlergiaPage : ContentPage
    {
        public AlergiaPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker breathingProblems = new Picker
            {
                Title = "Czy ma trudności w oddychaniu?",
                Items = { "Nie", "Duszność", "Świszczący Oddech" },
                SelectedIndex = 0
            };

            Picker knowsKindOfAllergy = new Picker
            {
                Title = "Czy wiesz, na co poszkodowany ma alergię?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker isSwelling = new Picker
            {
                Title = "Czy występują jakieś obrzęki?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker hasSkinProblems = new Picker
            {
                Title = "Czy występują dodatkowe objawy na skórze?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker hasSpeakingProblems = new Picker
            {
                Title = "Czy poszkodowany ma trudności w mówieniu lub połykaniu?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker isIll = new Picker
            {
                Title = "Czy poszkodowany przebywa jakąś chorobę?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker hasBracelet = new Picker
            {
                Title = "Czy poszkodowany posiada bransoletkę medyczną?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker otherSymptoms = new Picker
            {
                Title = "Czy widzisz dodatkowe niepokojące objawy?",
                Items = {"Nie", "Tak"},
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

            StackLayout allergyKindSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Określ, na co:"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout swellingSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Podaj lokalizację obrzęków:"
                    },
                    new Entry
                    {

                    },
                    new Label
                    {
                        Text = "Od kiedy występują obrzęki?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout skinSection = new StackLayout
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

            StackLayout illSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Na co?"
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

            StackLayout braceletSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Co jest na niej napisane?"
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

            knowsKindOfAllergy.SelectedIndexChanged += (sender, args) =>
            {
                if (knowsKindOfAllergy.SelectedIndex == 1)
                    allergyKindSection.IsVisible = true;
                else
                    allergyKindSection.IsVisible = false;
            };

            isSwelling.SelectedIndexChanged += (sender, args) =>
            {
                if (isSwelling.SelectedIndex == 1)
                    swellingSection.IsVisible = true;
                else
                    swellingSection.IsVisible = false;
            };

            hasSkinProblems.SelectedIndexChanged += (sender, args) =>
            {
                if (hasSkinProblems.SelectedIndex == 1)
                    skinSection.IsVisible = true;
                else
                    skinSection.IsVisible = false;
            };

            isIll.SelectedIndexChanged += (sender, args) =>
            {
                if (isIll.SelectedIndex == 1)
                    illSection.IsVisible = true;
                else
                    illSection.IsVisible = false;
            };

            hasBracelet.SelectedIndexChanged += (sender, args) =>
            {
                if (hasBracelet.SelectedIndex == 1)
                    braceletSection.IsVisible = true;
                else
                    braceletSection.IsVisible = false;
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
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = breathingProblems.Title
                        },
						breathingProblems,	//Tu wstawiam Pickery
						breathingSection,

                        new Label
                        {
                            Text = knowsKindOfAllergy.Title
                        },
						knowsKindOfAllergy,
						allergyKindSection,

                        new Label
                        {
                            Text = isSwelling.Title
                        },
						isSwelling,
						swellingSection,

                        new Label
                        {
                            Text = hasSkinProblems.Title
                        },
						hasSkinProblems,
						skinSection,

                        new Label
                        {
                            Text = hasSpeakingProblems.Title
                        },
						hasSpeakingProblems,

                        new Label
                        {
                            Text = isIll.Title
                        },
						isIll,
						illSection,

                        new Label
                        {
                            Text = hasBracelet.Title
                        },
						hasBracelet,
						braceletSection,

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