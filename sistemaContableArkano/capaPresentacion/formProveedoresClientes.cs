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
    public partial class formProveedoresClientes : Form
    {
        public formProveedoresClientes()
        {
            InitializeComponent();
        }
        Controladores.controladores controladores = new Controladores.controladores();
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtCedula, lblCedula.Text);
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
           controladores.cuadrosSinTextoMouse(txtCedula, lblCedula.Text);
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtNombre, lblNombre.Text);
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

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtCorreo, lblCorreo.Text);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtCorreo, lblCorreo.Text);
        }

        private void txtDirección_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtDirección, lblDireccion.Text);
        }

        private void txtDirección_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtDirección, lblDireccion.Text);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            controladores.colorBotones(btnClientes, btnProveedor, 218, 154, 72,lblLista,"Lista Clientes");
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            controladores.colorBotones(btnProveedor,btnClientes,142,81,4,lblLista,"Lista Proveedores");
        }
    }
}
