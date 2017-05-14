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
    public class DrgawkiPage : ContentPage
    {
        public DrgawkiPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker hasEpilepsy = new Picker
            {
                Title = "Czy poszkodowany choruje na epilepsję?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker convulsionsBefore = new Picker
            {
                Title = "Czy był już kiedyś incydent drgawek?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker isTakingEpilepsyDrugs = new Picker
            {
                Title = "Czy przyjmuje z tego powodu leki?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker breathingProblems = new Picker
            {
                Title = "Czy ma trudności w oddychaniu?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker doneExcrement = new Picker
            {
                Title = "Czy oddał bezwiednie mocz lub stolec?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker isInjured = new Picker
            {
                Title = "Czy doszło do urazu?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker headInjury = new Picker
            {
                Title = "Czy doszło w ostatnim czasie do urazu głowy?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker hadNeuroSurgery = new Picker
            {
                Title = "Czy poszkodowany przechodził zabiegi neurochirurgiczne?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker isTakingDrugs = new Picker
            {
                Title = "Czy przyjmuje jakieś leki?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker otherSymptoms = new Picker
            {
                Title = "Czy widzisz dodatkowe niepokojące objawy?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            //Sekcje, których widoczność będzie ulegać zmianie
            StackLayout hasEpilepsySection = new StackLayout
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

                    }

                }
            };

            StackLayout hadConvulsionsSection = new StackLayout
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
                        Text = isTakingEpilepsyDrugs.Title
                    },
                    isTakingEpilepsyDrugs
                }
            };

            StackLayout noEpilepsySection = new StackLayout
            {
                IsVisible = true, //Domyślnie widoczne
                Children =
                {
                    new Label
                    {
                        Text = convulsionsBefore.Title
                    },
                    convulsionsBefore,
                   hadConvulsionsSection
                }
            };

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
                        Text = "Wskaż miejsce urazu:"
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

            //Eventy pickerów, które wpływają na zmianę widoczności sekcji
            hasEpilepsy.SelectedIndexChanged += (sender, args) =>
            {
                if (hasEpilepsy.SelectedIndex == 1)
                {
                    hasEpilepsySection.IsVisible = true;
                    noEpilepsySection.IsVisible = false;
                }
                else if (hasEpilepsy.SelectedIndex == 2)
                {
                    hasEpilepsySection.IsVisible = false;
                    noEpilepsySection.IsVisible = true;
                }
                else
                {
                    hasEpilepsySection.IsVisible = false;
                    noEpilepsySection.IsVisible = false;
                }
            };

            convulsionsBefore.SelectedIndexChanged += (sender, args) =>
            {
                if (convulsionsBefore.SelectedIndex == 1)
                    hadConvulsionsSection.IsVisible = true;
                else
                    hadConvulsionsSection.IsVisible = false;
            };

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
                    isInjuredSection.IsVisible = true;
                else
                    isInjuredSection.IsVisible = false;
            };

            headInjury.SelectedIndexChanged += (sender, args) =>
            {
                if (headInjury.SelectedIndex == 1)
                    headInjurySection.IsVisible = true;
                else
                    headInjurySection.IsVisible = false;
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
                            Text = hasEpilepsy.Title
                        },
                        hasEpilepsy,
                        hasEpilepsySection,
                        noEpilepsySection,

                        new Label
                        {
                            Text = breathingProblems.Title
                        },
                        breathingSection,

                        new Label
                        {
                            Text = doneExcrement.Title
                        },
                        doneExcrement,

                        new Label
                        {
                            Text = isInjured.Title
                        },
                        isInjured,
                        isInjuredSection,

                        new Label
                        {
                            Text = headInjury.Title
                        },
                        headInjury,
                        headInjurySection,

                        new Label
                        {
                            Text = hadNeuroSurgery.Title
                        },
                        hadNeuroSurgery,

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