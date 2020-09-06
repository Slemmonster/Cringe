using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cringe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SideMenu : ContentPage
    {
        private App app;
        public SideMenu(App _app)
        {
            InitializeComponent();
            BuildNavMenu();
            this.app = _app;
        }

        private void BuildNavMenu()
        {

        }

        private async void MenuCloseClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        public void SetTitle(string title)
        {
            menuLabel.Text = title;
        }

        private void ChangeThings(object sender, EventArgs e)
        {
            Color[] colors = new Color[] { Color.Green, Color.Red, Color.Orange, Color.Pink, Color.Blue, Color.OrangeRed, Color.DarkOrange, Color.SpringGreen, Color.MintCream};
            Random rnd = new Random();
            titleBackground.BackgroundColor = colors[rnd.Next(0, colors.Length)];
        }
    }
}