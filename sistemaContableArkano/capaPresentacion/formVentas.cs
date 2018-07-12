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
            controladores.abrirFormularioPanel(panelContenedorVentas, new formListaClientes());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelContenedorVentas, new formReporteVentas());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresoVentas_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelContenedorVentas, new formIngresoVentas());
            //////////comentariossssssssssssssss
        }
    }
}
