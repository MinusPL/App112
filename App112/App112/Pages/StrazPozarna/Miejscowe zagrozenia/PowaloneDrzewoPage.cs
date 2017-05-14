using System;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591

    public class PowaloneDrzewoPage : ContentPage
    {
        public PowaloneDrzewoPage()
        {
#pragma warning restore 1591
            TableView form = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot {
                        new TableSection {
                            new ViewCell() {
                                View = new Picker {
                                    Title = "W jakim stanie jest drzewo?",
                                    Items = {"Pochylone", "Powalone"}
                                }
                            },
                            new ViewCell() {
                                View = new Picker {
                                    Title = "Gdzie opadło drzewo?",
                                    Items = {"Na drogę", "Na samochód", "Na budynek", "Inne"}
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