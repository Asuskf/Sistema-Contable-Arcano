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
            // TODO: esta línea de código carga datos en la tabla 'sistemaContableArcano2DataSet.TB_TIPO_TRANSACCION' Puede moverla o quitarla según sea necesario.
           

        }
    }
}
