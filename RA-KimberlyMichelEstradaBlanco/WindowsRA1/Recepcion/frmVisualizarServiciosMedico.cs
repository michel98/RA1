using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRA1.Recepcion
{
    public partial class frmVisualizarServiciosMedico : Form
    {
        public frmVisualizarServiciosMedico()
        {
            InitializeComponent();
        }

        private void btnImprimirDiagnostico_Click(object sender, EventArgs e)
        {
            frmImprimirDiagnostico imp = new frmImprimirDiagnostico();
            imp.ShowDialog();
        }

        private void frmVisualizarServiciosMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
