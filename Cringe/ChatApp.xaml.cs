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
    public partial class ChatApp : ContentPage
    {
        private readonly App app;
        public ChatApp(App app)
        {
            InitializeComponent();
            this.app = app;
        }

        private async void BackMenuClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}