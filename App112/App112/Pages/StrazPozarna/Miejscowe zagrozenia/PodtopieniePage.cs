using System;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591

    public class PodtopieniePage : ContentPage
    {
        public PodtopieniePage()
        {
#pragma warning restore 1591
            TableView form = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot {
                        new TableSection {
                            new ViewCell() {
                                View = new Picker {
                                    Title = "Co zostało zalane?",
                                    Items = {"Piwnica", "Kondygnacja budynku mieszkalnego", "Posesja", "Pole uprawne lub łąka"}
                                }
                            },
                            new EntryCell {
                                Label = "Ilość osób poszkodowanych",
                                Keyboard = Keyboard.Numeric,
                                Text = "0"
                            }
                        }

                    }
                };

                Title = "Opisz szczegóły zdarzenia";
                Content = new ScrollView
                {
                Content = form
            }; // ScrollView
            } // constructor
        } // class
    } // namespace