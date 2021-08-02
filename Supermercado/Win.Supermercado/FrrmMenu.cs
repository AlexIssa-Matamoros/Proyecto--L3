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
    public partial class FrrmMenu : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;

        public FrrmMenu()
        {
            InitializeComponent();
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
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color2);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color3);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color4);
        }
        private void Reiniciar()
        {
            DesactivarBoton();
            iconodeFormHijo.Image = currentBtn.Image;
        }
    }
}
