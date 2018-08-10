using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;
using System.Security.Cryptography;

namespace capaPresentacion
{
    
    public partial class formUsuario : Form
    {
        Controladores.controladores controladores = new Controladores.controladores();
        ConexionBD ingresarUsuario = new ConexionBD();  //instanciamos la clase conexion para ingresar un nuevo usuario
        formMenuPrincipal FormMenuPrincipal = new formMenuPrincipal.actualizarImage();
        int IDUsuarioModif;
        private string contrasenia = null;


        public formUsuario()
        {
            InitializeComponent();
            llenarGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtNombre_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtNombre, lblNombre.Text);
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtCorreo, lblCorreo.Text);
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_3(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtNombre, lblNombre.Text);
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtApellido, lblApellido.Text);
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtApellido, lblApellido.Text);
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtDireccion, lblDireccion.Text);
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtDireccion, lblDireccion.Text);

        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtNombreUsuario, lblNombreUsuario.Text);
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtNombreUsuario, lblNombreUsuario.Text);
        }

        private void txtContrasenia_Enter_1(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtContrasenia, lblContrasenia.Text);
            txtContrasenia.UseSystemPasswordChar = true;
        }

        private void txtContrasenia_Leave_1(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtContrasenia, lblContrasenia.Text);
            if (txtContrasenia.Text == lblContrasenia.Text)
                txtContrasenia.UseSystemPasswordChar = false;
        }

        private void txtCorreo_Leave_1(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtCorreo, lblCorreo.Text);
        }

        ////////Metodo que llenara el DtaGridView con la lista de usuarios existentes
        public void llenarGrid()
        {
            string mysProducto2;
            mysProducto2 = "select usuID,usuNombre,usuApellido,usuDireccion,usuCorreo,usuNombreUsuario,usuContrasena from TB_USUARIO";

            ingresarUsuario.LLenarGrid(dgvListaUsuarios, mysProducto2); //me listara todos los productos que tienen subcategoria
        }

        ///////Metodo para agregar un nuevo usuario
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtApellido.Text == "" && txtDireccion.Text == "" && txtCorreo.Text == "" && txtNombreUsuario.Text == "" && txtContrasenia.Text == "")
                MessageBox.Show("Favor, debe llenar el registro");
            else
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Favor, debe ingresar su nombre");
                    txtNombre.Focus();
                }
                else
                {
                    if (txtApellido.Text == "")
                    {
                        MessageBox.Show("Favor, debe ingresar su apellido");
                        txtApellido.Focus();
                    }
                    else
                    {
                        if (txtDireccion.Text == "")
                        {
                            MessageBox.Show("Favor, debe una dirección");
                            txtDireccion.Focus();
                        }
                        else
                        {
                            if (txtCorreo.Text == "")
                            {
                                MessageBox.Show("Favor, debe ingresar un correo electrónico valido");
                                txtCorreo.Focus();
                            }
                            else
                            {
                                if (txtNombreUsuario.Text == "")
                                {
                                    MessageBox.Show("Favor, debe ingresar un nombre de usuario");
                                    txtNombreUsuario.Focus();
                                }
                                else
                                {
                                    ///////Cuando han sido digitados todos los datos realizara lo siguiente
                                    if (txtContrasenia.Text != "")
                                    {
                                        string encrip2 = txtContrasenia.Text;
                                        byte[] inputbytes = System.Text.Encoding.Unicode.GetBytes(encrip2);
                                        encrip2 = Convert.ToBase64String(inputbytes);

                                        MessageBox.Show(ingresarUsuario.insertarUsuario(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtCorreo.Text, txtNombreUsuario.Text, encrip2));
                                        llenarGrid();
                                        limpiarControles();
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        ///////Metodo que servira para editar la informacion de los usuarios
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            string sentenciaActualizar;


            if (txtNombre.Text == "" && txtApellido.Text == "" && txtDireccion.Text == "" && txtCorreo.Text == "" && txtNombreUsuario.Text == "" && txtContrasenia.Text == "")
            {
                MessageBox.Show("Los datos a modificar se encuentran vacíos. Favor, debe digitar los valores deseados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para el Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para la dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Focus();
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para el correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
            }
            else if (txtNombreUsuario.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreUsuario.Focus();
            }
            else if (txtContrasenia.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasenia.Focus();
            }
            else
            {
                if (MessageBox.Show("¿Desea realmente modificar los valores del usuario?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string encrip2 = txtContrasenia.Text;
                    byte[] inputbytes = System.Text.Encoding.Unicode.GetBytes(encrip2);
                    encrip2 = Convert.ToBase64String(inputbytes);

                    sentenciaActualizar = "update TB_USUARIO set usuNombre ='" + txtNombre.Text + "', usuApellido='" + txtApellido.Text + "', usuDireccion ='" + txtDireccion.Text + "', usuCorreo ='" + txtCorreo.Text + "', usuNombreUsuario ='" + txtNombreUsuario.Text + "', usuContrasena ='" + encrip2 + "' where usuID='" + IDUsuarioModif + "'";
                    if (ingresarUsuario.actualizar(sentenciaActualizar) == false)
                    {
                        MessageBox.Show("Ocurrio un error al actualizar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuario modificado correctamente");
                        llenarGrid();
                        limpiarControles();
                    }
                }
            }
        }
        ///////Funcion para limpiar los textBox
        public void limpiarControles()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtNombreUsuario.Text = "";
            txtContrasenia.Text = "";
        }

        /////Metodo que servira cuando al dar clic en alguna celda del Grid devuelva los valores a los textBox para editar el usuario
        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string resultado = string.Empty;

            IDUsuarioModif = Convert.ToInt32(dgvListaUsuarios.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dgvListaUsuarios.CurrentRow.Cells[1].Value);
            txtApellido.Text = Convert.ToString(dgvListaUsuarios.CurrentRow.Cells[2].Value);
            txtDireccion.Text = Convert.ToString(dgvListaUsuarios.CurrentRow.Cells[3].Value);
            txtCorreo.Text = Convert.ToString(dgvListaUsuarios.CurrentRow.Cells[4].Value);
            txtNombreUsuario.Text = Convert.ToString(dgvListaUsuarios.CurrentRow.Cells[5].Value);
            
            ingresarUsuario.verImagen(pbIconoUsuario, txtNombreUsuario.Text);

            string decrip = Convert.ToString(dgvListaUsuarios.CurrentRow.Cells[6].Value);
            byte[] desencriptar = Convert.FromBase64String(decrip);
            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);
            txtContrasenia.Text = resultado;
        }

        //////Metodo que servira eliminar usuarios
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el Usuario?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sentencEliminar = "delete from TB_USUARIO where usuID = '" + IDUsuarioModif + "'";
                if (ingresarUsuario.eliminar(sentencEliminar) == true)
                {
                    MessageBox.Show("Usuario eliminado correctamente");
                    llenarGrid();
                    limpiarControles();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pbIconoUsuario.Load(this.openFileDialog1.FileName);
                    btnGuarIcoUsuario.Enabled = true;
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                
            }
        }


        private void btnGuarIcoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ingresarUsuario.guardarImagen(pbIconoUsuario, Convert.ToInt32(dgvListaUsuarios.CurrentRow.Cells[0].Value)));
            
        }
    }
}