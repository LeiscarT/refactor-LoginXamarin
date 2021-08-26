using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace loginRefactor.Models
{
    public class Menu : INotifyPropertyChanged
    {
        private string _title { get; set; }
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(nameof(Title)); }
        }

        private string _image { get; set; }
        public string Image
        {
            get { return _image; }
            set { _image = value; OnPropertyChanged(nameof(Image)); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
