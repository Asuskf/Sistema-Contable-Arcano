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
    public partial class formListaProveedores : Form
    {
        ConexionBD capaDatos = new ConexionBD();
        public formListaProveedores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        
        private void formListaProveedores_Load(object sender, EventArgs e)
        {
            string tipoCliente = "Proveedor";
            capaDatos.verClientes(dgvListaProveedores, tipoCliente);

        }
    }
}
