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
    public class BeerListView : ContentPage
    {
        private ListView listView;
        //private BeerService beerService;

        public List<Beer> Items { get; private set; }

        public BeerListView()
        {


            listView = new ListView
            {
                //				HasUnevenRows = true

            };

            //need to add a Details Push Event on the ITemSelected here when working done
            listView.ItemSelected += (sender, e) => {
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

            this.Title = "All our Beers on Tap";
            this.Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(0, 0, 0), 0, 0),
                Spacing = 3,
                Orientation = StackOrientation.Vertical,
                Children = {
                    indicator,
                    listView
                }
            };

            indicator.IsRunning = false;
            indicator.IsVisible = false;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await this.RefreshAsync();
        }

        private async Task RefreshAsync()
        {
            var jbms = new JailBreakBeerMongoService();
            var gba = await jbms.GetBeersAsync();
            //			Items = await beerService.GetAllTodoItems ();
            listView.ItemsSource = gba;

            var cell = new DataTemplate(typeof(TextCell));
            //use the two lines below if you want to use the default text property
            //cell.SetBinding(TextCell.TextProperty, "Name"); //the word Text here represents the field in the Database we want returned
            //listView.ItemTemplate = cell;
            //end two lines commentary

            listView.ItemTemplate = new DataTemplate(typeof(ListOfBeerCell2)); //this uses my customized cell to make 2 items in 1 row


        }

    }
}
