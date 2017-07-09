using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRA1.Recepcion
{
    public partial class frmServicioDetalle : Form
    {
        public frmServicioDetalle()
        {
            InitializeComponent();
        }

        private void frmServicioDetalle_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Juan";
            textBox2.Text = "Limas";
            comboBox1.SelectedItem = "Chequeo";
        }
    }
}
