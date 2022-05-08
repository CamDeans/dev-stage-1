using System;
using Xamarin.Forms;

namespace dev_stage_1
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home(), true);
        }
    }
}
