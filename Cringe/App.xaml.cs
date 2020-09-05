using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cringe
{
    public partial class App : Application
    {
        ContentPage DateApp;
        ContentPage ChatApp;
        ContentPage ShopApp;
        ContentPage MapApp;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage(this));
            DateApp = new DateApp(this);
            ChatApp = new ChatApp(this);
            ShopApp = new ShopApp(this);
            MapApp = new MapApp(this);
        }

        public Page getMain()
        {
            return MainPage;
        }

        public ContentPage getDateApp()
        {
            return DateApp;
        }

        public ContentPage getChatApp()
        {
            return ChatApp;
        }

        public ContentPage getShopApp()
        {
            return ShopApp;
        }

        public ContentPage getMapApp()
        {
            return MapApp;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
