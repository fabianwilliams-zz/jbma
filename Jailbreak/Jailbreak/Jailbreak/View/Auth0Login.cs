using System;
using Xamarin.Forms;

namespace Jailbreak
{
	public class Auth0Login : ContentPage
	{
		public Auth0Login ()
		{
			Label header = new Label
			{
				Text = "Connect with Untappd",
				FontSize = 25,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Center
			};

			WebView webView = new WebView
			{
				Source = new UrlWebViewSource
				{
					Url = "https://adotob.auth0.com/authorize?response_type=token&scope=openid&client_id=prt0oxC0CEIB0r9dImcKtx4pCupRJk55&redirect_uri=https://adotob.auth0.com/mobile&connection=untappd",
				},
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			// Build the page.
			this.Content = new StackLayout
			{
				Children = 
				{
					header,
					webView
				}
				};
		}
	}
}

