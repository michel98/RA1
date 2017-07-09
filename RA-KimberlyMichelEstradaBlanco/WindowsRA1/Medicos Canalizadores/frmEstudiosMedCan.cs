using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsRA1.Medicos_Canalizadores;

namespace WindowsRA1.Pacientes
{
    public partial class frmdatosmedicos : Form
    {
        
        public frmdatosmedicos()
        {
            InitializeComponent();
        }

        private void frmdatosmedicos_Load(object sender, EventArgs e)
        {
           
            txtNombreMedCan.Text=BusinessLogicLayer.MedicoCanalizadorBLL.busquedaId(frmDatosDeMedicoCan.idmed)[0].Nombre;
            txtApellidosMedCan.Text = BusinessLogicLayer.MedicoCanalizadorBLL.busquedaId(frmDatosDeMedicoCan.idmed)[0].Apellidos;
            dgvEstudiosMedico.DataSource = BusinessLogicLayer.ServicioBLL.busquedaIdMedCan(BusinessLogicLayer.MedicoCanalizadorBLL.busquedaId(frmDatosDeMedicoCan.idmed)[0].Id);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
