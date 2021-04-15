using SamuraiApp.Models;
using SamuraiApp.Services;
using SamuraiApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SamuraiApp.ViewModels
{
    internal class NewSamuraiViewModel : BaseViewModel
    {
        public Samurai SelectedSamurai { get; set; }
        public SamuraisViewModel samuraisViewModel { get; set; }

        private ISamuraiRepo repo;

        public ICommand SaveCommand => new Command(OnSaveAsync);

        public NewSamuraiViewModel()
        {
            samuraisViewModel = new SamuraisViewModel();
            SelectedSamurai = new Samurai();
            repo = SamuraiRepo.GetInstance();
        }

        private async void OnSaveAsync()
        {
            repo.AddSamurai(SelectedSamurai);
            await Shell.Current.GoToAsync("///" + nameof(SamuraisPage));
        }
    }
}