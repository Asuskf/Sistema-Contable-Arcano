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
    public partial class formMenuPrincipal : Form
    {
        
        Controladores.controladores controladores = new Controladores.controladores();
        capaDatos.ConexionBD capaDatos = new capaDatos.ConexionBD();

        public formMenuPrincipal()
        {
            InitializeComponent();
            mostrarInicio();

            capaDatos.verImagen(pbIconoUsuario, Program.nombreUsuario);

            lblNombreUsuario.Text = Program.nombreUsuario;
            lblNombre2.Text = Program.nombre;
            lblApellido.Text = Program.apellido;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 210)
                menuVertical.Width = 64;
            else
                menuVertical.Width = 210;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            Controladores.controladores.moverCuadro.mover(this.Handle, 0x112, 0xf012, 0);
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Controladores.controladores.moverCuadro.mover(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            formUsuario frmUsu = new formUsuario();
            frmUsu.iconoPasado += new formUsuario.pasarIcono(ejecutar);
            frmUsu.FormClosed += new FormClosedEventHandler(mostrarInicioCerrar);
            controladores.abrirFormularioPanel(panelContenedor, frmUsu);
            controladores.controladorBotonesMenPrin(btnUsuario, btnCompras, btnVentas, btnProveedorCliente, btnAsientoa);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnCompras_Click(object sender, EventArgs e)
        {
            formCompras frmC = new formCompras();
            frmC.FormClosed += new FormClosedEventHandler(mostrarInicioCerrar);
            controladores.abrirFormularioPanel(panelContenedor, frmC);
            controladores.controladorBotonesMenPrin(btnCompras, btnVentas, btnUsuario, btnProveedorCliente, btnAsientoa);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            formProveedoresClientes frmP = new formProveedoresClientes();
            frmP.FormClosed += new FormClosedEventHandler(mostrarInicioCerrar);
            controladores.abrirFormularioPanel(panelContenedor, frmP);
            controladores.controladorBotonesMenPrin(btnProveedorCliente, btnVentas, btnUsuario, btnCompras, btnAsientoa);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            formVentas frmV = new formVentas();
            frmV.FormClosed += new FormClosedEventHandler(mostrarInicioCerrar);
            controladores.abrirFormularioPanel(panelContenedor, frmV);
            controladores.controladorBotonesMenPrin(btnVentas,btnUsuario,btnCompras,btnProveedorCliente,btnAsientoa);
        }
        private void mostrarInicio()
        {
            controladores.abrirFormularioPanel(panelContenedor, new formMenuInicio());
        }
        private void mostrarInicioCerrar(object sender, FormClosedEventArgs e)
        {
            mostrarInicio();

        }

        public void ejecutar(Image iconoUsuario)
        {

            this.pbIconoUsuario.Image = iconoUsuario;
        }

        private void btnAsientoa_Click(object sender, EventArgs e)
        {
            formAsientos frmA = new formAsientos();
            frmA.FormClosed += new FormClosedEventHandler(mostrarInicioCerrar);
            controladores.abrirFormularioPanel(panelContenedor, frmA);
            controladores.controladorBotonesMenPrin(btnAsientoa, btnUsuario, btnCompras, btnVentas, btnProveedorCliente);
        }
    }
}
