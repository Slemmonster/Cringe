using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Cringe
{
    public partial class HomePage : ContentPage
    {
        App app;

        public HomePage(App _app)
        {
            InitializeComponent();
            this.app = _app;
        }

        private async void GetNudes(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Ooo naughty boy", "So you want some nudes?", "YES!", "On second thought...");
            await DisplayAlert("Result", "Answer: " + answer, "OK");
        }

        private async void MenuImageClick(object sender, EventArgs e)
        {
            
        }

        private async void openDate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(app.getDateApp());
        }
        private async void openChat(object sender, EventArgs e)
        {
            await Navigation.PushAsync(app.getChatApp());
        }
        private async void openShop(object sender, EventArgs e)
        {
            await Navigation.PushAsync(app.getShopApp());
        }
        private async void openMap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(app.getMapApp());
        }

    }
}
