using BL.Supermercado;
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
    public partial class FrmUsuarios : Form
    {
        SeguridadBL _usuariosBL;
        public FrmUsuarios()
        {
            InitializeComponent();
            _usuariosBL = new SeguridadBL();
            listaUsuariosBindingSource.DataSource = _usuariosBL.ObtenerUsuarios();
            this.ttmensaje.SetToolTip(this.BtnAgregar, "Agregar");
            this.ttmensaje.SetToolTip(this.BtnBorrar, "Borrar");
            this.ttmensaje.SetToolTip(this.BtnGuardar, "Guardar");
            this.ttmensaje.SetToolTip(this.BtnCancelar, "Cancelar");
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
            BtnCancelar.Visible = !valor;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _usuariosBL.AgregarUsuario();
            listaUsuariosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void listaUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaUsuariosBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            var resultado = _usuariosBL.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _usuariosBL.EliminarUsuario(id);

            if (resultado == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Usuario");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _usuariosBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void contrasenaTextBox_Enter(object sender, EventArgs e)
        {
            contrasenaTextBox.UseSystemPasswordChar = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _usuariosBL.AgregarUsuario();
            listaUsuariosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
            
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            listaUsuariosBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            var resultado = _usuariosBL.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _usuariosBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void listaUsuariosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) 
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                else
                    e.Value = "Null";
            }
                    
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var buscar = textBox1.Text;

            if (string.IsNullOrEmpty(buscar) == true)
            {
                listaUsuariosBindingSource.DataSource = _usuariosBL.ObtenerUsuarios();
            }
            else
            {
                listaUsuariosBindingSource.DataSource = _usuariosBL.ObtenerUsuarios(buscar);
            }

            listaUsuariosBindingSource.ResetBindings(false);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Buscar...")
            {
                textBox1.Text = "";
                //textBox1.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Buscar...";
                //textBox1.ForeColor = System.Drawing.Color.LightGray;
            }
        }
    }
}
