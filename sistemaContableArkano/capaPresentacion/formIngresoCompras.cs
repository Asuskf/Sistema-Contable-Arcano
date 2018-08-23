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
        capaPresentacion.Controladores.controladores validarDatos = new capaPresentacion.Controladores.controladores();

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
            verificarControles();
            if (camposllenos == true)
            {
                double precioConvertido2 = Convert.ToDouble(txtPrecio.Text);
                string precioConvertido = validarDatos.valorMoneda2(precioConvertido2.ToString());
                //string precioConvertido = validarDatos.valorMoneda2(txtPrecio.Text);
                MessageBox.Show(capaDatos.IngresarCompraVenta(cmbNombre, 1, txtDescripcionCompra.Text, dateTimeFecha.Text, txtAutorizacionCompra.Text, dateTimeFechaVencimiento.Text, txtDescripcionCompra2.Text, precioConvertido, Convert.ToInt32(txtCantidadCompra.Text)));
                capaDatos.verCompraVenta(dgvDetalleCompra, 1);
                limpiarControles2();
                camposllenos = false;
            }
        }
        
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            capaDatos.cargarDatos(cmbNombre, txtProveedorCI_RUC, txtCorreo);
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            verificarControles();
            if (camposllenos == true)
            {
                double precioConvertido2 = Convert.ToDouble(txtPrecio.Text);
                string precioConvertido = validarDatos.valorMoneda2(precioConvertido2.ToString());
                MessageBox.Show(capaDatos.actualizarCompraVenta(cmbNombre, 1, txtDescripcionCompra.Text, dateTimeFecha.Text, txtAutorizacionCompra.Text, dateTimeFechaVencimiento.Text, txtDescripcionCompra2.Text, precioConvertido, Convert.ToInt32(txtCantidadCompra.Text), transaccionID));
                capaDatos.verCompraVenta(dgvDetalleCompra, 1);
                limpiarControles2();
                camposllenos = false;
            }

        }

        private void formIngresoCompras_Load(object sender, EventArgs e)
        {
            capaDatos.verCompraVenta(dgvDetalleCompra, 1);
        }

        bool camposllenos = false;
        public void verificarControles()
        {
            if (txtDescripcionCompra.Text == "" && txtAutorizacionCompra.Text == "" && txtDescripcionCompra2.Text == "" && txtCantidadCompra.Text == "" && txtPrecio.Text == "")
            {
                MessageBox.Show("Favor, debe llenar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionCompra.Focus();
            }
            else if (txtDescripcionCompra.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción de la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionCompra.Focus();
            }
            else if (txtAutorizacionCompra.Text == "")
            {
                MessageBox.Show("Debe ingresar una autorización de la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAutorizacionCompra.Focus();
            }
            else if (txtDescripcionCompra2.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción del servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionCompra2.Focus();
            }
            else if (txtCantidadCompra.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidadCompra.Focus();
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

        private void txtCantidadCompra_TextChanged(object sender, EventArgs e)
        {
            validarDatos.validarNumerosEnteros(txtCantidadCompra);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            validarDatos.validarMoneda(txtPrecio);
        }

        private void txtProveedorCI_RUC_TextChanged(object sender, EventArgs e)
        {

        }

        int transaccionID;
        private void dgvDetalleCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            transaccionID = Convert.ToInt32(dgvDetalleCompra.CurrentRow.Cells[0].Value);
            this.txtProveedorCI_RUC.Text = dgvDetalleCompra.CurrentRow.Cells[1].Value.ToString();
            this.cmbNombre.Text = dgvDetalleCompra.CurrentRow.Cells[2].Value.ToString();
            this.txtAutorizacionCompra.Text = dgvDetalleCompra.CurrentRow.Cells[3].Value.ToString();
            this.txtDescripcionCompra.Text = dgvDetalleCompra.CurrentRow.Cells[4].Value.ToString();
            this.txtDescripcionCompra2.Text = dgvDetalleCompra.CurrentRow.Cells[5].Value.ToString();
            this.txtCantidadCompra.Text = dgvDetalleCompra.CurrentRow.Cells[6].Value.ToString();
            double cc = Convert.ToDouble(dgvDetalleCompra.CurrentRow.Cells[7].Value.ToString());
            this.txtPrecio.Text = cc.ToString("#,##0.00");
            this.dateTimeFecha.Text = dgvDetalleCompra.CurrentRow.Cells[8].Value.ToString();
            this.dateTimeFechaVencimiento.Text = dgvDetalleCompra.CurrentRow.Cells[9].Value.ToString();
            dgvDetalleCompra.CurrentRow.Selected = true; //permite dejar seleccionada la fila

        }

        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(capaDatos.eliminarCompraVenta(transaccionID));
            capaDatos.verCompraVenta(dgvDetalleCompra, 1);
            limpiarControles2();
            camposllenos = false;
        }

        public void limpiarControles2()
        {
            txtDescripcionCompra.Text = "";
            txtAutorizacionCompra.Text = "";
            txtDescripcionCompra2.Text = "";
            txtCantidadCompra.Text = "0";
            txtPrecio.Text = "0.00";
            cmbNombre.Text = "";
            txtProveedorCI_RUC.Text = "";
            txtCorreo.Text = "";
        }
    }
}
