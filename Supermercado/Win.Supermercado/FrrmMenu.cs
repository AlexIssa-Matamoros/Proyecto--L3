﻿using System;
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
            ActivarBoton(sender, RGBColores.color4);
            MostrarSubMenus(PanelSubmenuReportes);
            PanelSubMenuSeguridad.Visible = false;
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color4);
            MostrarSubMenus(PanelSubMenuSeguridad);
            PanelSubmenuReportes.Visible = false;
        }

        private void Reiniciar()
        {
            DesactivarBoton();
            iconodeFormHijo.Image = currentBtn.Image;
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
           
            TituloFrmHijo.Text = "Inicio";
        }
    }
}
