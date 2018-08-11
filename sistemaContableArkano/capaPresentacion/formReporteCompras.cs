using System;
using capaDatos;
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
    public partial class formReporteCompras : Form
    {
        ConexionBD capaDatos = new ConexionBD();

        public formReporteCompras()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarGridCompras()
        {
            string fechaInicio = Convert.ToDateTime(dateTimeFechaInicio.Text).ToString("yyyy-MM-dd");
            string fechaFinal = Convert.ToDateTime(dateTimeFechaFinal.Text).ToString("yyyy-MM-dd");

            string sentenLLenarCompras = "exec SP_ReporteCompraVenta 1, '" + fechaInicio + "','" + fechaFinal + "'" ;
            capaDatos.LLenarGrid(dgvReporteCompras, sentenLLenarCompras);
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            llenarGridCompras();
        }
    }
}
