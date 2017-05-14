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
    public class BolBrzuchaPage : ContentPage
    {
        public BolBrzuchaPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker age = new Picker
            {
                Title = "Wskaż wiek osoby",
                Items = {"Nie wiem", "Powyżej 14", "Poniżej 14"},
                SelectedIndex = 0
            };

            Picker gender = new Picker
            {
                Title = "Wskaż płeć osoby",
                Items = {"Mężczyzna","Kobieta"},
                SelectedIndex = 0
            };

            Picker breathingProblems = new Picker
            {
                Title = "Czy ma trudności w oddychaniu?",
                Items = { "Nie", "Duszność", "Świszczący Oddech" },
                SelectedIndex = 0
            };

            Picker isVomitting = new Picker
            {
                Title = "Czy wymiotuje?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker doesExcrement = new Picker
            {
                Title = "Czy wypróżnia się?",
                Items = { "Nie wiem", "Tak", "Nie" },
                SelectedIndex = 0
            };

            Picker hasGases = new Picker
            {
                Title = "Czy odchodzą gazy?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker urinalProblems = new Picker
            {
                Title = "Czy są problemy z oddawaniem moczu?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker bloodInUrine = new Picker
            {
                Title = "Czy występuje krew w moczu?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker beenInTravel = new Picker
            {
                Title = "Czy osoba odbyła podróż do krajów tropikalnych?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker tookPainkillers = new Picker
            {
                Title = "Czy osoba przyjmowała leki przeciwbólowe?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker hadStomachSurgery = new Picker
            {
                Title = "Czy osoba przechodziła operację w okolicy jamy brzusznej?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker isIll = new Picker
            {
                Title = "Czy poszkodowany choruje?",
                Items = {"Nie wiem", "Tak", "Nie"},
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

            StackLayout genderWomanSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Kiedy wystąpiła ostatnia menstruacja?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout ageAbove14Section = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = gender.Title
                    },
                    genderWomanSection
                }
            };

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

            StackLayout didExcrementSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "Jaki rodzaj stolca?"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout noExcrementSection = new StackLayout
            {
                IsVisible = false, //Domyslnie ukryte
                Children =
                {
                    new Label
                    {
                        Text = "label"
                    },
                    new Entry
                    {

                    }
                }
            };

            StackLayout noGasesSection = new StackLayout
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

            StackLayout urinalProblemSection = new StackLayout
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

            StackLayout hadStomachSurgerySection = new StackLayout
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

            age.SelectedIndexChanged += (sender, args) =>
            {
                if (age.SelectedIndex == 1)
                    ageAbove14Section.IsVisible = true;
                else
                    ageAbove14Section.IsVisible = false;
            };

            gender.SelectedIndexChanged += (sender, args) =>
            {
                if (gender.SelectedIndex == 1)
                    genderWomanSection.IsVisible = true;
                else
                    genderWomanSection.IsVisible = false;
            };

            breathingProblems.SelectedIndexChanged += (sender, args) =>
            {
                if (breathingProblems.SelectedIndex == 1)
                    breathingSection.IsVisible = true;
                else
                    breathingSection.IsVisible = false;
            };

            isVomitting.SelectedIndexChanged += (sender, args) =>
            {
                if (isVomitting.SelectedIndex == 1)
                    isVomittingSection.IsVisible = true;
                else
                    isVomittingSection.IsVisible = false;
            };

            doesExcrement.SelectedIndexChanged += (sender, args) =>
            {
                if (doesExcrement.SelectedIndex == 1)
                {
                    didExcrementSection.IsVisible = true;
                    noExcrementSection.IsVisible = false;
                }
                else if (doesExcrement.SelectedIndex == 2)
                {
                    didExcrementSection.IsVisible = false;
                    noExcrementSection.IsVisible = true;
                }
                else
                {
                    didExcrementSection.IsVisible = false;
                    noExcrementSection.IsVisible = false;
                }
            };

            hasGases.SelectedIndexChanged += (sender, args) =>
            {
                if (hasGases.SelectedIndex == 2)
                    noGasesSection.IsVisible = true;
                else
                    noGasesSection.IsVisible = false;
            };

            urinalProblems.SelectedIndexChanged += (sender, args) =>
            {
                if (urinalProblems.SelectedIndex == 1)
                    urinalProblemSection.IsVisible = true;
                else
                    urinalProblemSection.IsVisible = false;
            };

            tookPainkillers.SelectedIndexChanged += (sender, args) =>
            {
                if (tookPainkillers.SelectedIndex == 1)
                    tookPainkillersSection.IsVisible = true;
                else
                    tookPainkillersSection.IsVisible = false;
            };

            hadStomachSurgery.SelectedIndexChanged += (sender, args) =>
            {
                if (hadStomachSurgery.SelectedIndex == 1)
                    hadStomachSurgerySection.IsVisible = true;
                else
                    hadStomachSurgerySection.IsVisible = false;
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
                            Text = "Podaj lokalizację bólu"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = "Od jak dawna występuje ból?"
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
                            Text = age.Title
                        },
                        age,
                        ageAbove14Section,

                        new Label
                        {
                            Text = "Jaki jest charakter bólu?"
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
                            Text = isVomitting.Title
                        },
                        isVomitting,
                        isVomittingSection,

                        new Label
                        {
                            Text = doesExcrement.Title
                        },
                        doesExcrement,
                        didExcrementSection,
                        noExcrementSection,

                        new Label
                        {
                            Text = hasGases.Title
                        },
                        hasGases,
                        noGasesSection,

                        new Label
                        {
                            Text = urinalProblems.Title
                        },
                        urinalProblems,
                        urinalProblemSection,

                        new Label
                        {
                            Text = bloodInUrine.Title
                        },
                        bloodInUrine,

                        new Label
                        {
                            Text = "Jaka jest temperatura ciała?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = "Jak wygląda skóra na ciele?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = beenInTravel.Title
                        },
                        beenInTravel,

                        new Label
                        {
                            Text = tookPainkillers.Title
                        },
                        tookPainkillers,
                        tookPainkillersSection,

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