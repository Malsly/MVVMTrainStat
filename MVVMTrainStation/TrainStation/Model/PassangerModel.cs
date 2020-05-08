
using TrainStation.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Model
{
    public class PassangerModel
    {
        private string name { get; set; }
        private string telephone { get; set; }
        private string email { get; set; }

        public static bool IsValidUser(string name, string telephone, string email)
        {
            if (name != "" && telephone != "" && email != "")
            {
                return true;
            }
            return false;
        }

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
            set { telephone = value; }  // set method
        }

        public PassangerModel(string Name, string Telephone, string Email)
        {
            this.Name = Name;
            this.Telephone = Telephone;
            this.Email = Email;
        }
    }
}
