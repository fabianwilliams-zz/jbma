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

    }
}
