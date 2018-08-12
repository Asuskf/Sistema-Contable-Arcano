using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    static class Program
    {
        public static int idUsuario;
        public static string nombreUsuario;
        public static string nombre;
        public static string apellido;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formMenuPrincipal());
            Application.Run(new formMenuPrincipal());
        }
    }
}
