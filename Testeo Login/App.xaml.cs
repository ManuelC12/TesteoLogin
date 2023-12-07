using System;
using Testeo_Login.Services;
using Testeo_Login.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testeo_Login
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
