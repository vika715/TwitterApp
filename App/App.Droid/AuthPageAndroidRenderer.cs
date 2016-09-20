using System;
using Android.App;
using App.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Auth;
using System.Collections.Generic;
using App.JsonModels;
using Newtonsoft.Json;

[assembly: ExportRenderer(typeof(AuthPage), typeof(App.Droid.AuthPageAndroidRenderer))]

namespace App.Droid
{
    class AuthPageAndroidRenderer : PageRenderer
    {
        public AuthPageAndroidRenderer()
        {

            var activity = this.Context as Activity;
            var auth = new OAuth1Authenticator(
                     "lTfEsv169vr8U4uHZkgLovqiB",
                     "gk5pu4r7tKvm7nsp69TBDady4SwY3AVbt7Ma7A6lILexRADgy5",
                     new Uri("https://api.twitter.com/oauth/request_token"),
                     new Uri("https://api.twitter.com/oauth/authorize"),
                     new Uri("https://api.twitter.com/oauth/access_token"),
                     new Uri("http://mobile.twitter.com")
            );
            auth.Completed += async (sender, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    Account account = eventArgs.Account;
                    IDictionary<string, string> parameters = new Dictionary<string, string>();
                    parameters.Add("screen_name", "Disturbed");
                    var request = new OAuth1Request("GET",
                        new Uri("https://api.twitter.com/1.1/statuses/user_timeline.json"), parameters, account, false);
                    var response = await request.GetResponseAsync();
                    var tweetsUser = await response.GetResponseTextAsync();
                    List<Tweet> twitts = JsonConvert.DeserializeObject<List<Tweet>>(tweetsUser);
                    await App.NavigateToMain(twitts);
                    
                }
                else {
                    await App.NavigateToLogin();
                }
            };

            activity.StartActivity(auth.GetUI(activity));
        }
    }
}