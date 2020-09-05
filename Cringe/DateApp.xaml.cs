using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cringe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateApp : ContentPage
    {
        private readonly App app;
        public DateApp(App app)
        {
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.app = app;
        }

        private async void BackMenuClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}