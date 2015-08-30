using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserLoginApp.DAL;

namespace UserLoginApp.BLL
{
    public class UserManager
    {
        UserGataway aGataway =new UserGataway();

        public int GetUser(string name, string pass)
        {
            return aGataway.GetUser(name, pass);
        }
    }
}