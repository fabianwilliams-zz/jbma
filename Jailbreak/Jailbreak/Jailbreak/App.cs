using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jailbreak.View;
using Xamarin.Forms;


namespace Jailbreak
{
    public class App : Application
    {

        public string CurrentUserToken;

        // just a singleton pattern so I can have the concept of an app instance
        static volatile App _Instance;
        static object _SyncRoot = new Object();
        public static App Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_SyncRoot)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new App();
                            _Instance.OAuthSettings =
                                new OAuthSettings(
                                    clientId: "prt0oxC0CEIB0r9dImcKtx4pCupRJk55",       // your OAuth2 client id 
                                    scope: "openid",        // The scopes for the particular API you're accessing. The format for this will vary by API.
                                    authorizeUrl: "https://adotob.auth0.com/authorize",     // the auth URL for the service
                                    redirectUrl: "https://adotob.auth0.com/mobile");   // the redirect URL for the service

                        }
                    }
                }

                return _Instance;
            }
        }

        public OAuthSettings OAuthSettings { get; private set; }

        NavigationPage _NavPage;

        public Page GetMainPage()
        {
            var profilePage = new JBHomePage();

            _NavPage = new NavigationPage(profilePage);

            return _NavPage;
        }

        public bool IsAuthenticated
        {
            get { return !string.IsNullOrWhiteSpace(_Token); }
        }

        string _Token;
        public string Token
        {
            get { return _Token; }
        }

        public void SaveToken(string token)
        {
            _Token = token;
            CurrentUserToken = _Token;
            // broadcast a message that authentication was successful
            MessagingCenter.Send<App>(this, "Authenticated");
        }

        public Action SuccessfulLoginAction
        {
            get
            {
                return new Action(() => _NavPage.Navigation.PopModalAsync());
            }
        }
        /*
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new JBHomePage());
        }
        */
        /*
        public static Page GetMainPage()
        {
            return new NavigationPage(new JBHomePage());
        }
        */
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
