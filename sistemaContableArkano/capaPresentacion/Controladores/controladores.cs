using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

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

        public void validarNumerosEnteros(TextBox cajaTexto)
        {
            int numero;
            try
            {

                if (cajaTexto.Text == "")
                {
                    numero = 0;
                }
                else
                {
                    numero = Convert.ToInt32(cajaTexto.Text);
                }
            }
            catch (Exception ex)
            {
                if (cajaTexto.Text.Length == 10)
                {
                    
                }
                else
                {
                    MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cajaTexto.Text = "0";
                    cajaTexto.Select(0, cajaTexto.Text.Length);
                }

            }
        }
        public void validarMoneda(TextBox cajaTexto)
        {
            string moneda = string.Empty;
            double valor = 0;
            try
            {
                moneda = cajaTexto.Text.Replace(".", "").Replace(",", "");
                if (moneda.Equals(""))
                    moneda = "";

                moneda = moneda.PadLeft(3, '0');
                if (moneda.Length > 3 & moneda.Substring(0, 1) == "0")
                    moneda = moneda.Substring(1, moneda.Length - 1);

                valor = Convert.ToDouble(moneda) / 100;
                cajaTexto.Text = string.Format("{0:N}", valor);
                cajaTexto.SelectionStart = cajaTexto.Text.Length;

            }
            catch (Exception)
            {
                MessageBox.Show("Solo se permiten números con punto decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cajaTexto.Text = "0,00";
            }
        }

        public string valorMoneda2(string cajaTexto2)
        {
            for (int i = 0; i < cajaTexto2.Length; i++)
            {
                if (cajaTexto2.Substring(i, 1) == ",")
                {
                    cajaTexto2 = cajaTexto2.Replace(',', '.');
                }

            }
            string valorMoneda = cajaTexto2;
            return valorMoneda;
        }
        public void controladorBotonesMenPrin(Button activo, Button desactivado, Button desactivado2, Button desactivado3, Button desactivado4) {
            activo.BackColor = Color.FromArgb(0, 0, 0);
            desactivado.BackColor = Color.FromArgb(0, 130, 204);
            desactivado2.BackColor = Color.FromArgb(0, 130, 204);
            desactivado3.BackColor = Color.FromArgb(0, 130, 204);
            desactivado4.BackColor = Color.FromArgb(0, 130, 204);
        }

        public void controladorBotonesMenSec(Button activo, Button desactivado, int R, int G, int B, Button desactivado2, int R2, int G2, int B2) {
            activo.BackColor = Color.FromArgb(0, 0, 0);
            desactivado.BackColor = Color.FromArgb(R, G, B);
            desactivado2.BackColor = Color.FromArgb(R2, G2, B2);
        }

        public void contorladorBotonesOpcAs(Button activo, Button desactivado, int R, int G, int B) {
            activo.BackColor = Color.FromArgb(121, 128, 130);
            activo.Enabled = false;
            desactivado.BackColor = Color.FromArgb(R, G, B);
            desactivado.Enabled = true;
        }
    }
}

