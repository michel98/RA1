using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntities;
using System.Windows.Forms;

namespace WindowsRA1.Recepcion.caja_de_cobro
{
    public partial class frmCobroDelPaciente : Form
    {
        List<EstudioRF01> estudios = new List<EstudioRF01>();
        public frmCobroDelPaciente()
        {
            InitializeComponent();
        }

        private void frmCobroDelPaciente_Load(object sender, EventArgs e)
        {
            EstudioRF01 est = new EstudioRF01();
            est.Id = 1;
            est.Nombre = "Chequeo";
            est.Descripcion = "Se checará la presión arterial";
            est.Categoría = "Tomografía";
            est.Costo = 150;
            estudios.Add(est);
           
            dataGridView1.DataSource = estudios;

            txtTotal.Text = estudios[0].Costo.ToString();
            txtNombrePacDeu.Text = "Juan";
            txtApellidoPacDeu.Text = "Limas";

            txtResiPacDeu.Text = "Calle Rio Nazas #128 Jardines del Canadá";
            

        }
    }
}
