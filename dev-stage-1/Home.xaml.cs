using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dev_stage_1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }

    private async void SeeDetailButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page1(), true);
    }
    }
}