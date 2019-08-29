using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_facturacion_2019_2
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        // Se le dara la instruccion de this.Close() ya que este lo estamo mostrando desde otro espacio.
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
