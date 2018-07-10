using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace capaPresentacion.Controladores
{
    class controladores
    {
        //Permite mover los formularios y arrastrarlos con mantener presionado el clic izquierdo del mouse
        public static class moverCuadro {
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

            public static void mover(IntPtr hWnd, int wMsg, int wParam, int lParam) {
                ReleaseCapture();
                SendMessage(hWnd, wMsg, wParam, lParam);
            }
        }
        public  void cuadrosTextoMouse(TextBox textBox, string dialogo)
        {
            if (textBox.Text == dialogo) 
                textBox.Text = "";

        }

        public  void cuadrosSinTextoMouse(TextBox textBox, string dialogo)
        {
            if (textBox.Text == "")
                textBox.Text = dialogo;
        }

        public  void colorBotones(Button btnDesabilitar, Button botonHabilitar, int R, int G, int B, Label lblLista, string lista)
        {
            btnDesabilitar.BackColor = Color.FromArgb(121, 128, 130);
            btnDesabilitar.Enabled = false;
            botonHabilitar.BackColor = Color.FromArgb(R, G, B);
            botonHabilitar.Enabled = true;
            lblLista.Text = lista;
        }

        public void abrirFormularioPanel(Panel panelContenedor, object formHijo)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            Form formulario = formHijo as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;
            formulario.Show();
        }

    }
}

