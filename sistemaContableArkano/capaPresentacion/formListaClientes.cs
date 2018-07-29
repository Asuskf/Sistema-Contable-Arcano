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
    public partial class formListaClientes : Form
    {
        ConexionBD capaDatos = new ConexionBD();
        public formListaClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

       

        private void formListaClientes_Load(object sender, EventArgs e)
        {
            string tipoCliente = "Cliente";
            capaDatos.verClientes(dgvListaCliente, tipoCliente);

        }
    }
}
