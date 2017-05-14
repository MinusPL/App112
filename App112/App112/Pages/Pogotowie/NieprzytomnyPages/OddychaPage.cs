using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using static App112.App;

namespace App112
{
#pragma warning disable 1591
    public class OddychaPage : ContentPage
    {
        public OddychaPage()
        {
#pragma warning restore 1591

            // TWORZĘ SOBIE PICKERY - ktore mi beda potrzebne
            Picker problemsWithBreathing = new Picker {
                Title = "Czy ma trudnosci w Oddychaniu",
                Items = {"Nie", "Duszność", "Świszczący Oddech"},
                SelectedIndex = 0 //Pierwsza wybrana opcja
            };

            Picker hasInjuries = new Picker {
                Title = "Czy ma jakieś obrażenia?",
                Items = {"Nie", "Tak"}, //Staraj sie nie dawac na poczatek
                SelectedIndex = 0
            };

            Picker isBleeding = new Picker {
                Title = "Czy widoczne są jakieś krwawienia?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker isVoimiting = new Picker {
                Title = "Czy widać wymiociny?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker isSick = new Picker {
                Title = "Czy ta osoba na coś choruje?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            Picker isTakingDrugs = new Picker {
                Title = "Czy bierze leki?",
                Items = {"Nie", "Tak"},
                SelectedIndex = 0
            };

            //Teraz tworze sobie sekcje ktore beda sie ukrywac
            StackLayout injuriesSection = new StackLayout {
                IsVisible = false, //Domyslnie ukryte
                Children = { //Elementy w sekcji
                    new Label {
                        Text = "Wpisz jakie to obrażenia"
                    },
                    new Entry {
                        
                    }
                }
            };

            StackLayout bleedingSection = new StackLayout {
                IsVisible = false,
                Children = {
                    new Label {
                        Text = "Wpisz skąd to krwawienie"
                    },
                    new Entry {

                    }
                }
            };

            //Sekcja ktora bedzie zagniezdzona w drugiej
            StackLayout drugsSection = new StackLayout()
            {
                IsVisible = false,
                Children = {
                    
                }
            };

            StackLayout sickPersonSection = new StackLayout {
                IsVisible = false,
                Children = {
                    new Label {
                        Text = "Czy bierze leki?"
                    },
                    isTakingDrugs, //Zagniezdzam sobie sekcje - picker do opcji
                    drugsSection //Zagniezdzona sekcja
                }
            };

            //A to juz sa Eventy pickerow ktore reaguja na zmiane
            hasInjuries.SelectedIndexChanged += (sender, args) => {
                if (hasInjuries.SelectedIndex == 1)
                    injuriesSection.IsVisible = true;
                else
                    injuriesSection.IsVisible = false;
            };

            isBleeding.SelectedIndexChanged += (sender, args) => {
                if (isBleeding.SelectedIndex == 1)
                    bleedingSection.IsVisible = true;
                else
                    bleedingSection.IsVisible = false;
            };

            isSick.SelectedIndexChanged += (sender, args) => {
                if (isSick.SelectedIndex == 1)
                    sickPersonSection.IsVisible = true;
                else
                    sickPersonSection.IsVisible = false;
            };

            isTakingDrugs.SelectedIndexChanged += (sender, args) => {
                if (isTakingDrugs.SelectedIndex == 1)
                    drugsSection.IsVisible = true;
                else
                    drugsSection.IsVisible = false;
            };

            //I glowny Page
            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = "Czy ma problemy z oddychaniem?"
                        },
                        problemsWithBreathing, //Tu wstawiam Pickery
                        new Label {
                            Text = "Czy ma jakieś obrażenia?"
                        },
                        hasInjuries, //Tu Tez Picker
                        injuriesSection, //A tu sekcja
                        new Label {
                            Text = "Czy widać jakieś krwawienia?"
                        },
                        isBleeding,
                        bleedingSection,
                        new Label {
                            Text = "Czy widzisz wymiociny?"
                        },
                        isVoimiting,
                        new Label {
                            Text = "Czy osoba na coś choruje?"
                        },
                        isSick,
                        sickPersonSection,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Stan", "Nieprzytomny"),
                                        new KeyValuePair<string, string>("Oddech", "Oddycha")
                                    };
                                
                                messageDetails.Add(new KeyValuePair<string, string>("Problemy z oddychaniem", problemsWithBreathing.Items[problemsWithBreathing.SelectedIndex]));
                                messageDetails.Add(new KeyValuePair<string, string>("Obrażenia", hasInjuries.Items[hasInjuries.SelectedIndex]));
                                if (hasInjuries.SelectedIndex != 0) {
                                    Entry entry = (Entry) injuriesSection.Children[1];
                                    messageDetails.Add(new KeyValuePair<string, string>("Jakie obrazenia?", entry.Text));
                                }
                                messageDetails.Add(new KeyValuePair<string, string>("Krwotoki", isBleeding.Items[hasInjuries.SelectedIndex]));
                                if (isBleeding.SelectedIndex != 0) {
                                    Entry entry = (Entry) bleedingSection.Children[1];
                                    messageDetails.Add(new KeyValuePair<string, string>("Skąd krwotok?", entry.Text));
                                }
                                messageDetails.Add(new KeyValuePair<string, string>("Wymiociny", isVoimiting.Items[isVoimiting.SelectedIndex]));
                                messageDetails.Add(new KeyValuePair<string, string>("Czy choruje", isSick.Items[isSick.SelectedIndex]));
                                if (isSick.SelectedIndex != 0) {
                                    messageDetails.Add(new KeyValuePair<string, string>("Bierze leki", isTakingDrugs.Items[isTakingDrugs.SelectedIndex]));
                                    if (isTakingDrugs.SelectedIndex != 0) {
                                        Entry entry = (Entry) drugsSection.Children[1];
                                        messageDetails.Add(new KeyValuePair<string, string>("Jakie leki", entry.Text));
                                    }
                                }
                            })
                        }
                    }
                } //StackLayout
            }; // ScrollView
        }
    }
}