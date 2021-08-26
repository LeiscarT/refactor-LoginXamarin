using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace loginRefactor.Models
{
    public class User : INotifyPropertyChanged
    {
        private string _name { get; set; }
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        private string _userName { get; set; }
        public string Username { get { return _userName; } set { _userName = value; OnPropertyChanged(nameof(Username)); } }
        private string _password { get; set; }
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged(nameof(Password)); } }

        private string _confirmPass { get; set; }
        public string ConfirmPass { get { return _confirmPass; } set { _confirmPass = value; OnPropertyChanged(nameof(ConfirmPass)); } }

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
