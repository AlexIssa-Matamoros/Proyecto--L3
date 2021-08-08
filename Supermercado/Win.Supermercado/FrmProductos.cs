using BL.Supermercado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Supermercado
{
    public partial class FrmProductos : Form
    {
        ProductosBL _productos;
        CategoriasBL _categorias;
        TiposBL _tipos;
        

        public FrmProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _tipos = new TiposBL();
            listaTiposBindingSource.DataSource = _tipos.ObtenerTipos();
            /////////// mensajes
            this.ttmensaje.SetToolTip(this.BtnAgregar, "Agregar");
            this.ttmensaje.SetToolTip(this.BtnBorrar, "Borrar");
            this.ttmensaje.SetToolTip(this.BtnGuardar, "Guardar");
            this.ttmensaje.SetToolTip(this.BtnCancelar, "Cancelar");
            this.ttmensaje.SetToolTip(this.pictureBox1, "Buscar");
            this.ttmensaje.SetToolTip(this.button1, "Agregar Foto");
            this.ttmensaje.SetToolTip(this.button2, "Eliminar Foto");

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();
            var producto = (Producto)listaProductosBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                producto.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                producto.Foto = null;
            }


            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DesabilitarHabilitarBotones(true);
                MessageBox.Show("Producto guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            } 
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

            DesabilitarHabilitarBotones(false);
        }

        private void DesabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
            BtnCancelar.Visible = !valor;
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
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("OCURRIO UN ERROR AL QUERER ELIMINAR EL PRODUCTO");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _productos.CancelarCambios();
            DesabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductosBindingSource.Current;

            if (producto != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un producto antes de asignarle una imagen");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var buscar = textBox1.Text;

            if (string.IsNullOrEmpty(buscar) == true)
            {
                listaProductosBindingSource.DataSource = _productos.ObtenerProductos();
            }
            else
            {
                listaProductosBindingSource.DataSource = _productos.ObtenerProductos(buscar);
            }

            listaProductosBindingSource.ResetBindings(false);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

            DesabilitarHabilitarBotones(false);
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
            listaProductosBindingSource.EndEdit();
            var producto = (Producto)listaProductosBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                producto.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                producto.Foto = null;
            }


            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DesabilitarHabilitarBotones(true);
                MessageBox.Show("Producto guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _productos.CancelarCambios();
            DesabilitarHabilitarBotones(true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var buscar = textBox1.Text;

            if (string.IsNullOrEmpty(buscar) == true)
            {
                listaProductosBindingSource.DataSource = _productos.ObtenerProductos();
            }
            else
            {
                listaProductosBindingSource.DataSource = _productos.ObtenerProductos(buscar);
            }

            listaProductosBindingSource.ResetBindings(false);
        }

        private void existenciaLabel_Click(object sender, EventArgs e)
        {

        }

        private void precioLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriaIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listaProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            
        }

        private void FrmProductos_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Buscar...";
                //textBox1.ForeColor = System.Drawing.Color.LightGray;
            }
        }
    }
}
