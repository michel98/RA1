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
        

        public frmModificarEstudio()
        {
            InitializeComponent();
            
            
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
          
        }
       
        private void frmModificarEstudio_FormClosed(object sender, FormClosedEventArgs e)
        {
            
          
            
        }
       
        
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            EstudioRF01 es = new EstudioRF01();
            bool estado;
            if (rboActivo.Checked)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            if (!frmEstudiosRF01.validar)
            {

                //instancia del medico


                //llenar con informacion
                try
                {
                    

                    es.Nombre = txtNombre.Text;
                    es.Descripcion = txtDescripcion.Text;
                    es.Categoría = cboCategoria.SelectedItem.ToString();
                    es.Costo = Convert.ToDouble(txtCosto.Text);
                    es.Estado = estado;
                    
                }
                catch
                {

                }
                string mensaje = BusinessLogicLayer.EstudioBLL.insertar(es);
                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("El estudio se registro correctamente");
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    txtCosto.Text = "";
                    cboCategoria.SelectedItem = null;
                    rboSuspendido.Checked = false;
                    rboSuspendido.Checked = true;

                }
                else
                {
                    MessageBox.Show(mensaje, "Error");
                }


            }
            else
            {
                es.Nombre = txtNombre.Text;
                es.Descripcion = txtDescripcion.Text;
                es.Categoría = cboCategoria.SelectedItem.ToString();
                es.Costo = Convert.ToDouble(txtCosto.Text);
                es.Estado = estado;

                string mensaje = BusinessLogicLayer.EstudioBLL.actualizar(es);

                MessageBox.Show(mensaje);



            }

        }

        private void frmModificarEstudio_Load(object sender, EventArgs e)
        {
            if (frmEstudiosRF01.validar)
            {
                txtNombre.Text = frmEstudiosRF01.listaestudios[0].Nombre;
                txtDescripcion.Text = frmEstudiosRF01.listaestudios[0].Descripcion;
                txtCosto.Text = frmEstudiosRF01.listaestudios[0].Costo.ToString();
                cboCategoria.SelectedItem = frmEstudiosRF01.listaestudios[0].Categoría;
                if (frmEstudiosRF01.listaestudios[0].Estado)
                {
                    rboActivo.Checked = true;
                    rboSuspendido.Checked = false;
                }
                else
                {
                    rboActivo.Checked = false;
                    rboSuspendido.Checked = true;
                }
            }
            else {

                rboActivo.Checked = false;
                rboSuspendido.Checked = true;
            }
        }
    }

     

       
    
}
