using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Wild_Vet.Models;
using The_Wild_Vet.Views;
using Xamarin.Forms;

namespace The_Wild_Vet
{
    public partial class MainPage : FlyoutPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        public MainPage()
        {
            InitializeComponent();

            //adding the 'Pets' item to the MenuPages list because it is the default item that is showing as the detail
            MenuPages.Add((int)MenuItemType.Pets, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            //checking whether the id coming from the selected item is already not in the dictionary.
            if (!MenuPages.ContainsKey(id))
            {
                //Based on id this switch statement added the relevant item to the dictionary
                switch (id)
                {
                    case (int)MenuItemType.Pets:
                        MenuPages.Add(id, new NavigationPage(new DashboardPage()));
                        break;
                    case (int)MenuItemType.Appointments:
                        MenuPages.Add(id, new NavigationPage(new AppointmentsPage()));
                        break;
                    case (int)MenuItemType.AddAPet:
                        MenuPages.Add(id, new NavigationPage(new AddAPetPage()));
                        break;
                    case (int)MenuItemType.Support:
                        MenuPages.Add(id, new NavigationPage(new SupportPage()));
                        break;
                    case (int)MenuItemType.Settings:
                        MenuPages.Add(id, new NavigationPage(new SettingsPage()));
                        break;
                    case (int)MenuItemType.Profile:
                        MenuPages.Add(id, new NavigationPage(new ProfilePage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            //the item added to the dictionary is set to the variable newPage
            var newPage = MenuPages[id];

            //To check whether the newPage var is not null and not the default detail (Pets) item
            if (newPage != null && Detail != newPage)
            {
                //if those are true the newPage is set as the Detail (the page currently appearing)
                Detail = newPage;

                //this closes the side menu
                IsPresented = false;
            }
        }
    }
}
