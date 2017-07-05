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
    public partial class frmModificarEstudio : Form
    {
        
        frmEstudiosRF01 mod2= new frmEstudiosRF01();
        List<EstudiosRF01> listaestudios = new List<EstudiosRF01>();

        public frmModificarEstudio()
        {
            InitializeComponent();
            rboSuspendido.Checked=true;
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            mod2.ShowDialog();
            
            this.Close();
        }
       
        private void frmModificarEstudio_FormClosed(object sender, FormClosedEventArgs e)
        {
            
          
            
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

           
            EstudiosRF01 est = new EstudiosRF01(txtId.Text, txtNombre.Text, txtDescripcion.Text, cboCategoria.SelectedItem.ToString(), Convert.ToDouble(txtCosto.Text.ToString()), ActSus);
            listaestudios.Add(est);

            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            cboCategoria.SelectedItem = null;
            txtCosto.Clear();
            rboSuspendido.Checked=true;
            
            
            
        }

        private void frmModificarEstudio_Load(object sender, EventArgs e)
        {
            if (mod2.validacion == false)
            {
                for (int i = 0; i < listaestudios.Count(); i++) {
                    if (listaestudios[i].Nombre == mod2.vartemp)
                    {
                        txtId.Text = listaestudios[i].Id.ToString();
                        txtId.Enabled = false;
                        txtNombre.Text = listaestudios[i].Nombre.ToString();
                        txtDescripcion.Text = listaestudios[i].Descripcion.ToString();
                        txtCosto.Text = listaestudios[i].Costo.ToString();

                    }
                    else {
                        MessageBox.Show("Error");
                    }
                     
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
