using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jailbreak.Helper;
using Jailbreak.Model;
using Jailbreak.ViewModel;
using Xamarin.Forms;

namespace Jailbreak.View
{
   public class WhatsOnTapPage : ContentPage
    {
        ListView lv;

        public WhatsOnTapPage()
        {
            Title = "Whats On Tap Today";

            lv = new ListView();

            lv.ItemTemplate = new DataTemplate(typeof(ListOfBeerCell2));

            lv.ItemSelected += (sender, e) => {
                Navigation.PushAsync(new BeerDetail(e.SelectedItem as Beer));
            };

            var indicator = new ActivityIndicator
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Color = Color.Black,
                IsVisible = false
            };

            indicator.IsRunning = true;
            indicator.IsVisible = true;


            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(0, 0, 0), 0, 0),
                Spacing = 3,
                Orientation = StackOrientation.Vertical,
                Children = {
                    lv
                }
            };

            indicator.IsRunning = false;
            indicator.IsVisible = false;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await this.CallMongoDatabaseAsync();
        }

        public async Task CallMongoDatabaseAsync()
        {
            var jbms = new JailBreakBeerMongoService();
            var gba = await jbms.GetOnTapBeersAsync();
            lv.ItemsSource = gba;
        }

    }
}
