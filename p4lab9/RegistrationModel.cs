using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;

namespace p4lab9
{
    public class RegistrationModel : INotifyPropertyChanged
    {
        private bool? accept;

        public RegistrationModel()
        {

        }
        public RegistrationModel(string name, string password, string repeatedPassword, bool? accept)
        {
            Name = name;
            Password = password;
            RepeatedPassword = repeatedPassword;
            Accept = accept;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public bool? Accept { get; set; }
   

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
