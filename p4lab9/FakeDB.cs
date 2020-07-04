using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace p4lab9
{
    class FakeDB
    {
        public void RegisterUser(RegistrationModel model)
        {
            MessageBox.Show($"User {model.Name} Successfully registered!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
