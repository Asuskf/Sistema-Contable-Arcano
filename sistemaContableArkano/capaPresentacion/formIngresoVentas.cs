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
        public formIngresoVentas()
        {
            InitializeComponent();
            capaDatos.buscarComboboxUsuario(cmbNombre, 1);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnAniadirVenta_Click(object sender, EventArgs e)
        {
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            capaDatos.cargarDatos(cmbNombre, txtCI_RUCProveedor, txtCorreo);
        }

        private void formIngresoVentas_Load(object sender, EventArgs e)
        {
            capaDatos.verCompraVenta(dgvDetalleVenta, 2);

        }
    }
}
