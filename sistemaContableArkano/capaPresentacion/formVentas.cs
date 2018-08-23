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
    public partial class formVentas : Form
    {
        Controladores.controladores controladores = new Controladores.controladores();

        public formVentas()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelVentas, new formListaClientes());
            controladores.controladorBotonesMenSec(btnClientes, btnIngresoVentas, 210, 122, 65, btnReporte, 10, 161, 141);
        }

        private void btnIngresoVentas_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelVentas, new formIngresoVentas());
            controladores.controladorBotonesMenSec(btnIngresoVentas, btnClientes, 56, 77, 140, btnReporte, 10, 161, 141);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelVentas, new formReporteVentas());
            controladores.controladorBotonesMenSec(btnReporte, btnClientes, 56, 77, 140, btnIngresoVentas, 210, 122, 65);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
