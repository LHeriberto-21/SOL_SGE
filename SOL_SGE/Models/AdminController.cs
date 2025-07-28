using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SOL_SGE.DashAdmin
{
    internal class AdminController : UserController
    {
        public string Department { get; set; }
        public int AccessLevel { get; set; }
        public AdminController(long id, string username, string lastname, DateTime birthday, string email, string password, int enrollment, int phone, string address, bool status, 
            string gender, string department, int accessLevel)
            : base(id, username, lastname, birthday, email, password, 0, phone, address, status, gender, "Admin")
        {
            Department = department;
            AccessLevel = accessLevel;
        }

        public override string ShowUserInfo()
        {
            return base.ShowUserInfo() + $"\nDepartment: {Department}\nAccess Level: {AccessLevel}";
        }

        public void CreateUser(UserController user)
        {
            MessageBox.Show($"El administrador: {_Username}, creó al usuario: {_Username}");

        }

        public void DeleteUser(long userId)
        {
            MessageBox.Show($"El administrador: {_Username}, eliminó al usuario: {userId}");
        }


    }
}
