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
        public formMenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void abrirFormularioPanel(object formHijo) {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form formulario = formHijo as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formulario);
            this.panelContenedor.Tag = formulario;
            formulario.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            abrirFormularioPanel(new formUsuario());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblReloj_Click(object sender, EventArgs e)
        {
            //relooj
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ///comentario en la asasa
        }
    }
}
