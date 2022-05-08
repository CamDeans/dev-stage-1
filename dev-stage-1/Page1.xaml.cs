
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dev_stage_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void see_page1_1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1_1(), true);
        }
    }
}