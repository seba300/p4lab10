using System;
using System.Collections.Generic;
using System.Text;

namespace p4lab9
{
    class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            RegistrationModel = new RegistrationModel();
            RegistrationModelValidator = new RegistrationModelValidator();
        }
        public MainWindowViewModel(RegistrationModel registrationModel)
        {
            RegistrationModel = new RegistrationModel();
            RegistrationModelValidator = new RegistrationModelValidator();
        }
        public RegistrationModel RegistrationModel { get; set; }
        public RegistrationModelValidator RegistrationModelValidator { get; set; }

    }
}