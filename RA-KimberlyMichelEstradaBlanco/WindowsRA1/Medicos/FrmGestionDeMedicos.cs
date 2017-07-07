using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BusinessLogicLayer;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsRA1.Medicos
{
    public partial class FrmGestionDeMedicos : Form
    {
        FrmRegistrar reg = new FrmRegistrar();
        public FrmGestionDeMedicos()
        {
            InitializeComponent();
        }

        private void btnVisualizarMed_Click(object sender, EventArgs e)
        {
            dgvMedicosEstudios.DataSource = BusinessLogicLayer.MedicoBLL.visualizar();
        }

        private void btnRegistrarMed_Click(object sender, EventArgs e)
        {
            
            reg.ShowDialog();
        }

       

       
    }
}
