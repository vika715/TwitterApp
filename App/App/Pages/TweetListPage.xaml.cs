using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            listView.HasUnevenRows = true;
            listView.ItemTemplate = new DataTemplate(typeof(TweetViewCell));
            listView.ItemSelected += async (sender, e) => {
                 await Navigation.PushAsync(new TweetPage((Tweet)e.SelectedItem));
            };
        }
        public class TweetViewCell : ViewCell
        {
            public TweetViewCell()
            {
                var grid = new Grid { RowSpacing = 1, ColumnSpacing = 1 };
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.2, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.8, GridUnitType.Star) });
                grid.ColumnSpacing = 16;
                grid.Padding = 16;
                Image profileImage = new Image();
                Image tweetImage = new Image();
                Label message = new Label()
                {
                    TextColor = Color.Black
                };
                Label name = new Label()
                {
                    TextColor = Color.Black
                };
                name.SetBinding(Label.TextProperty, new Binding("User.Name"));
                message.SetBinding(Label.TextProperty, new Binding("Text"));
                UriImageSource sourceImage = new UriImageSource();
                sourceImage.SetBinding(UriImageSource.UriProperty, new Binding(("User.ProfileImageUrlHttps"), 
                    BindingMode.Default, new MUriConverter()));
                sourceImage.CachingEnabled = true;
                sourceImage.CacheValidity = new TimeSpan(5, 0, 0, 0);
                profileImage.Source = sourceImage;
                profileImage.WidthRequest = 50;
                profileImage.HeightRequest = 50;
                profileImage.HorizontalOptions = LayoutOptions.StartAndExpand;
                profileImage.VerticalOptions = LayoutOptions.StartAndExpand;

                grid.Children.Add(profileImage, 0, 0);
                Grid.SetRowSpan(profileImage, 2);
                grid.Children.Add(name, 1, 0);
                grid.Children.Add(message, 1, 1);
                View = grid;                 
            }

          
        }

        public class MUriConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value != null )
                {
                    var uri = (string) value;
                    return new Uri(uri);
                }
                else
                    return value; 
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
    }
}
 