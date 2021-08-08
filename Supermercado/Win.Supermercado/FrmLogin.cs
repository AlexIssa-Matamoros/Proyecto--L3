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

          
            var usuarioDB = _seguridad.Autorizar(usuario, contrasena);

            if (usuarioDB != null)
            {
                this.Hide();
                Program.UsuarioLogueado = usuarioDB;
                FrmWelcome Bienvenido = new FrmWelcome();
                Bienvenido.ShowDialog();
                FrrmMenu Menu = new FrrmMenu();
                Menu.Show();
            }
            else
            {
                MsjError("Ingrese un usuario y contraseña valido");
                txtContra.Clear();
                txtUsuario.Focus();
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
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "CONTRASEÑA")
            {
                txtContra.Text = "";
                txtContra.ForeColor = System.Drawing.Color.LightGray;
                txtContra.UseSystemPasswordChar = true;
            }
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) 
                && !string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtContra.Focus();
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
               && !string.IsNullOrEmpty(txtContra.Text))
            {
                button1.PerformClick();
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "CONTRASEÑA";
                txtContra.ForeColor = System.Drawing.Color.DimGray;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void MsjError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
            iconError.Visible = true;
        }
    }
}

