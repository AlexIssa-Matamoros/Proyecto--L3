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
    }
}
