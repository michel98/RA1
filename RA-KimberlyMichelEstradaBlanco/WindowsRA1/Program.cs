using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsRA1.Medicos;
using WindowsRA1.Medicos_Canalizadores;
using WindowsRA1.Pacientes;
using WindowsRA1.Recepcion;
using WindowsRA1.Recepcion.caja_de_cobro;

namespace WindowsRA1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRecepcion());
        }
    }
}
