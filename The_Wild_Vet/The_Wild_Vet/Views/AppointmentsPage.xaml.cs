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
    public partial class AppointmentsPage : ContentPage
    {
        public AppointmentsPage()
        {
            InitializeComponent();
        }

        private void On_SideMenu_Clicked(object sender, EventArgs e)
        {
            if ((Application.Current.MainPage as MainPage).IsPresented == false)
            {
                (Application.Current.MainPage as MainPage).IsPresented = true;
            }
            else
            {
                (Application.Current.MainPage as MainPage).IsPresented = false;
            }
        }
    }
}