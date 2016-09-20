using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnClickLoginButton(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AuthPage());
        }
    }
}
