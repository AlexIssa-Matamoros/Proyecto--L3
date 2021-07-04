using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Arroz";
            producto1.Precio = 150;
            producto1.Existencia = 1000;
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Azucar";
            producto2.Precio = 100;
            producto2.Existencia = 2000;
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Detergente";
            producto3.Precio = 180;
            producto3.Existencia = 80;
            producto3.Activo = true;

            ListaProductos.Add(producto3);

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Aceite";
            producto4.Precio = 200;
            producto4.Existencia = 60;
            producto4.Activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new Producto();
            producto5.Id = 1;
            producto5.Descripcion = "Fideos";
            producto5.Precio = 50;
            producto5.Existencia = 300;
            producto5.Activo = true;

            ListaProductos.Add(producto5);

        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (producto.Id == 0)
            {
                producto.Id = ListaProductos.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion)== true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }
            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia deber ser mayor que 0";
                resultado.Exitoso = false;
            }
            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El precio deber ser mayor que 0";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
