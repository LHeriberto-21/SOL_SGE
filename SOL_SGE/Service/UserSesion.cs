using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL_SGE.Service
{
    public static class UserSesion 
    {

        public static string Username { get; set; }
        public static string Rol {get; set;}
        public static string Email { get; set; }
            
        public static void IniciarSesion(string username, string rol, string email)
        {
            Username = username;
            Rol = rol;
            Email = email;
        }
        

    }
}
