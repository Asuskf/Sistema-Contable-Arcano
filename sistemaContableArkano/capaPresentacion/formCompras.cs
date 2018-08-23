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
    public partial class formCompras : Form
    {
        Controladores.controladores controladores = new Controladores.controladores();

        public formCompras()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelCompras, new formListaProveedores());
            controladores.controladorBotonesMenSec(btnProveedores,btnIngresoCompras, 210, 122, 65, btnReportes,10,161,141);
        }

        private void btnIngresoCompras_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelCompras, new formIngresoCompras());
            controladores.controladorBotonesMenSec(btnIngresoCompras, btnProveedores,56,77,140, btnReportes,10, 161, 141);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelCompras, new formReporteCompras());
            controladores.controladorBotonesMenSec(btnReportes, btnIngresoCompras, 210, 122, 65, btnProveedores, 56, 77, 140);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
