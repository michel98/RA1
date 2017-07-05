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
        frmModificarEstudio mod2 = new frmModificarEstudio();
        List<EstudiosRF01> listaestudios = new List<EstudiosRF01>();

        public bool validacion = true;
        public string vartemp;
        frmModificarEstudio mod;
        public frmEstudiosRF01()
        {
            InitializeComponent();
         
           

        }
        
        private void frmEstudiosRF01_Load(object sender, EventArgs e)
        {
            mod = new frmModificarEstudio();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
            mod.ShowDialog();
            
            
            
        }

       

        private void btnModificar_Click(object sender, EventArgs e)
        {

            modificar(mod2.txtId.Text);

        }






        public void modificar(string id)
        {
           foreach(var EstudiosRF01 in listaestudios)
            {
                if (EstudiosRF01.Id==id)

                {
                    EstudiosRF01.Id = mod2.txtId.Text;
                    EstudiosRF01.Nombre = mod2.txtNombre.Text;
                    EstudiosRF01.Descripcion = mod2.txtDescripcion.Text;
                    EstudiosRF01.Categoría = mod2.cboCategoria.Text;
                    EstudiosRF01.Costo = (Convert.ToInt32(mod2.txtCosto.Text));



                      

                }
            }
        }
        private void btnVisualizarEstudios_Click(object sender, EventArgs e)
        {
           
        }
    }
}
