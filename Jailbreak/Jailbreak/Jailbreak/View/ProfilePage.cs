using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Jailbreak.View
{
    public class ProfilePage : BaseContentPage
    {
        public ProfilePage()
        {
            // Using messaging center to ensure that content only gets loaded once authentication is successful.
            // Once Xamarin.Forms adds more support for view life cycle events, this kind of thing won't be as necessary.
            // The OnAppearing() and OnDisappearing() overrides just don't quite cut the mustard yet, nor do the Appearing and Disappearing delegates.
            MessagingCenter.Subscribe<App>(this, "Authenticated", (sender) => {
                Content = new Label()
                {
                    Text = "Profile Page -- Access Granted> Token is: " + App.Instance.CurrentUserToken,
                    XAlign = TextAlignment.Center,
                    YAlign = TextAlignment.Center
                };
            });
        }
    }
}
