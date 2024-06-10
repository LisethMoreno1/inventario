using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeNegocio
{
    public class RN_Login
    {
        public bool ValidateCredentials(string username, string password)
        {
           
            return username == "admin" && password == "admin123";
        }
    }
}
