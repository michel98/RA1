using System;
using BussinesEntities;
using BusinessLogicLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRA1
{
    public partial class frmEstudiosRF01 : Form
    {
        
        public static List<EstudioRF01> listaestudios = new List<EstudioRF01>();
        frmModificarEstudio regEs = new frmModificarEstudio();
        public static bool validar = false;

        
        
        public frmEstudiosRF01()
        {
            InitializeComponent();
         
           

        }
        
        private void frmEstudiosRF01_Load(object sender, EventArgs e)
        {
           
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmModificarEstudio modes = new frmModificarEstudio();
            modes.ShowDialog();
            
           
            
            
            
        }

       

        private void btnModificar_Click(object sender, EventArgs e)
        {

            validar = true;


            listaestudios.Add(EstudioBLL.busquedaId(Convert.ToInt32(txtIdEstudio.Text))[0]);



            regEs.ShowDialog();


        }






        
        private void btnVisualizarEstudios_Click(object sender, EventArgs e)
        {
            dgvEstudios.DataSource = BusinessLogicLayer.EstudioBLL.visualizar();
        }
    }
}
