using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRA1.Recepcion.caja_de_cobro
{
    public partial class frmCobros : Form
    {
        public static int IdPac;
        public frmCobros()
        {
            InitializeComponent();
        }

        private void frmCobros_Load(object sender, EventArgs e)
        {
            dgvDeudas.DataSource = BusinessLogicLayer.ServicioBLL.visualizarnopagados(false);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            frmCobroDelPaciente cob = new frmCobroDelPaciente();
            IdPac = Convert.ToInt32(txtIDServPagar.Text);
            cob.ShowDialog();
        }
    }
}
