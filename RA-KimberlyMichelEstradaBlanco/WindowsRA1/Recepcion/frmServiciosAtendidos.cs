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
    public partial class frmServiciosAtendidos : Form
    {
        public frmServiciosAtendidos()
        {
            InitializeComponent();
        }

        private void frmServiciosAtendidos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogicLayer.ServicioBLL.visualizarnopagados(false);
        }

        private void btnBuscarDetalle_Click(object sender, EventArgs e)
        {
            frmServicioDetalle servdet = new frmServicioDetalle();
            servdet.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
