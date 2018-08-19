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
using capaPresentacion.Reportes.repVentas;

namespace capaPresentacion
{
    public partial class formReporteVentas : Form
    {
        ConexionBD capaDatos = new ConexionBD();

        public formReporteVentas()
        {
            InitializeComponent();
        }
        
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnMostrarReporteVentas_Click(object sender, EventArgs e)
        {
            llenarGridVentas();
        }

        public void llenarGridVentas()
        {
            string fechaInicio = Convert.ToDateTime(dateTimeFechaInicio.Text).ToString("yyyy-MM-dd");
            string fechaFinal = Convert.ToDateTime(dateTimeFechaFinal.Text).ToString("yyyy-MM-dd");

            string sentenLLenarCompras = "exec SP_ReporteCompraVenta 2, '" + fechaInicio + "','" + fechaFinal + "'";
            capaDatos.LLenarGrid(dgvReporteVentas, sentenLLenarCompras);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            repVentas rep = new repVentas();
            rep.Show();
        }
    }
}
