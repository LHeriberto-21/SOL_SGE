using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL_SGE.Teacher
{
    internal class TeacherController : UserController
    {

        public List <string > Subjects { get; set; }

        public TeacherController(long id, string username, string lastname, DateTime birthday, string email, string password, int enrollment, int phone, 
            string address, bool status, string gender, List<string> subjects)
            : base(id, username, lastname, birthday, email, password, enrollment, phone, address, status, gender, "Maestro")
        {
            Subjects = subjects;
        }

        public override string ShowUserInfo()
        {
            return base.ShowUserInfo() + $"\nSubjects: {string.Join(", ", Subjects)}";
        }

        public void AssignTaskToStudent(long groupId, string description)
        {
            Console.WriteLine($"Task '{description}' assigned to student with ID: {groupId}");
        }

    }
}
