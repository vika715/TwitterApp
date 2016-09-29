using System.Collections.Generic;
using App.JsonModels;
using Xamarin.Forms;

namespace App.Pages
{
    public partial class TweetListPage : ContentPage
    {
        
        public TweetListPage(List<Tweet> tweets)
        {
            InitializeComponent();
            listView.ItemsSource = tweets;
            listView.ItemSelected += async (sender, e) => {
                var tweetPage = new TweetPage();
                tweetPage.BindingContext = (Tweet)e.SelectedItem;
                await Navigation.PushAsync(tweetPage);
            };
        }
    }
}
 