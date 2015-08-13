using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Jailbreak.View
{
    public class ConnectPage : ContentPage
    {
        public ConnectPage()
        {

            Title = "Connect with Jailbreak";

            var untapddButton = new Button()
            {
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                Text = "Untappd "
            };

            var shareBeerPicButton = new Button()
            {
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                Text = "Share Beer"
            };

            var meetTeamButton = new Button()
            {
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                Text = "Meet our Team"
            };

			untapddButton.Clicked += (sender, e) => {
				Navigation.PushAsync(new Auth0Login());
			};

            meetTeamButton.Clicked += (sender, e) => {
                Navigation.PushAsync(new JBTeamApp().GetTeamMembers());
            };


            Content = new StackLayout
            {
                Spacing = 3,
                Children = {
                    untapddButton,meetTeamButton,shareBeerPicButton
                }
            };
        }

//		protected async override void OnAppearing()
//		{
//			base.OnAppearing();
//			await this.RefreshAsync();
//		}
//
//		private async Task RefreshAsync()
//		{
//			var als = new Auth0LoginService ();
//			var au = await als.GetAuth0UserAsync ();
//			//			Items = await beerService.GetAllTodoItems ();
////			listView.ItemsSource = au;
////
////			var cell = new DataTemplate(typeof(TextCell));
////			//use the two lines below if you want to use the default text property
////			//cell.SetBinding(TextCell.TextProperty, "Name"); //the word Text here represents the field in the Database we want returned
////			//listView.ItemTemplate = cell;
////			//end two lines commentary
////
////			listView.ItemTemplate = new DataTemplate(typeof(ListOfBeerCell2)); //this uses my customized cell to make 2 items in 1 row
////
////
//		}

    }
}
