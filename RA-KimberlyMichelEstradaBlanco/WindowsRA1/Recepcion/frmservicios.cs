using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BussinesEntities;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRA1.Recepcion
{
    public partial class frmservicios : Form
    {
        public frmservicios()
        {
            InitializeComponent();
            autocompletarText();
        }

        void autocompletarText() {
            txtNomPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNomPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll= new AutoCompleteStringCollection();

            string constring = "Database=cetcru;Data Source=localhost;User Id=root;Password=estadosunidos123";
            string query = "select * from PacienteRF03;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read()) {
                    string sNombre = myReader.GetString("Nombre");
                    coll.Add(sNombre);

                }
                txtNomPaciente.AutoCompleteCustomSource = coll;
            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmservicios_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < BusinessLogicLayer.EstudioBLL.visualizar().Count();i++)
            {
                cboEstudio.Items.Add(BusinessLogicLayer.EstudioBLL.visualizar()[i].Nombre);
            }
            txtFecha.Text= DateTime.Now.ToString();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {

        }

        private void txtNomPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

  

        private void txtNomPaciente_DoubleClick(object sender, EventArgs e)
        {
            List<PacienteRF03> listapac = new List<PacienteRF03>();

            BusinessLogicLayer.PacienteBLL.busquedaNombre(txtNomPaciente.Text);

            listapac.Add(BusinessLogicLayer.PacienteBLL.busquedaNombre(txtNomPaciente.Text)[0]);

            txtIdPac.Text = listapac[0].Id.ToString();
            txtApellidosPac.Text = listapac[0].Apellidos;
            txtEdadPac.Text = listapac[0].Edad.ToString();
            cboSexo.SelectedItem = listapac[0].Sexo;
            txtResidenciaPac.Text = listapac[0].Lugar_Residencia;
            txtIdPac.Enabled = false;
        }
    }
}
