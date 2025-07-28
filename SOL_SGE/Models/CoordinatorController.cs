using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SOL_SGE.Coordinator
{
    internal class CoordinatorController : UserController
    {

        public string Area { get; set; } 

        public CoordinatorController(long id, string username, string lastname, DateTime birthday, string email, string password, int enrollment, int phone, 
            string address, bool status, string Gender, string area) 
            : base(id, username, lastname, birthday, email, password, enrollment, phone, address, status, Gender, "coordinador")
        {
            Area = area;
        }


        public override string ShowUserInfo()
        {
            return base.ShowUserInfo() + $"\nArea: {Area}";
        }

        public void AssingTask(string task)
        {
            MessageBox.Show($"El coordinador: {_Username}, asignó la tarea: {task}");

        }



        public void AssignTeacherToStudent(long groupId, string Description)
        {
            // Logic to assign a task to a student
            Console.WriteLine($"Task '{Description}' assigned to student with ID: {groupId}");
        }
    }
}
