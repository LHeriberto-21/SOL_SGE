using SOL_SGE.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOL_SGE.Service;
using SOL_SGE.Coordinator;
using SOL_SGE.DashAdmin;

namespace SOL_SGE.DashUser
{
    public partial class DashUserControl : Form

    {
        private string _username;
        private string _rol;


        public DashUserControl(string username, string rol)
        {
            InitializeComponent();
            showInfoUser();
        }

        private void showInfoUser()
        {

            if (lblColocarRol.Text != null)
            {
                lblColocarRol.Text = $"{UserSesion.Rol}: {UserSesion.Username}";

            }
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
                // Si el formulario ya está abierto, lo cerramos y lo removemos
                if (panelInicio.Tag is Classroom.Classroom classroomActual && classroomActual.Visible)
                {
                    panelInicio.Controls.Remove(classroomActual);
                    panelInicio.Tag = null;
                    return; // Salimos porque ya lo ocultamos
                }

                // Si no está abierto, lo agregamos
                panelInicio.Controls.Clear(); // Limpia cualquier otro contenido

                var classroom = new Classroom.Classroom
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

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
            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"{UserSesion.Username} ¿Estás seguro que deseas cerrar cesion?", "Cerrar sesión: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();

                Login.Login login = new Login.Login();
                login.Show();
                this.Hide();

            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult outApp = MessageBox.Show($"{UserSesion.Username} ¿Estás seguro de que quieres salir de la aplicación?", "Cerrar aplicación",MessageBoxButtons.YesNo, MessageBoxIcon.Question );
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
        

        private void lblColocarRol_Click(object sender, EventArgs e)
        {

        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {

        }

        private void btnAdministrarHorarios_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {

        }
        private void btnRegistrarUsuarios_Click(object sender, EventArgs e)
        {

            try
            {
                // Limpiar el panel contenedor si ya hay un formulario abierto
                if (panelInicio.Tag is UserRegister formularioExistente)
                {
                    panelInicio.Controls.Remove(formularioExistente);
                    formularioExistente.Dispose();
                    panelInicio.Tag = null;
                    return;
                }

                UserRegister userRegister = new UserRegister
                {
                    Dock = DockStyle.Fill
                };

                panelInicio.Controls.Add(userRegister);               
                panelInicio.Tag = userRegister;
                userRegister.Show(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
