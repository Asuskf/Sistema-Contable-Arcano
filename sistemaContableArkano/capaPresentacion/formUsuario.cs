using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCrearUsuario_Click(object sender, EventArgs e)
        {

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

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosTextoMouse(txtContrasenia, lblContrasenia.Text);
            txtContrasenia.UseSystemPasswordChar = true;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosTextoMouse(txtNombre, lblNombre.Text);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosSinTextoMouse(txtNombre,lblNombre.Text);
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosTextoMouse(txtApellido, lblApellido.Text);
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosSinTextoMouse(txtApellido, lblApellido.Text);
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosTextoMouse(txtDireccion, lblDireccion.Text);
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosSinTextoMouse(txtDireccion, lblDireccion.Text);
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosTextoMouse(txtCorreo, lblCorreo.Text);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosSinTextoMouse(txtCorreo, lblCorreo.Text);
        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosTextoMouse(txtNombreUsuario, lblNombreUsuario.Text);
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosSinTextoMouse(txtNombreUsuario, lblNombreUsuario.Text);
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            Controladores.controladores.cuadrosSinTextoMouse(txtContrasenia, lblContrasenia.Text);
            if (txtContrasenia.Text == lblContrasenia.Text)
                txtContrasenia.UseSystemPasswordChar = false;
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            /////dario
        }
    }
}
