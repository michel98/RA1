using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsRA1.Medicos;
using WindowsRA1.Medicos_Canalizadores;
using WindowsRA1.Pacientes;
using WindowsRA1.Recepcion.caja_de_cobro;

namespace WindowsRA1.Recepcion
{
    public partial class frmRecepcion : Form
    {
        public frmRecepcion()
        {
            InitializeComponent();
        }

        private void frmRecepcion_Load(object sender, EventArgs e)
        {

        }

        private void btnEstudios_Click(object sender, EventArgs e)
        {
            frmEstudiosRF01 est = new frmEstudiosRF01();
            est.ShowDialog();
        }

        private void btnMedEst_Click(object sender, EventArgs e)
        {
            FrmGestionDeMedicos medest = new FrmGestionDeMedicos();
            medest.ShowDialog();
        }

        private void btnMedCan_Click(object sender, EventArgs e)
        {
            frmDatosDeMedicoCan damedcan = new frmDatosDeMedicoCan();
            damedcan.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmGestionPacientes pac = new frmGestionPacientes();
            pac.ShowDialog();
        }

        private void btnCobro_Click(object sender, EventArgs e)
        {
            frmCobros cob = new frmCobros();
            cob.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmGestionUsuarios us = new frmGestionUsuarios();
            us.ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            frmservicios serv = new frmservicios();
            serv.ShowDialog();
        }

        private void btnServiciosAt_Click(object sender, EventArgs e)
        {
            frmServiciosAtendidos serat = new frmServiciosAtendidos();
            serat.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmVisualizarServiciosMedico sermed = new frmVisualizarServiciosMedico();
            sermed.ShowDialog();
        }
    }
}
