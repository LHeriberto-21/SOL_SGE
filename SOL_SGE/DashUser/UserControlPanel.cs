using SOL_SGE.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace SOL_SGE.DashUser
{
    public class UserControlPanel
    {
        private string _username;
        private string _rol;
        private string _email;
        public UserControlPanel(string username, string rol, string email)
        {
            _username = username;
            _rol = rol;
            _email = email;
        }
        public void ShowInfoUser(Label lblColocarRol)
        {
            if (lblColocarRol != null)
            {
                lblColocarRol.Text = $"{_rol}: {_username}";
            }
        }

    }
}
