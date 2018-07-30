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
    public partial class formIngresoCompras : Form
    {
        capaDatos.ConexionBD capaDatos = new capaDatos.ConexionBD();

        public formIngresoCompras()
        {
            InitializeComponent();
            capaDatos.buscarComboboxUsuario(cmbNombre, 2);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnAniadirCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show( capaDatos.IngresarCompraVenta(cmbNombre, 1, txtDescripcionCompra.Text,dateTimeFecha.Text,txtAutorizacionCompra.Text,dateTimeFechaVencimiento.Text));
            
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            capaDatos.cargarDatos(cmbNombre, txtProveedorCI_RUC, txtCorreo);
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(capaDatos.actualizarCompra(2,cmbNombre, txtDescripcionCompra, dateTimeFecha.Text, txtAutorizacionCompra, dateTimeFechaVencimiento.Text));
        }
    }
}
