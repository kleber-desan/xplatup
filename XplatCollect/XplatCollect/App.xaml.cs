using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;
using Prism.Ioc;

namespace XplatCollect
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();

          
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new NotImplementedException();
        }

        protected override void OnInitialized()
        {
            throw new NotImplementedException();
        }
    }
}
