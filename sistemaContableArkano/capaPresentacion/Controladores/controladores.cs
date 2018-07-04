﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;



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
        public static void cuadrosTextoMouse(TextBox textBox, string dialogo)
        {
            if (textBox.Text == dialogo) 
                textBox.Text = "";

        }

        public static void cuadrosSinTextoMouse(TextBox textBox, string dialogo)
        {
            if (textBox.Text == "")
                textBox.Text = dialogo;
        }

    }
}

