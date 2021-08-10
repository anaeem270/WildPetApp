using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace The_Wild_Vet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PetDetailsPage : ContentPage
    {
        public PetDetailsPage()
        {
            InitializeComponent();
        }

        private async void Back_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        private async void Add_Tapped(object sender, EventArgs e)
        {

        }

        private void Tab1_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {

        }

        private void Tab2_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {

        }

        private void Tab3_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {

        }

        private void TabView_SelectionChanged(object sender, Xamarin.CommunityToolkit.UI.Views.TabSelectionChangedEventArgs e)
        {

        }

        private void Tab4_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {

        }


        private async void ShareBtn_Clicked(object sender, EventArgs e)
        {
            await SharePopup.TranslateTo(0, 0, 250);
        }

        private async void Close_Clicked(object sender, EventArgs e)
        {
            await SharePopup.TranslateTo(0, 170, 250);
        }
    }
}