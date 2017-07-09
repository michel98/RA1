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
            autocompletarTextPaciente();
            autocompletarTextMedicoCan();
            autocompletarTextMedEst();

            rboAtendido.Checked = false;
            rboNoAtendido.Checked = true;
            rboNoPagado.Checked = true;
            rboSiPagado.Checked = false;

        }

        void autocompletarTextPaciente() {
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

        void autocompletarTextMedicoCan()
        {
            txtNombreMedCan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombreMedCan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection nueva = new AutoCompleteStringCollection();

            string constring2 = "Database=cetcru;Data Source=localhost;User Id=root;Password=estadosunidos123";
            string query2 = "select * from MedicoCanalizador;";
            MySqlConnection conBase = new MySqlConnection(constring2);
            MySqlCommand cmdBase = new MySqlCommand(query2, conBase);
            MySqlDataReader Milector;

            try
            {
                conBase.Open();
                Milector = cmdBase.ExecuteReader();

                while (Milector.Read())
                {
                    string sNombre = Milector.GetString("Nombre");
                    nueva.Add(sNombre);

                }
                txtNombreMedCan.AutoCompleteCustomSource = nueva;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        void autocompletarTextMedEst()
        {
            txtNombreMedes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombreMedes.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string constring = "Database=cetcru;Data Source=localhost;User Id=root;Password=estadosunidos123";
            string query = "select * from MedicoRF02;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string sNombre = myReader.GetString("Nombre");
                    coll.Add(sNombre);

                }
                txtNombreMedes.AutoCompleteCustomSource = coll;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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
            try
            {
                Servicio ser = new Servicio();
                bool estado, pagado;

                if (rboAtendido.Checked)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                if (rboSiPagado.Checked)
                {
                    pagado = true;
                }
                else
                {
                    pagado = false;
                }

                try
                {



                    ser.PacienteId = Convert.ToInt32(txtIdPac.Text);
                    ser.MedicoCanId = Convert.ToInt32(txtIdMedCan.Text);
                    ser.MedicoRF02Id = Convert.ToInt32(txtMedEst.Text);
                    ser.Estado = estado;
                    ser.Pagado = pagado;
                    ser.Estudio = cboEstudio.SelectedItem.ToString();
                    ser.Fecha_hora = Convert.ToDateTime(txtFecha.Text);
                }
                catch
                {

                }
                string mensaje = BusinessLogicLayer.ServicioBLL.insertar(ser);
                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("El servicio se registro correctamente");
                    txtApellidoMedCan.Text = "";
                    txtApellidosMedes.Text = "";
                    txtApellidosPac.Text = "";
                    txtCedMedCan.Text = "";
                    txtCedulaMedes.Text = "";
                    txtEdadPac.Text = "";
                    txtEspecialidadMedes.Text = "";
                    txtIdMedCan.Text = "";
                    txtIdPac.Text = "";
                    txtMedEst.Text = "";
                    txtNombreMedCan.Text = "";
                    txtNombreMedes.Text = "";
                    txtNomPaciente.Text = "";
                    txtResidenciaPac.Text = "";

                    cboArea.SelectedItem = null;
                    cboEstudio.SelectedItem = null;
                    cboSexo.SelectedItem = null;
                    rboAtendido.Checked = false;
                    rboNoAtendido.Checked = true;
                    rboSiPagado.Checked = false;
                    rboNoPagado.Checked = true;
                    txtIdMedCan.Enabled = true;
                    txtIdPac.Enabled = true;
                    txtMedEst.Enabled = true;

                }
                else
                {
                    MessageBox.Show(mensaje, "Error");
                }
            }
            catch {
                MessageBox.Show("Favor de verificar los datos ingresados","Error");
            }
            
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

        private void txtNombreMedCan_DoubleClick(object sender, EventArgs e)
        {
            List<MedicoCanalizador> listamed = new List<MedicoCanalizador>();

            BusinessLogicLayer.PacienteBLL.busquedaNombre(txtNombreMedCan.Text);

            listamed.Add(BusinessLogicLayer.MedicoCanalizadorBLL.busquedaNombre(txtNombreMedCan.Text)[0]);

            txtIdMedCan.Text = listamed[0].Id.ToString();
            txtNombreMedCan.Text = listamed[0].Nombre;
            txtApellidoMedCan.Text = listamed[0].Apellidos;
            txtCedMedCan.Text=listamed[0].Cedula_profesional;
            txtIdMedCan.Enabled = false;
        }

        private void txtNombreMedes_DoubleClick(object sender, EventArgs e)
        {
            List<MedicoRF02> listamedes = new List<MedicoRF02>();

            BusinessLogicLayer.MedicoBLL.busquedaNombre(txtNombreMedes.Text);

            listamedes.Add(BusinessLogicLayer.MedicoBLL.busquedaNombre(txtNombreMedes.Text)[0]);

            txtMedEst.Text = listamedes[0].Id.ToString();
            txtNombreMedes.Text = listamedes[0].Nombre;
            txtApellidosMedes.Text = listamedes[0].Apellidos;
            cboArea.SelectedItem = listamedes[0].Area;
            txtEspecialidadMedes.Text= listamedes[0].Esp_O_Cargo;
            txtCedulaMedes.Text = listamedes[0].Cedula_Profesional;
        }
    }
}
