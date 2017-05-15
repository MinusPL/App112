using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App112.Pages
{
    public class HistoryPage : ContentPage
    {
        ListView listView;

        public HistoryPage()
        {
            Title = "Historia zgłoszeń";

            listView = new ListView
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    var label = new Label
                    {
                        VerticalTextAlignment = TextAlignment.Center,
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    };
                    label.SetBinding(Label.TextProperty, "reportDate");

                    var stackLayout = new StackLayout
                    {
                        Margin = new Thickness(0, 0, 0, 0),
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Children = { label }
                    };

                    return new ViewCell { View = stackLayout };
                })
            };

            Content = listView;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            //((App)App.Current).ResumeAtTodoId = -1;
            listView.ItemsSource = await App.Database.GetReports();
        }
    }
}