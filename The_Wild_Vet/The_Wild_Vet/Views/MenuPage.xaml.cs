using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Wild_Vet.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace The_Wild_Vet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            //this is the item list appears in the side menu
            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Pets, Title="Pets", Icon = "\U000f02dc" },
                new HomeMenuItem {Id = MenuItemType.Appointments, Title="Appointments", Icon = "\U000f00ef" },
                new HomeMenuItem {Id = MenuItemType.AddAPet, Title="Add a Pet", Icon = "\U000f0419" },
                new HomeMenuItem {Id = MenuItemType.Support, Title="Support",Icon = "\U000f0625" },
                new HomeMenuItem {Id = MenuItemType.Settings, Title="Settings", Icon = "\U000f0493" },
                new HomeMenuItem {Id = MenuItemType.Profile, Title="Profile", Icon = "\U000f0643" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About", Icon = "\U000f05d6" },
            };

            //the above list is then set as the items source of listview in the MenuPage(side menu)
            ListViewMenu.ItemsSource = menuItems;

            //setting the 1st item as the selected item
            ListViewMenu.SelectedItem = menuItems[0];

            //item selected event of listview to call the NavigateFromMenu method to change the detail page
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };            
        }

        // The logout function when click on the logout
        private async void LogOut_Tapped(object sender, EventArgs e)
        {
            var loginout = await DisplayAlert("Message", "Are you sure you want to logout?", "Yes", "Cancel");
            if (loginout)
            {
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}