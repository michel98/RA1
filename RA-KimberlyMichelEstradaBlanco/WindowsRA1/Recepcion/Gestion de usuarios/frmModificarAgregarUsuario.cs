using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BussinesEntities;

namespace WindowsRA1.Recepcion.Gestion_de_usuarios
{
    public partial class frmModificarAgregarUsuario : Form
    {
        Usuario us = new Usuario();
        public frmModificarAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                us.UserName = textBox1.Text;
                us.Passwd = textBox2.Text;
                us.Activo = chkActivo.Checked;
                
            }
            catch {

            }
            string mensaje = BusinessLogicLayer.UsuarioBLL.insertar(us);
            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("El usuario se registro correctamente");
                textBox1.Text = "";
                textBox2.Text = "";
                chkActivo.Checked = false;
                cboFuncion.SelectedItem = "";


            }
            else
            {
                MessageBox.Show(mensaje, "Error");
            }

           
        }
    }
}
