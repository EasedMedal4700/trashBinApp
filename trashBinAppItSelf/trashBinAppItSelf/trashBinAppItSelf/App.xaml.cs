using System;
using trashBinAppItSelf.Services;
using trashBinAppItSelf.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trashBinAppItSelf
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
