using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jailbreak.Model;
using Xamarin.Forms;

namespace Jailbreak.View
{
   public class BeerDetail : ContentPage
    {
        public BeerDetail(Beer b)
        {
            //Padding = new Thickness (0, Device.OnPlatform (10, 10, 10), 0, 0);
            this.Title = b.Name;

            var giftImage = new Image
            {
                Aspect = Aspect.AspectFit,
                BackgroundColor = Color.Gray
            };

            var picUrl = b.Smu;
            if (b.Smu != null)
            {
                giftImage.Source = ImageSource.FromUri(new Uri(picUrl));

            }
            else
            {
                //giftImage.Source = ImageSource.FromUri(new Uri("https://jailbreakbrewing.com/wp-content/uploads/2015/05/SRM-16"));
                giftImage.Source = "infinite_xhalf.png";
            }
            var GiftNameLabel = new Label
            {
                FontAttributes = FontAttributes.Bold,
                Text = b.Name,
                FontSize = 15
            };

            var GiftDesc = new Label
            {
                Text = b.Taste,
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };

            var tweetButton = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                Text = "Tweet about " + b.Name
            };

            var drawingButton = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                Text = "Untappd " + b.Name
            };

            drawingButton.Clicked += async (sender, e) => {
                await DisplayAlert("TBD", "Tap into E-Commerce", "Ok");
            };


            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Spacing = 10,
                    Children = { giftImage, GiftNameLabel, GiftDesc, tweetButton, drawingButton }
                }
            };
        }

    }
}
