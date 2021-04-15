using SamuraiApp.Models;
using SamuraiApp.Services;
using SamuraiApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SamuraiApp.ViewModels
{
    public class SamuraisViewModel : BaseViewModel
    {
        private ObservableCollection<Samurai> samurai;

        public ICommand AddSamuraiCommand { get; }

        public ObservableCollection<Samurai> Samurais
        {
            get { return samurai; }
            set
            {
                samurai = value;
                OnPropertyChanged(nameof(Samurais));
            }
        }

        private ISamuraiRepo repo;

        public SamuraisViewModel()
        {
            AddSamuraiCommand = new Command(AddSamurai);
            Title = "Samurais";
            repo = SamuraiRepo.GetInstance();
            GetSamurais();
        }

        private async void AddSamurai()
        {
            GetSamurais();
            await Shell.Current.GoToAsync(nameof(NewSamuraiPage));
        }

        public void GetSamurais()
        {
            Samurais = new ObservableCollection<Samurai>(repo.GetAllSamurais());
        }
    }
}