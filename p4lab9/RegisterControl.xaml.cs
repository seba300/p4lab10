using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace p4lab9
{
    public partial class RegisterControl : UserControl
    {
        public event EventHandler<RegisterEventArgs> RegisterAttempt;

        public RegisterControlViewModel registerControlViewModel { get; set; }
        public RegisterControl()
        {
            InitializeComponent();
            registerControlViewModel = new RegisterControlViewModel();
            DataContext = registerControlViewModel;
        }

        private void RegisterAction(object sender, RoutedEventArgs e)
        {
            RegisterAttempt?.Invoke(this, new RegisterEventArgs(registerControlViewModel.Model.Name, registerControlViewModel.Model.Password, registerControlViewModel.Model.RepeatedPassword, registerControlViewModel.Model.Accept));
            tb_Passw.Clear();
            tb_RPassw.Clear();
        }
    }
}
