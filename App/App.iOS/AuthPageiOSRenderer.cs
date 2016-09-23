using System;
using Xamarin.Forms;
using App.Pages;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Auth;
using Newtonsoft.Json;
using App.JsonModels;
using System.Collections.Generic;

[assembly: ExportRenderer(typeof(AuthPage), typeof(App.iOS.AuthPageiOSRenderer))]

namespace App.iOS
{
    
    public class AuthPageiOSRenderer : PageRenderer
    {
        bool done = false;

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            if (done)
                return;

            var auth = new OAuth1Authenticator(
                     "lTfEsv169vr8U4uHZkgLovqiB",
                     "gk5pu4r7tKvm7nsp69TBDady4SwY3AVbt7Ma7A6lILexRADgy5",
                     new Uri("https://api.twitter.com/oauth/request_token"),
                     new Uri("https://api.twitter.com/oauth/authorize"),
                     new Uri("https://api.twitter.com/oauth/access_token"),
                     new Uri("http://mobile.twitter.com")
            );
            auth.Completed += async (sender, eventArgs) => {
                DismissViewController(true, null);
                if (eventArgs.IsAuthenticated)
                {
                    Account account = eventArgs.Account;
                    IDictionary<string, string> parameters = new Dictionary<string, string>();
                    parameters.Add("screen_name", "Disturbed");
                    var request = new OAuth1Request("GET",
                        new Uri("https://api.twitter.com/1.1/statuses/user_timeline.json"), parameters, account, false);
                    var response = await request.GetResponseAsync();
                    var tweetsUser = await response.GetResponseTextAsync();
                    List<Tweet> tweets = JsonConvert.DeserializeObject<List<Tweet>>(tweetsUser);
                    await App.NavigateToMain(tweets);

                }
                else {
                    await App.NavigateToLogin();
                }
            };
            done = true;
            PresentViewController(auth.GetUI(), true, null);
        }
    }

}