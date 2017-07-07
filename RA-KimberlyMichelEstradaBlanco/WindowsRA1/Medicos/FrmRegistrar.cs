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
using WindowsRA1.Medicos;
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
            MedicoRF02 med = new MedicoRF02();
            if (MedicoBLL.validar(false))
            {

                //instancia del medico


                //llenar con informacion
                //try {


                med.Nombre = txtNombreMed.Text;
                med.Apellidos = txtApellidoMed.Text;
                med.Area = cboArea.SelectedItem.ToString();
                med.Esp_O_Cargo = txtEspecCar.Text;
                med.Cedula_Profesional = txtCedula.Text;
                //}
                //catch {

                //}
                string mensaje = BusinessLogicLayer.MedicoBLL.insertar(med);
                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("El médico se registro correctamente");
                }
                else
                {
                    MessageBox.Show(mensaje, "Error");
                }


            }
            else {
                
                    txtNombreMed.Text=FrmGestionDeMedicos.listatemp[0].Nombre;
                    txtApellidoMed.Text = FrmGestionDeMedicos.listatemp[0].Apellidos;
                    txtCedula.Text = FrmGestionDeMedicos.listatemp[0].Cedula_Profesional;
                    txtEspecCar.Text = FrmGestionDeMedicos.listatemp[0].Esp_O_Cargo;
                
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
