using loginRefactor.Models;
using loginRefactor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace loginRefactor.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        public User User { get; set; } = new User();
        public ICommand Command { get; }
        public ICommand NavigateCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel() {
            Command = new Command(OnPushButton);

            NavigateCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new RegisterPage());

            });

         }      
        

        private async void OnPushButton()
        {
            if (string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe llenar todos los campos", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido", $"Hola {User.Username}", "ok");
            }
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
       
    }
}
