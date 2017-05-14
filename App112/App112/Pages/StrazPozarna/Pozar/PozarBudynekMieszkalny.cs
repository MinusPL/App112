using System;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591

    public class PozarBudynekMieszkalny : ContentPage {
        public PozarBudynekMieszkalny()
        {
#pragma warning restore 1591
        TableSection previousSection;
        TableSection nowSection;
        Picker isOneFamilyHouse = new Picker {
                Title = "Jaki budynek się pali?",
                Items = {"Dom jednorodzinny", "Blok"},
            };

            TableView form = new TableView {
                Intent = TableIntent.Form,
                Root = new TableRoot {
                    new TableSection {
                        new ViewCell {
                            View = isOneFamilyHouse
                        }
                    },
                    // Dom jednorodzinny
                    new TableSection {
                        new SwitchCell {
                            Text = "Czy jest to pożar sadzy w kominie?",
                        },
                        new ViewCell() {
                            View = new Picker {
                                Title = "Rodzaj budynku",
                                Items = {"Dom murowany", "Dom murowany"}
                            }
                        },
                        new EntryCell {
                            Label = "Ilość kondygnacji",
                            Keyboard = Keyboard.Numeric,
                            Text = "1"
                        },
                        new EntryCell {
                            Label = "Ilość osób poszkodowanych",
                            Keyboard = Keyboard.Numeric,
                            Text = "0"

                        },
                        new EntryCell {
                            Label = "Ilość osób uwięzionych",
                            Keyboard = Keyboard.Numeric,
                            Text = "0"
                        }
                    },
                    // Blok
                    new TableSection {
                        new EntryCell {
                            Label = "Ile pięter ma budynek?",
                            Keyboard = Keyboard.Numeric,
                            Text = "4"
                        },
                        new EntryCell {
                            Label = "Na którym piętrze występuje pożar?",
                            Keyboard = Keyboard.Numeric,
                            Text = "2"
                        },
                        new EntryCell {
                            Label = "Ilość osób poszkodowanych",
                            Keyboard = Keyboard.Numeric,
                            Text = "0"

                        },
                        new EntryCell {
                            Label = "Ilość osób uwięzionych",
                            Keyboard = Keyboard.Numeric,
                            Text = "0"
                        }
                    }
                }
            };

            previousSection = form.Root[2];
            nowSection = form.Root[1];

            isOneFamilyHouse.SelectedIndexChanged += (sender, args) => {
                form.Root[1] = previousSection;
                previousSection = nowSection;
                nowSection = form.Root[1];
            };
            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = form
            }; // ScrollView
        } // constructor
    } // class
} // namespace