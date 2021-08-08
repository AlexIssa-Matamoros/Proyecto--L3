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
    public partial class FrmClientes : Form
    {
        ClientesBL _clientesBL;

        public FrmClientes()
        {
            InitializeComponent();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            /////////// mensajes
            this.ttmensaje.SetToolTip(this.BtnAgregar, "Agregar");
            this.ttmensaje.SetToolTip(this.BtnBorrar, "Borrar");
            this.ttmensaje.SetToolTip(this.BtnGuardar, "Guardar");
            this.ttmensaje.SetToolTip(this.BtnCancelar, "Cancelar");
            this.ttmensaje.SetToolTip(this.pictureBox1, "Buscar");
            
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

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientesBL.AgregarCliente();
            listaClientesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
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
            var resultado = _clientesBL.EliminarCliente(id);

            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Cliente");
            }
        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;

            var resultado = _clientesBL.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _clientesBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var buscar = textBox1.Text;

            if (string.IsNullOrEmpty(buscar) == true)
            {
                listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
            }
            else
            {
                listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes(buscar);
            }

            listaClientesBindingSource.ResetBindings(false);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _clientesBL.AgregarCliente();
            listaClientesBindingSource.MoveLast();

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

            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;

            var resultado = _clientesBL.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _clientesBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var buscar = textBox1.Text;

            if (string.IsNullOrEmpty(buscar) == true)
            {
                listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
            }
            else
            {
                listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes(buscar);
            }

            listaClientesBindingSource.ResetBindings(false);
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
