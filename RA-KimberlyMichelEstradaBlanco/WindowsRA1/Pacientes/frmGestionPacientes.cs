using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRA1.Pacientes
{
    public partial class frmGestionPacientes : Form
    {
        public static int idpac;
        public frmGestionPacientes()
        {
            InitializeComponent();
        }

        private void frmGestionPacientes_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmestudiospacientes estpac = new frmestudiospacientes();
            idpac = Convert.ToInt32(txtVerEstudios.Text);
            estpac.ShowDialog();
        }

        private void btnvisualizar_Click(object sender, EventArgs e)
        {
            dgvpacientes.DataSource = BusinessLogicLayer.PacienteBLL.visualizar();
        }
    }
}
