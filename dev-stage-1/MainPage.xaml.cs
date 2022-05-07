using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dev_stage_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Login_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage(), true);
        }

        private async void Signup_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage(), true);
        }

        private async void Signup_With_FB_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage(), true);
        }
    }
}