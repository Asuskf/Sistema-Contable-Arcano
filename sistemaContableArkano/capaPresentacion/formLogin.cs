using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using capaDatos;
using System.Security.Cryptography;

namespace capaPresentacion
{
    public partial class formLogin : Form
    {
        ConexionBD conectar = new ConexionBD();   //instanciamos la clase donde se realiza la conexion a la base de datos 
        
        public formLogin()
        {
            InitializeComponent();
            
        }
        //Arrastrar con mouse para mover la ventana 

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           Controladores.controladores.moverCuadro.mover(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtPassword.Text != "")
            {
                string desencrip2 = txtPassword.Text;
                byte[] inputbytes = System.Text.Encoding.Unicode.GetBytes(desencrip2);
                desencrip2 = Convert.ToBase64String(inputbytes);

                iniciarSesion(this.txtUsuario.Text, desencrip2);
            }
            else
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre de usuario");
                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una contraseña");
                    txtPassword.Focus();
                }

            }
        }

        /////Metodo que me permitira verificar si el Nombre de usuario y contraseña del usuario existe
        public void iniciarSesion(string nomUsuario, string contraUsuario)  //Funcion para iniciar sesion y comprobar si existe el usuario  (7)
        {
            try
            {
                conectar.cnn.Open();
                SqlCommand consulUsuario = new SqlCommand("select usuNombreUsuario from TB_USUARIO where usuNombreUsuario=@usuario and usuContrasena=@contrasena", conectar.cnn);
                consulUsuario.Parameters.AddWithValue("usuario", nomUsuario);
                consulUsuario.Parameters.AddWithValue("contrasena", contraUsuario);
                SqlDataAdapter adap = new SqlDataAdapter(consulUsuario);
                DataTable dt3 = new DataTable();
                adap.Fill(dt3);
                conectar.cnn.Close();
                if (dt3.Rows.Count == 1)  //preguntara si en el datatable existe algun registro
                {
                    this.Hide();
                    string sBienveNombre = dt3.Rows[0][0].ToString();
                    MessageBox.Show("Bienvenid@ " + sBienveNombre);

                    formMenuPrincipal pantPrincipal = new formMenuPrincipal(); //instancio el formulario de la pantalla principal

                    this.Hide();
                    pantPrincipal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");
                    txtPassword.Text = "";
                    txtUsuario.Focus();
                    txtUsuario.Text = "";
                }
            }
            catch (Exception e)
            {
                //e.Message;
            }
        }
    }
}
