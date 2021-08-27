using loginRefactor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace loginRefactor.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public User User { get; set; } = new User();
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand Command { get; }
        public RegisterViewModel()
        {
            Command = new Command(OnRegister);
        }

        public async void OnRegister()
        {
            
            if(User.Password != User.ConfirmPass){
                await App.Current.MainPage.DisplayAlert("Error", "No ha colocado la contraseña correcta", "Ok");
            }

            else if (string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.ConfirmPass))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe llenar todos los campos", "Ok");

            }
            else 
            {
                await App.Current.MainPage.DisplayAlert("Success", "Usuario Creado", "Ok");
                await App.Current.MainPage.Navigation.PopModalAsync();
            }
        }
            
        
    }
}
