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
        }

        private void btnIngresoCompras_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelCompras, new formIngresoCompras());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelCompras, new formReporteCompras());
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
