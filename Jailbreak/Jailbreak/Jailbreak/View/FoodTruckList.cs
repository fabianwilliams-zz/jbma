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
   public class FoodTruckList : ContentPage
    {
        ListView lv;

        public FoodTruckList()
        {
            Title = "Food Truck Schedule";

            lv = new ListView();

            var cell = new DataTemplate(typeof(TextCell));
            //use the two lines below if you want to use the default text property
            //cell.SetBinding(TextCell.TextProperty, "summary"); //the word Text here represents the field in the Database we want returned
            //lv.ItemTemplate = cell;
            //end two lines commentary

            lv.ItemTemplate = new DataTemplate(typeof(JBEventCell));

            lv.ItemSelected += (sender, e) => {
                Navigation.PushAsync(new EventDetails(e.SelectedItem as JBEvent.Item));
            };

            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(0, 0, 0), 0, 0),
                Spacing = 3,
                Orientation = StackOrientation.Vertical,
                Children = {
                    lv
                }
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await this.CallJBGoogleCalendarAsync();
        }

        public async Task CallJBGoogleCalendarAsync()
        {
            var jbges = new JailBreakGoogleEventsService();
            var gba = await jbges.GetJBFoodTrucksAsync();
            lv.ItemsSource = gba.items;
        }

    }
}
