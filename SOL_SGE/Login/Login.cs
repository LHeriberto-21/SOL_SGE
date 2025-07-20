using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;



namespace SOL_SGE
{
    public partial class Login : Form
    {
        // public object ConfigurationManager { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //instanciamos en variables los contenedores de los textos
            string email = txtEmail.Text.Trim();
            string password = txtContraseña.Text.Trim();

            // llamamos al metodo de validación de credenciales y los instanciamos en variables con su respectivo parametro
            string username = ValidateCredentials(email, password);


            if (!string.IsNullOrEmpty(username))
            {

                MessageBox.Show($"Bienvenido: {username}!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashUser.DashUserControl frm = new DashUser.DashUserControl(email);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso no autorizado. Verifica tus datos.");
            }

        }


        private string ValidateCredentials(string email, string password)
        {
            string nombre = null;

            string cn = @"server= localhost; userid = root; password= 1234; database = nueva_conexion";

            try
            {
                using (MySqlConnection con = new MySqlConnection(cn))
                {
                    con.Open();
                    string query = "SELECT nombre_usuario FROM usuarios WHERE email = @email AND passwordU = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombre = reader.GetString("nombre_usuario");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Acceso no autorizado. " + ex.Message);
            }

            return nombre;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
