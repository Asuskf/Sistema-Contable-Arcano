using capaDatos;
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
    public partial class formIngresoVentas : Form
    {
        ConexionBD conectar = new ConexionBD();
        capaDatos.ConexionBD capaDatos = new capaDatos.ConexionBD();
        capaPresentacion.Controladores.controladores validarDatos = new capaPresentacion.Controladores.controladores();

        public formIngresoVentas()
        {
            InitializeComponent();
            capaDatos.buscarComboboxUsuario(cmbNombre, 2);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnAniadirVenta_Click(object sender, EventArgs e)
        {
            verificarControles();
            if (camposllenos == true)
            {
                string precioConvertido = validarDatos.valorMoneda2(this.txtPrecio.Text);
                MessageBox.Show(capaDatos.IngresarCompraVenta(cmbNombre, 2, txtDescripccionVenta.Text, dateTimeFecha.Text, txtAutorizacionFactura.Text, dateTimeFechaVencimiento.Text, txtDescripcionVenta2.Text, precioConvertido, Convert.ToInt32(txtCantidad.Text)));
                capaDatos.verCompraVenta(dgvDetalleVenta, 2);
                limpiarControles2();
                camposllenos = false;
            }
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            capaDatos.cargarDatos(cmbNombre, txtCI_RUCProveedor, txtCorreo);
        }

        private void formIngresoVentas_Load(object sender, EventArgs e)
        {
            capaDatos.verCompraVenta(dgvDetalleVenta, 2);

        }

        bool camposllenos = false;
        public void verificarControles()
        {
            if (txtDescripccionVenta.Text == "" && txtAutorizacionFactura.Text == "" && txtDescripcionVenta2.Text == "" && txtCantidad.Text == "" && txtPrecio.Text == "")
            {
                MessageBox.Show("Favor, debe llenar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripccionVenta.Focus();
            }
            else if (txtDescripccionVenta.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción de la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripccionVenta.Focus();
            }
            else if (txtAutorizacionFactura.Text == "")
            {
                MessageBox.Show("Debe ingresar una autorización de la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAutorizacionFactura.Focus();
            }
            else if (txtDescripcionVenta2.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción del servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionVenta2.Focus();
            }
            else if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
            }
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar el precio de la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
            }
            else
            {
                camposllenos = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            validarDatos.validarNumerosEnteros(txtCantidad);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            validarDatos.validarMoneda(txtPrecio);
        }

        int transaccionID;
        private void dgvDetalleVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            transaccionID = Convert.ToInt32(dgvDetalleVenta.CurrentRow.Cells[0].Value);
            this.txtCI_RUCProveedor.Text = dgvDetalleVenta.CurrentRow.Cells[1].Value.ToString();
            this.cmbNombre.Text = dgvDetalleVenta.CurrentRow.Cells[2].Value.ToString();
            this.txtAutorizacionFactura.Text = dgvDetalleVenta.CurrentRow.Cells[3].Value.ToString();
            this.txtDescripccionVenta.Text = dgvDetalleVenta.CurrentRow.Cells[4].Value.ToString();
            this.txtDescripcionVenta2.Text = dgvDetalleVenta.CurrentRow.Cells[5].Value.ToString();
            this.txtCantidad.Text = dgvDetalleVenta.CurrentRow.Cells[6].Value.ToString();
            double cc = Convert.ToDouble(dgvDetalleVenta.CurrentRow.Cells[7].Value.ToString());
            this.txtPrecio.Text = cc.ToString("#,##0.00");
            this.dateTimeFecha.Text = dgvDetalleVenta.CurrentRow.Cells[8].Value.ToString();
            this.dateTimeFechaVencimiento.Text = dgvDetalleVenta.CurrentRow.Cells[9].Value.ToString();
            dgvDetalleVenta.CurrentRow.Selected = true; //permite dejar seleccionada la fila
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(capaDatos.eliminarCompraVenta(transaccionID));
            capaDatos.verCompraVenta(dgvDetalleVenta, 2);
            limpiarControles2();
            camposllenos = false;
        }
        public void limpiarControles2()
        {
            txtDescripccionVenta.Text = "";
            txtAutorizacionFactura.Text = "";
            txtDescripcionVenta2.Text = "";
            txtCantidad.Text = "0";
            txtPrecio.Text = "0.00";
            cmbNombre.Text = "";
            txtCI_RUCProveedor.Text = "";
            txtCorreo.Text = "";
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {
            verificarControles();
            if (camposllenos == true)
            {
                string precioConvertido = validarDatos.valorMoneda2(txtPrecio.Text);
                MessageBox.Show(capaDatos.actualizarCompraVenta(cmbNombre, 2, txtDescripccionVenta.Text, dateTimeFecha.Text, txtAutorizacionFactura.Text, dateTimeFechaVencimiento.Text, txtDescripcionVenta2.Text, precioConvertido, Convert.ToInt32(txtCantidad.Text), transaccionID));
                capaDatos.verCompraVenta(dgvDetalleVenta, 2);
                limpiarControles2();
                camposllenos = false;
            }
        }
    }
}
