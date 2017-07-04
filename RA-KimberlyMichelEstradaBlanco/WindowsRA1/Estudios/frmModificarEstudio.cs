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
    public partial class frmModificarEstudio : Form
    {
       
        
        public frmModificarEstudio()
        {
            InitializeComponent();
            rboSuspendido.Checked=true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            frmEstudiosRF01 mod = new frmEstudiosRF01();
            this.Hide();
            mod.ShowDialog();
            
            this.Close();
        }

        private void frmModificarEstudio_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEstudiosRF01 mod = new frmEstudiosRF01();
            this.Hide();
            mod.ShowDialog();
            this.Close();
        }
       
        
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            

            bool ActSus;
            if (rboActivo.Checked)
            {

                ActSus = true;
            }
            else
            {
                ActSus = false;
            }

            List <EstudiosRF01> listaestudios = new List<EstudiosRF01>();
            EstudiosRF01 est = new EstudiosRF01(txtId.Text, txtNombre.Text, txtDescripcion.Text, cboCategoria.SelectedItem.ToString(), Convert.ToDouble(txtCosto.Text.ToString()), ActSus);
            
            listaestudios.Add(est);
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            cboCategoria.SelectedItem = null;
            txtCosto.Clear();
            rboSuspendido.Checked=true;
            
            
            
        }
    }
}
