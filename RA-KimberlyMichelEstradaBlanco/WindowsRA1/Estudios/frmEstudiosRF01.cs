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
            
            this.Hide();
            mod.ShowDialog();
            this.Close();
            
            
        }

        public void cboEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            vartemp = cboEstudios.SelectedItem.ToString();
            this.Hide();
            mod.ShowDialog();
            this.Close();

            validacion = false;
        }
    }
}
