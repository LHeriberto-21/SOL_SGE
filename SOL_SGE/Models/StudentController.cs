using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace SOL_SGE.Stundent
{
    internal class StudentController : UserController
    {

        public string Career { get; set; }
        public int Group { get; set; }
        public int Semester { get; set; }



        public StudentController(long id, string username, string lastname, DateTime birthday, string email, string password, int enrollment, int phone, 
            string address, bool status, string gender, string career, int group, int semestre)
            : base(id, username, lastname, birthday, email, password, enrollment, phone, address, status, gender, "Estudiante") 
        {

            Career = career;
            Group = group;
            Semester = semestre;

        }

        public override string ShowUserInfo()
        {
            return base.ShowUserInfo() + $"\nCarrera: {Career}\nGrupo: {Group}\nSemestre: {Semester}";
        }




        //public List<Subjects> getSubjects(int );
        //public List<Qualifications> queryQualifications();
        //public Schedule seeSchedule();
        //public void downloadBallot();
    }
}

// En modelos: 