using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRA1.Recepcion.caja_de_cobro
{
    public partial class frmImprimirPago : Form
    {
        public frmImprimirPago()
        {
            InitializeComponent();
        }

        private void frmImprimirPago_Load(object sender, EventArgs e)
        {
            txtNombreClie.Text = "Juan";
            txtApellidosClie.Text = "Limas";
            txtEstudiosPagados.Text = "Chequeo";
            txtFechaImpresion.Text = DateTime.Now.ToString();
            txtResClie.Text = "Calle Rio Nazas #128 Jardines del Canadá";
            textBox1.Text = "150";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Impreso correctamente");
        }
    }
}
