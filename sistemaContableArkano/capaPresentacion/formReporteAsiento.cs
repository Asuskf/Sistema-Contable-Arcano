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

namespace capaPresentacion
{
    public partial class formReporteAsiento : Form
    {
        ConexionBD capaDatos = new ConexionBD();

        public formReporteAsiento()
        {
            InitializeComponent();
            capaDatos.buscarComboboxItemAsiento(cmbValor);
        }

        private void cmbValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            capaDatos.cargarDatosAsientos(cmbValor, lblDesCodigo);
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            dgvReporteCompras.Rows.Clear();
            double valorDebe, valorHaber,valorSaldo=0;
            int contadorGRID = 0;
            int plaindID = Convert.ToInt32(cmbValor.SelectedValue);
            capaDatos.mostrarReporteAsiento(plaindID, dgvReporteCompras);

            foreach (DataGridViewRow row2 in dgvReporteCompras.Rows)    //Recorre todo el grid
            {
                valorDebe = Convert.ToDouble(dgvReporteCompras.Rows[contadorGRID].Cells[4].Value);
                valorHaber= Convert.ToDouble(dgvReporteCompras.Rows[contadorGRID].Cells[5].Value);

                if(valorDebe!=0)
                {
                    valorSaldo = valorSaldo + valorDebe;
                    dgvReporteCompras.Rows[contadorGRID].Cells[6].Value = valorSaldo.ToString("#,##0.00");
                }
                else if(valorHaber!=0)
                {
                    valorSaldo = valorSaldo - valorHaber;
                    dgvReporteCompras.Rows[contadorGRID].Cells[6].Value = valorSaldo.ToString("#,##0.00");
                }
                contadorGRID++;
            }
            contadorGRID = 0;
        }
    }
}
