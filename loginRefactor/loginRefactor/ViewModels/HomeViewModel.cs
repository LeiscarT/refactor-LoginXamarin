using loginRefactor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace loginRefactor.ViewModels
{
   public class HomeViewModel
    {
        public Menu Beach { get; set; } = new Menu();
        public Menu Church { get; set; } = new Menu();
        public Menu River { get; set; } = new Menu();
        public Menu Park { get; set; } = new Menu();
        public Menu Hotel { get; set; } = new Menu();
        public Menu FoodTruck { get; set; } = new Menu();

         ICommand Command { get; set; }

        public HomeViewModel()
        {
            Command = new Command(OnInit);
        } 

        private void OnInit()
        {
            Beach.Title = "Beach";
            Beach.Image = "/.beach.png";

            Church.Title = "Church";
            Church.Image = "/.church.png";

            River.Title = "River";
            River.Image = "/.river.png";

            Park.Title = "Park";
            Park.Image = "/.park.png";

            Hotel.Title = "Hotel";
            Hotel.Image = "/.hotel.png";

            FoodTruck.Title = "Beach";
            FoodTruck.Image = "/.beach.png";
        }

    }
}
