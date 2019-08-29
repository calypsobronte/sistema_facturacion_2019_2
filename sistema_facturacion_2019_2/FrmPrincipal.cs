using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace sistema_facturacion_2019_2
{
    //Aca le vamos a decir que va a heredar de MaterialSkin Forms y no de form
    public partial class FrmPrincipal : MaterialForm //Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Creamos un nuevo metodo en el cual nos ayudara a abrir diferentes formularios por medio de los contenedores que creamos por medio de pnlCoontenedor
        private void AbrirForm(Form frmHijo)
        {
            if (this.pblContenedor.Controls.Count > 0) this.pblContenedor.Controls.RemoveAt(0);
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            this.pblContenedor.Controls.Add(frmHijo);
            frmHijo.Show();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        //Salir de la aplicación
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Mostrar clientes desde el formulario FrmClientes
        // Para esto importamos el Formulario que hemos creado
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmclientes = new FrmClientes();
            AbrirForm(frmclientes);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmproductos = new FrmProductos();
            AbrirForm(frmproductos);
        }

        private void BtnCatergoria_Click(object sender, EventArgs e)
        {
            FrmCategoriaProductos frmcategoria = new FrmCategoriaProductos();
            AbrirForm(frmcategoria);
        }
    }
}
