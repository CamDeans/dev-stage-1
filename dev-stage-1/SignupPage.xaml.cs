using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dev_stage_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private async void OnSignupButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage(), true);
        }
    }
}