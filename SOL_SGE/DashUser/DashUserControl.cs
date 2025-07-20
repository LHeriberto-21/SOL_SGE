using SOL_SGE.Classroom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SOL_SGE.DashUser
{
    public partial class DashUserControl : Form
    {
       

        public DashUserControl(string email)
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
          
        }

        //Acción del desplegable de inicio

        private void timerInicio_Tick(object sender, EventArgs e)
        {

        }

        private void btnClassroom_Click(object sender, EventArgs e)
        {
            


            try
            {
                panelInicio.Controls.Clear();

                var classroom = new Classroom.Classroom();
                classroom.TopLevel = false;
                classroom.FormBorderStyle = FormBorderStyle.None;
                classroom.Dock = DockStyle.Fill;


                panelInicio.Controls.Add(classroom);
                panelInicio.Tag = classroom;

                classroom.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el aula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        private void btnCalificaciones_Click(object sender, EventArgs e)
        {

        }
        private void btnNotificaciones_Click(object sender, EventArgs e)
        {

        }


        private void btnFinanzas_Click(object sender, EventArgs e)
        {

        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            SMS administrator = new SMS();
            administrator.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas cerrar cesion?", "Cerrar sesión: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();

                Login login = new Login();
                login.Show();
                

            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult outApp = MessageBox.Show("¿Estás seguro de que quieres salir de la aplicación?", "Cerrar aplicación",MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (outApp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnMInimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        
        }

        private void panelInicio_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
