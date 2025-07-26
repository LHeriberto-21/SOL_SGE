using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace SOL_SGE.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //instanciamos en variables los contenedores de los textos
            string email = txtEmail.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();


            if (password.Length < 4 || password.Length > 12)
            {
                MessageBox.Show("La contraseña debe ser como minimo de 4 caracteres y no mas de 12  caracteres.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // llamamos al metodo de validación de credenciales y los instanciamos en variables con su respectivo parametro
            var (username, rol) = ValidateCredentials(email, password);


            if (!string.IsNullOrEmpty(username))
            {

                Service.UserSesion.IniciarSesion(username, rol, email);

                string welcomeMesssage = $"Bienvenido {(string.IsNullOrEmpty(rol) ? "" : rol + ": ")}{username}!"; ;

                MessageBox.Show(welcomeMesssage, "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashUser.DashUserControl frm = new DashUser.DashUserControl(email, rol);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso no autorizado. Verifica tus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private (string username, string rol) ValidateCredentials(string email, string password)
        {
            string nombre = null;
            string rol = null;

            string cn = @"server= localhost; userid = root; password= 1234; database = nueva_conexion";

            try
            {
                using (MySqlConnection con = new MySqlConnection(cn))
                {
                    con.Open();
                    string query = "SELECT username, rol FROM usuarios WHERE correo_usuario = @email AND contraseña_usuario_hash = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombre = reader.GetString("username");
                                rol = reader.GetString("rol");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Acceso no autorizado. " + ex.Message);
            }

            return (nombre, rol);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                string url = "https://www.youtube.com/@TayluSs";
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Esto es necesario para abrir enlaces en el navegador predeterminado
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al abrir el enlace:\n" + ex.Message,
                    "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
