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
    public class DusznoscPage : ContentPage
    {
        public DusznoscPage()
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

            Picker bruisedLips = new Picker
            {
                Title = "Czy usta są zasinione?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker bruises = new Picker
            {
                Title = "Czy zasiniona jest któraś z kończyn?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker paleSkin = new Picker
            {
                Title = "Czy osoba ma bladą skórę?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker coughs = new Picker
            {
                Title = "Czy osoba kaszle?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker bloodInCough = new Picker
            {
                Title = "Czy występuje krew w plwocinach?",
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
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker injuredChest = new Picker
            {
                Title = "Czy poszkodowany doznał obrażeń wokół szyi lub klatki piersiowej?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker beforeDysponea = new Picker
            {
                Title = "Czy napady duszności występowały wcześniej?",
                Items = {"Nie wiem", "Tak", "Nie"},
                SelectedIndex = 0
            };

            Picker intensityOfDysponea = new Picker
            {
                Title = "Czy obecny napad duszności ma podobne natężenie w porównaniu z ostatnim razem?",
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
           /* StackLayout isTakingDrugsSection = new StackLayout
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
            };*/

            StackLayout bloodInCoughSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = bloodInCough.Title
                    },
                    bloodInCough
                }
            };

            StackLayout intensityOfDysponeaSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = {
                    new Label
                    {
                        Text = intensityOfDysponea.Title
                    },
                    intensityOfDysponea
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

            /*isIll.SelectedIndexChanged += (sender, args) =>
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
            };*/

            coughs.SelectedIndexChanged += (sender, args) =>
            {
                if (coughs.SelectedIndex == 1)
                    bloodInCoughSection.IsVisible = true;
                else
                    bloodInCoughSection.IsVisible = false;
            };

            beforeDysponea.SelectedIndexChanged += (sender, args) =>
            {
                if (beforeDysponea.SelectedIndex == 1)
                    intensityOfDysponeaSection.IsVisible = true;
                else
                    intensityOfDysponeaSection.IsVisible = false;
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

                        new Label
                        {
                            Text = isTakingDrugs.Title
                        },
                        isTakingDrugs,

                        new Label
                        {
                            Text = "Jak długo trwa duszność?"
                        },
                        new Entry
                        {

                        },

                        new Label
                        {
                            Text = bruisedLips.Title
                        },
                        bruisedLips,

                        new Label
                        {
                            Text = bruises.Title
                        },
                        bruises,

                        new Label
                        {
                            Text = paleSkin.Title
                        },
                        paleSkin,

                        new Label
                        {
                            Text = coughs.Title
                        },
                        coughs,
                        bloodInCoughSection,

                        new Label
                        {
                            Text = speakingProblems.Title
                        },
                        speakingProblems,

                        new Label
                        {
                            Text = consciousness.Title
                        },
                        consciousness,

                        new Label
                        {
                            Text = injuredChest.Title
                        },
                        injuredChest,

                        new Label
                        {
                            Text = beforeDysponea.Title
                        },
                        beforeDysponea,
                        intensityOfDysponeaSection,
                        
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