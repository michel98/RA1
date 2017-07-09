using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsRA1.Recepcion.Gestion_de_usuarios;

namespace WindowsRA1.Recepcion
{
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmModificarAgregarUsuario agmod = new frmModificarAgregarUsuario();
            agmod.ShowDialog();

        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogicLayer.UsuarioBLL.consultar();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogicLayer.UsuarioBLL.consultar();
        }
    }
}
