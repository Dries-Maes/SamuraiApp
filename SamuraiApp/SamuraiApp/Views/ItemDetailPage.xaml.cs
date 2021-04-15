using SamuraiApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SamuraiApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}