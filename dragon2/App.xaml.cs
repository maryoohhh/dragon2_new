using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace dragon2
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
            new Label {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Dragon"
                      }
                }
            };

            MainPage = new ContentPage
            {
                Content = layout
            };

            Button button = new Button
            {
                Text = "Create character"
            };

            button.Clicked += async (s, e) =>
            {
                await MainPage.DisplayAlert("Alert", "You clicked me", "OK");
            };

            Button button2 = new Button
            {
                Text = "Character list"
            };

            button2.Clicked += async (s, e) =>
            {
                await MainPage.DisplayAlert("Alert", "You clicked me", "OK");
            };

            layout.Children.Add(button);
            layout.Children.Add(button2);
        }
    }
}