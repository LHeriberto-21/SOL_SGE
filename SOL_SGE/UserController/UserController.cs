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

        private int _id { get; set; }
        private string _Username { get; set; }
        private string _Lastname { get; set; }
        private string _Birtday { get; set; }
        private string _Email { get; set; }
        private string _Gender { get; set; }
        private bool _Authentication { get; set; }
        private string _Rool { get; set; }
    }
}
