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
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = txtUsuario.Text;
            contrasena = txtContra.Text;

            button1.Enabled = false;
            button1.Text = "VERIFICANDO...";
            Application.DoEvents();

            var resultado = _seguridad.Autorizar(usuario, contrasena);

            if (resultado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

            button1.Enabled = true;
            button1.Text = "ACEPTAR";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
        }
    }
}

