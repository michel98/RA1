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
    public partial class frmestudiospacientes : Form
    {
        public frmestudiospacientes()
        {
            InitializeComponent();
        }

        private void frmestudiospacientes_Load(object sender, EventArgs e)
        {
            //BusinessLogicLayer.ServicioBLL.busquedaIdPac(frmGestionPacientes.idpac);
            //txtNombreDelPac.Text = BusinessLogicLayer.PacienteBLL.visualizar()[0].Nombre;
            //txtApellidos.Text = BusinessLogicLayer.PacienteBLL.visualizar()[0].Apellidos;
            dgvEstudiosDepac.DataSource = BusinessLogicLayer.ServicioBLL.busquedaIdPac(frmGestionPacientes.idpac);

            for (int i=0;i<BusinessLogicLayer.PacienteBLL.visualizar().Count();i++) {
                if (BusinessLogicLayer.PacienteBLL.visualizar()[i].Id==frmGestionPacientes.idpac) {
                    txtNombreDelPac.Text = BusinessLogicLayer.PacienteBLL.visualizar()[i].Nombre;
                    txtApellidos.Text = BusinessLogicLayer.PacienteBLL.visualizar()[i].Apellidos;
                }
            }
        }
    }
}
