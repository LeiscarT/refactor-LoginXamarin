using loginRefactor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace loginRefactor.ViewModels
{
   public class HomeViewModel : INotifyPropertyChanged
    {
       
        public Card Beach { get; set; } = new Card();
        public Card Church { get; set; } = new Card();
        public Card River { get; set; } = new Card();
        public Card Park { get; set; } = new Card();
        public Card Hotel { get; set; } = new Card();
        public Card FoodTruck { get; set; } = new Card();

        public event PropertyChangedEventHandler PropertyChanged;

        ICommand Command { get; set; }

        public HomeViewModel()
        {

            OnInit();
        }

        

        private void OnInit()
        {
            Beach.Title = "Beach";
            Beach.Image = "beach.png";

            Church.Title = "Church";
            Church.Image = "church.png";

            River.Title = "River";
            River.Image = "river.png";

            Park.Title = "Park";
            Park.Image = "park.png";

            Hotel.Title = "Hotel";
            Hotel.Image = "hotel.png";

            FoodTruck.Title = "FoodTruck";
            FoodTruck.Image = "foodTruck.png";
        }

    }
}
