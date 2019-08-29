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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnvalidar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "calypsobronte" && txtcontrasena.Text == "1234")
            {
                MessageBox.Show($"Bienvenido {txtusuario.Text} al Sistema de Facturación");
                //Creamos el objeto delformulario FrmPrincipal
                FrmPrincipal frmppal = new FrmPrincipal();
                this.Hide(); // Ocultamos el formulario login
                frmppal.Show(); // Mostramos el formulario principal
            }
            else
            {
                MessageBox.Show("Error al iniciar. Por favor verifique de su Usuario/Contraseña");
                txtusuario.Text = "";
                txtcontrasena.Text = "";
                txtusuario.Focus();
            }
            
        }
    }
}
