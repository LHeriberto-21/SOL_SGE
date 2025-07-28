using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOL_SGE
{
    public class UserController
    {
            // Esta clase se usara para la serie de datos del registro de actividad dentro de la aplicacion

        protected long _id { get; set; }
        protected string _Username { get; set; }
        protected string _Lastname { get; set; }
        protected DateTime _Birthday { get; set; }
        protected string _Email { get; set; }
        protected string _Password { get; set; }
        protected int _Enrollment { get; set; }
        protected int _Phone { get; set; }
        protected string _Address { get; set; }
        protected bool _Status { get; set; }
        protected string _Gender { get; set; }
        protected string _Role { get; set; }

        public UserController(long id, string username, string lastname, DateTime birthday, string email, string password, int enrollment, int phone, string address,
            bool status, string Gender, string rol = "user")
        {
            _id = id;
            _Username = username;
            _Lastname = lastname;
            _Birthday = birthday;
            _Email = email;
            _Password = password;
            _Enrollment = enrollment;
            _Phone = phone;
            _Address = address;
            _Status = status;
            _Gender = Gender;
            _Role = rol;

        }
        public UserController(string username, string rol, string email)
        {
            _Username = username;
            _Role = rol;
            _Email = email;
        }

        public string GetRole() => _Role;
        public void SetRol(string role) => _Role = role;

        // metodos comunes para todos los usuarios

        public virtual string ShowUserInfo()
        {
            return $"ID: {_id}\nUsername: {_Username}\nLastname: {_Lastname}\nBirthday: {_Birthday}" +
                $"\nEmail: {_Email}\nMatricula: {_Enrollment}\nPhone: {_Phone}\nAddress: {_Address}" +
                $"\nStatus: {_Status}\nGender: {_Gender}\nRol: {_Role}";
        }

        public virtual void CreateUser()
        {

        }

        public virtual void UpdateUser()
        {

        }

        public virtual void DeleteUser()
        {

        }
    }
}
