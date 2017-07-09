using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntities;
using BusinessLogicLayer;
using System.Windows.Forms;
using WindowsRA1.Pacientes;

namespace WindowsRA1.Medicos_Canalizadores
{
    public partial class frmDatosDeMedicoCan : Form
    {
        public static int idmed;
        public frmDatosDeMedicoCan()
        {
            InitializeComponent();
        }

        private void btnVisMedCan_Click(object sender, EventArgs e)
        {
            dgvMedicosCan.DataSource = BusinessLogicLayer.MedicoCanalizadorBLL.visualizar();
        }

        private void btnVerEstudios_Click(object sender, EventArgs e)
        {
            frmdatosmedicos datmed = new frmdatosmedicos();
            idmed = Convert.ToInt32(txtIDMedCanBuscar.Text);
            datmed.ShowDialog();
        }
    }
}
