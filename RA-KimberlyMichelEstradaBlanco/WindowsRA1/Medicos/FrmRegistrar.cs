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

namespace WindowsRA1.Medicos
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //instancia del medico
            MedicoRF02 med = new MedicoRF02();

            //llenar con informacion
            try {

               
                med.Nombre = txtNombreMed.Text;
                med.Apellidoos = txtApellidoMed.Text;
                med.Area = cboArea.SelectedItem.ToString();
                med.Esp_O_Cargo = txtEspecCar.Text;
                med.Ced_Profesional = txtCedula.Text;
            }
            catch {
                
            }

                    string mensaje = BusinessLogicLayer.MedicoBLL.insertar(med);
                    if (string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show("El producto se registro correctamente");
                    }
                    else
                    {
                        MessageBox.Show(mensaje,"Error");
                    }
           

        }
    }
}
