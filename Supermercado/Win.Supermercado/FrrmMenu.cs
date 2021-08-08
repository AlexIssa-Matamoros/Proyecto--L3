using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Supermercado
{
    public partial class FrrmMenu : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FrrmMenu()
        {
            InitializeComponent();
            PersonalizarDiseño();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            Botones.Controls.Add(leftBorderBtn);
            this.DoubleBuffered = true;
            ///FORM
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            /// Datos
            this.ttmensaje.SetToolTip(this.lbluser, "Usuario");
            this.ttmensaje.SetToolTip(this.lblTipo, "Tipo de Usuario");
            this.ttmensaje.SetToolTip(this.button6, "Minimizar");
            this.ttmensaje.SetToolTip(this.button5, "Maximizar");
            this.ttmensaje.SetToolTip(this.buttonSalir, "Salir");
        }

        //
        private struct RGBColores
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color colorRojo = Color.FromArgb(255, 0, 0);
        }

        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.Image = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //////////
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                /////
                iconodeFormHijo.Image = currentBtn.Image;

            }
        }

        private void DesactivarBoton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 67);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //currentBtn.Image = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color1);
            AbrirFormularioHijo(new FrmProductos());
            PanelSubmenuReportes.Visible = false;
            PanelSubMenuSeguridad.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color2);
            AbrirFormularioHijo(new FrmClientes());
            PanelSubmenuReportes.Visible = false;
            PanelSubMenuSeguridad.Visible = false;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color3);
            AbrirFormularioHijo(new FormFactura());
            PanelSubmenuReportes.Visible = false;
            PanelSubMenuSeguridad.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            TituloFrmHijo.Text = "Reportes";
            ActivarBoton(sender, RGBColores.color4);
            MostrarSubMenus(PanelSubmenuReportes);
            PanelSubMenuSeguridad.Visible = false;
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            TituloFrmHijo.Text = "Seguridad";
            ActivarBoton(sender, RGBColores.color4);
            MostrarSubMenus(PanelSubMenuSeguridad);
            PanelSubmenuReportes.Visible = false;
        }

        private void Reiniciar()
        {
            DesactivarBoton();

            TituloFrmHijo.Text = "Inicio";
        }

        ////////////// Sub Menu /////////

        private void PersonalizarDiseño()
        {
            PanelSubmenuReportes.Visible = false;
            PanelSubMenuSeguridad.Visible = false;
            //..
        }

        private void OcultarSubmenu()
        {
            if (PanelSubmenuReportes.Visible == true)
                PanelSubmenuReportes.Visible = false;
            if (PanelSubMenuSeguridad.Visible == true)
                PanelSubMenuSeguridad.Visible = false;

        }

        private void MostrarSubMenus(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubmenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// codigos de mostrar cada formulario
            AbrirFormularioHijo(new FormReporteProductos());
            OcultarSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /// codigos de mostrar cada formulario
            AbrirFormularioHijo(new FormReporteFacturas());
            OcultarSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /// codigos de mostrar cada formulario
            AbrirFormularioHijo(new FrmUsuarios());
            OcultarSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /// codigos de mostrar cada formulario
            if(MessageBox.Show("¿Esta seguro de cerrar sesion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                login();
            }
           
            OcultarSubmenu();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        //Abrir Formulario dentro del menu
        private void AbrirFormularioHijo(Form FrmHijo)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(FrmHijo);
            PanelEscritorio.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
            TituloFrmHijo.Text = FrmHijo.Text;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void botonInicio_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        public void Reset()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            this.iconodeFormHijo.Image = global::Win.Supermercado.Properties.Resources.venta2;
            TituloFrmHijo.Text = "Inicio";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaxi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Salir?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void login()
        {
            var FrmLogin = new FrmLogin();
            FrmLogin.ShowDialog();

            
        }

        private void panelVentanaBTN_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DatosUsuario()
        {
            if (Program.UsuarioLogueado != null)
            {
                lbluser.Text = Program.UsuarioLogueado.Nombre;
                lblTipo.Text = Program.UsuarioLogueado.TipoUsuario;
            }

            if (Program.UsuarioLogueado.TipoUsuario == "Usuarios Cajas")
            {
                btnProducto.Visible = false; //producto
                btnClientes.Visible = false; //cliente

                btnFacturas.Visible = true; //fac
                btnReportes.Visible = true;
                btnSeguridad.Visible = true; //usu
                button1.Visible = false; //re-pro
                button2.Visible = true; //-re-fac
                button3.Visible = false; //ad us
                button7.Visible = false; // report clientes
            }

            if (Program.UsuarioLogueado.TipoUsuario == "Usuarios Ventas")
            {
                btnProducto.Visible = false; //producto
                btnClientes.Visible = true; //cliente
                button7.Visible = true;
                btnFacturas.Visible = false; //fac
                btnReportes.Visible = true;
                btnSeguridad.Visible = true; //usu
                btnReportes.Visible = true;
                button1.Visible = false; //re-pro
                button2.Visible = false; //-re-fac
                button3.Visible = false; //ad usuario
                button7.Visible = true;
            }

            if (Program.UsuarioLogueado.TipoUsuario == "Administradores")
            {
                btnProducto.Visible = true; //producto
                btnClientes.Visible = true; //cliente
                //agregar reporte de clientes
                btnFacturas.Visible = true; //fac
                btnSeguridad.Visible = true; //usu
                btnReportes.Visible = true;
            }
        }

        private void FrrmMenu_Load(object sender, EventArgs e)
        {
            var Login = new FrmLogin();
            //Login.ShowDialog();
            DatosUsuario();
        }

        private void cerrarCesion(object sender, FormClosedEventArgs e)
        {
            //limpiear txt
        }

        private void Botones_Paint(object sender, PaintEventArgs e)
        {
           
        }

        // Mover Formulario desde el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Param);

        private void panelVentanaBTN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /// codigos de mostrar cada formulario
            AbrirFormularioHijo(new FormReporteClientes());
            OcultarSubmenu();
        }
    }
}
