using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace p4lab9
{
    public class RegisterControlViewModel
    {
        public RegisterControlViewModel()
        {
            RegisterCommand = new RegisterCommand();
            Model = new RegistrationModel();
        }
        public ICommand RegisterCommand { get; set; }
        public RegistrationModel Model { get; set; }
    }
}
