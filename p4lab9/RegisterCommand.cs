using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace p4lab9
{
    public class RegisterCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public RegistrationModelValidator _Validator;
        public bool CanExecute(object parameter)
        {
            if (parameter is object && parameter is RegistrationModel)
            {
                var model = parameter as RegistrationModel;
                if (_Validator.Validate(model).IsValid && model.Password == model.RepeatedPassword)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}