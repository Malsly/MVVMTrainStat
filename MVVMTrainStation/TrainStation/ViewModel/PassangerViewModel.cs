using TrainStation.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrainStation.ViewModel
{
    class PassangerViewModel
    {
        public static StationViewModel GlobalStation
        {
            get;
            set;
        }
        public StationViewModel Station
        {
            get;
            set;
        }
        private string name { get; set; }
        private string telephone { get; set; }
        private string email { get; set; }

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public string Email   // property
        {
            get { return email; }   // get method
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    Deb.Print("Email is not valid");
                }
            }
        }

        public string Telephone   // property
        {
            get { return telephone; }   // get method
            set
            {
                if (value.Contains("+"))
                {
                    telephone = value;
                }
                else
                {
                    Deb.Print("Telephone is not valid");
                }
            }
        }

        public string getName() 
        {
            return Name;
        }
    }
}
