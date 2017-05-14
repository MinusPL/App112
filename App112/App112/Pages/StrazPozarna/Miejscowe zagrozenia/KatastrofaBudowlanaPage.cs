using System;
using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591

    public class KatastrofaBudowlanaPage : ContentPage
    {
        public KatastrofaBudowlanaPage()
        {
#pragma warning restore 1591
            TableView form = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot {
                    new TableSection {
                        new SwitchCell {
                            Text = "Czy doszło do zawalenia budynku?",
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