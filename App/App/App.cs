using App.Pages;
using Xamarin.Auth;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using App.JsonModels;

namespace App
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage();
            MainPage.Navigation.PushAsync(new LoginPage());
       }

        protected override void OnStart()
        {
           
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
            
        }
        public static async Task NavigateToMain(List<Tweet>tweets) {
            await App.Current.MainPage.Navigation.PushAsync(new TweetListPage(tweets));
            await App.Current.MainPage.Navigation.PopModalAsync();
            App.Current.MainPage.Navigation.RemovePage(App.Current.MainPage.Navigation.NavigationStack[0]);
        }

        public async static Task NavigateToLogin()
        {
            await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            await App.Current.MainPage.Navigation.PopModalAsync();
        }

    }
}
