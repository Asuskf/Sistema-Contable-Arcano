using capaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        Controladores.controladores validarDatos = new Controladores.controladores();

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

            if (dgvAsientos.CurrentRow.Cells[5].Value.ToString() == "compra")
            {
                lblDebe.Text = "Haber";
                lblHaber.Text = "Debe";
            }
            else {
                lblDebe.Text = "Debe";
                lblHaber.Text = "Haber";
            }
            
            idAsiento = Convert.ToInt32(dgvAsientos.CurrentRow.Cells[0].Value);
            lblDesTransaccion.Text = dgvAsientos.CurrentRow.Cells[1].Value.ToString();
            lblValor.Text = Math.Round(valor, 2).ToString();
            lblIva.Text = Math.Round(iva, 2).ToString();
            lblTotal.Text = Math.Round(total, 2).ToString();
        }

        private void btnBusAsiento_Click(object sender, EventArgs e)
        {
            capaDatos.verAsientosFecha(dgvAsientos, dtmDesde.Text, dtmDesde.Text);
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(dgvAsientos.CurrentRow.Cells[2].Value);
            double iva = (valor * 0.12);
            double total = (valor * 1.12);

            string valorStr = validarDatos.valorMoneda2(Math.Round(valor, 2).ToString());
            string ivaStr = validarDatos.valorMoneda2(Math.Round(iva, 2).ToString());
            string totalStr = validarDatos.valorMoneda2(Math.Round(total, 2).ToString());

            if (dgvAsientos.CurrentRow.Cells[5].Value.ToString() == "compra")
            {
                MessageBox.Show(capaDatos.grabarAsiento(idAsiento, cmbValor, 1, valorStr, cmbIva, 1, ivaStr, cmbTotal, 2, totalStr));

            }
            else
            {
                MessageBox.Show(capaDatos.grabarAsiento(idAsiento, cmbValor, 2, valorStr, cmbIva, 2, ivaStr, cmbTotal, 1, totalStr));
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
