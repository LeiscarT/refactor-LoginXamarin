﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace loginRefactor.Models
{
    public class User : INotifyPropertyChanged
    {
        private string _userName { get; set; }
        public string Username { get { return _userName; } set { _userName = value; OnPropertyChanged(nameof(Username)); } }
        private string _password { get; set; }
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged(nameof(Password)); } }

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}