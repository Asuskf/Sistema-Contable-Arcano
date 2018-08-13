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
    public partial class formIngresoAsiento : Form
    {
        ConexionBD capaDatos = new ConexionBD();

        int idAsiento;
        public formIngresoAsiento()
        {
            InitializeComponent();
            try
            {
                capaDatos.buscarComboboxItemAsiento(cmbValor);
                capaDatos.buscarComboboxItemAsiento(cmbIva);
                capaDatos.buscarComboboxItemAsiento(cmbTotal);
            }
            catch (Exception ex) {
                MessageBox.Show("Ha surgido un problema "+ex);
            }
        }

        private void cmbValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            capaDatos.cargarDatosAsientos(cmbValor, lblDesCodigo);
        }

        private void cmbIva_SelectedIndexChanged(object sender, EventArgs e)
        {
            capaDatos.cargarDatosAsientos(cmbIva, lblDesIva);
        }

        private void cmbTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            capaDatos.cargarDatosAsientos(cmbTotal, lblDesTotal);
        }

        private void formIngresoAsiento_Load(object sender, EventArgs e)
        {
            capaDatos.verAsientos(dgvAsientos, 0);
        }

        private void btnAsiIngresados_Click(object sender, EventArgs e)
        {
            capaDatos.verAsientos(dgvAsientos, 1);
        }

        private void btnAsiSinIngresar_Click(object sender, EventArgs e)
        {
            capaDatos.verAsientos(dgvAsientos, 2);
        }

        private void dgvAsientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double valor = Convert.ToDouble(dgvAsientos.CurrentRow.Cells[2].Value);
            double iva = (valor * 0.12);
            double total = (valor * 1.12);

            idAsiento = Convert.ToInt32(dgvAsientos.CurrentRow.Cells[0].Value);
            lblDesTransaccion.Text = dgvAsientos.CurrentRow.Cells[1].Value.ToString();
            lblValor.Text = dgvAsientos.CurrentRow.Cells[2].Value.ToString();
            lblIva.Text = iva.ToString();
            lblTotal.Text = total.ToString();
        }

        private void btnBusAsiento_Click(object sender, EventArgs e)
        {
            capaDatos.verAsientosFecha(dgvAsientos, dtmDesde.Text, dtmDesde.Text);
            
        }
    }
}
