using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Supermercado
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var FrmLogin = new FrmLogin();
            FrmLogin.ShowDialog();

            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: " 
                    + Program.UsuarioLogueado.Nombre;
            }

            //if (Program.UsuarioLogueado.TipoUsuario == "Usuarios Cajas")
            //{
            //    productosToolStripMenuItem.Visible = false;
            //    cleintesToolStripMenuItem.Visible = true;
            //    rentasToolStripMenuItem.Visible = false;
            //    facturaToolStripMenuItem.Visible = false;
            //    usuariosToolStripMenuItem.Visible = false;
            //    reporteDeVentasToolStripMenuItem.Visible = true;
            //    reporteFacturasToolStripMenuItem.Visible = true;
            //    reporteProductosToolStripMenuItem.Visible = false;
            //    //reportedeclientes

            //}
            //else
            //{
            //    Application.Exit();
            //}

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmProductos = new FrmProductos();
            FrmProductos.MdiParent = this;
            FrmProductos.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void cleintesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmClientes = new FrmClientes();
            FrmClientes.MdiParent = this;
            FrmClientes.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var menu = new FrrmMenu();
            //menu.Show();

        }

        private void reporteProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show(); 
        }

        private void reporteFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usua = new FrmUsuarios();
            usua.MdiParent = this;
            usua.Show();
        }
    }
}
