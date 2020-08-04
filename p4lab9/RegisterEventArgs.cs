namespace p4lab9
{
    public class RegisterEventArgs
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public bool Accept { get; set; }
        public RegisterEventArgs(string name, string password, string repeatedPassword, bool accept)
        {
            Name = name;
            Password = password;
            RepeatedPassword = repeatedPassword;
            Accept = accept;
        }
    }
}
