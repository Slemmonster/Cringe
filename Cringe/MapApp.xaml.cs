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
    public partial class MapApp : ContentPage
    {
        private readonly App app;
        public MapApp(App app)
        {
            InitializeComponent();
            this.app = app;
        }

        private async void BackMenuClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void PopulateMenu(SideMenu sideMenu)
        {
            sideMenu.SetTitle("Map App Menu");
        }

        private async void OpenSideMenuClick(object sender, EventArgs e)
        {
            SideMenu sideMenu = app.getSideMenu();

            PopulateMenu(sideMenu);

            await Navigation.PushModalAsync(sideMenu);
        }
    }
}