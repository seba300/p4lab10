using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab9
{
    public class RegisterControlModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public bool Action { get; set; }
    }
}
