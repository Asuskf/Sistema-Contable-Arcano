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
        Controladores.controladores controladores = new Controladores.controladores();

        public formUsuario()
        {
            InitializeComponent();
           
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
    }
}
