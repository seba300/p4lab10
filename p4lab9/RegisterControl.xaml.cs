using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace p4lab9
{
    /// <summary>
    /// Interaction logic for RegisterControl.xaml
    /// </summary>
    public partial class RegisterControl : Window
    {
        public event EventHandler<RegisterEventArgs> RegisterAttempt;
        public RegisterControlViewModel registerControlViewModel { get; set; }

        public RegisterControl()
        {
            InitializeComponent();
            registerControlViewModel = new RegisterControlViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterAttempt?.Invoke(this, new RegisterEventArgs(registerControlViewModel.Model.Name, registerControlViewModel.Model.Password, registerControlViewModel.Model.RepeatedPassword, registerControlViewModel.Model.Accept.Value));
            tb_Passw.Clear();
            tb_RPassw.Clear();
        }
}
