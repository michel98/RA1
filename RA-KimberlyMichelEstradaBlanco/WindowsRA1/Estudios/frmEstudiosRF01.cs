using System;
using BussinesEntities;
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
            
            frmModificarEstudio mod = new frmModificarEstudio();
            this.Hide();
            mod.ShowDialog();
            this.Close();
            
            
        }

        public void cboEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        
    }
}
