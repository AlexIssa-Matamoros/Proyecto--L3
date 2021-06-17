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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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

            if (Usuario == "admi" && Contraseña == "1234")
            {
                this.Close();
            }
            else{
                if (Usuario == "hola" && Contraseña == "5678")
                {
                    this.Close();
                }
            else

            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
         }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
