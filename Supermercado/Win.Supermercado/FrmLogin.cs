using BL.Supermercado;
using System;
using System.Windows.Forms;

namespace Win.Supermercado
{
    public partial class FrmLogin : Form
    {
        SeguridadBL _seguridad;

        public FrmLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Contraseña;

            Usuario = txtUsuario.Text;
            Contraseña = txtContra.Text;

            var resultado = _seguridad.Autorizar(Usuario, Contraseña);

            if (resultado == true)
            {
                this.Close();
            }

            else

            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

