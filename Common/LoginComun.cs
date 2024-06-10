using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Common
{
    public class LoginComun
    {
        public string Username { get; set; }
        public string Password { get; set; }

       public LoginComun(string username, string password)
        {
            Username = username;    
            Password = password;
        }

        public LoginComun()
        {
            Username = "";
            Password = "";
        }
    }
}
