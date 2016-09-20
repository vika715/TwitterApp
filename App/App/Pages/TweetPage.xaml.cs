using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.JsonModels;

using Xamarin.Forms;

namespace App.Pages
{
    public partial class TweetPage : ContentPage
    {
        public TweetPage(Tweet tweet)
        {
            InitializeComponent();
            textTweetLabel.Text = tweet.Text;
            nameUserLabel.Text = tweet.User.Name;
            UriImageSource sourceImage = new UriImageSource();
            sourceImage.Uri = new Uri (tweet.User.ProfileImageUrlHttps);
            sourceImage.CachingEnabled = true;
            sourceImage.CacheValidity = new TimeSpan(5, 0, 0, 0);
            profileImage.Source = sourceImage;
        }
    }
}
