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
    }
}
