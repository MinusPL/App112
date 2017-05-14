using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112
{
#pragma warning disable 1591
    public class MZUwiezioneZwierze : ContentPage
    {
        public MZUwiezioneZwierze()
        {
#pragma warning restore 1591
            Picker inWhatWay = new Picker {
                Title = "W jaki sposób zostało uwięzione?",
                Items = {"W otworze", "Na drzewie", "W Studni", "Zaplątane w ogrodzenie", "Na sidłach"},
                SelectedIndex = 0
            };

            Title = "Opisz szczegóły zdarzenia";
            Content = new ScrollView
            {
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = inWhatWay.Title,
                            VerticalTextAlignment = TextAlignment.End,
                            FontSize = 18
                        },
                        inWhatWay,
                        new Button {
                            Text = "Zatwierdź",
                            Command = new Command(() => {
                                List<KeyValuePair<string, string>> messageDetails =
                                    new List<KeyValuePair<string, string>> {
                                        new KeyValuePair<string, string>("Kategioria", "MiejscoweZagrozenie"),
                                        new KeyValuePair<string, string>("Podkategoria", "UwiezioneZwierze")
                                    };

                                messageDetails.Add(new KeyValuePair<string, string>("Jak", inWhatWay.Items[inWhatWay.SelectedIndex]));

                                throw new NotImplementedException();
                            })
                        }
                    }
                }
            }; // ScrollView
        }
    }
}