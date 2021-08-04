using System;
using The_Wild_Vet.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Gilroy-Regular.otf", Alias = "Regular")]
[assembly: ExportFont("Gilroy-SemiBold.otf", Alias = "SemiBold")]
[assembly: ExportFont("Gilroy-Bold.otf", Alias = "Bold")]
[assembly: ExportFont("materialdesignicons-webfont.ttf", Alias = "FontIcons")]
namespace The_Wild_Vet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GettingStartedPage());
            
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
