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
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            lblCargar.Text = progressBar1.Value.ToString() + " %";
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            if (Program.UsuarioLogueado != null)
            {
                lblUsuario.Text = Program.UsuarioLogueado.Nombre;
            }
            this.Opacity = 0.0;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
