using SamuraiApp.ViewModels;
using SamuraiApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SamuraiApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(NewSamuraiPage), typeof(NewSamuraiPage));
            Routing.RegisterRoute(nameof(SamuraisPage), typeof(SamuraisPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}