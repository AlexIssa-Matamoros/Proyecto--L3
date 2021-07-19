using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto context)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "Admin";
            usuarioAdmin.Contrasena = "1234";
            context.Usuarios.Add(usuarioAdmin);

            var usuarioAdmin2 = new Usuario();
            usuarioAdmin2.Nombre = "Admin";
            usuarioAdmin2.Contrasena = "5678";
            context.Usuarios.Add(usuarioAdmin2);

            var cat1 = new Categoria();
            cat1.Descripcion = "Carnes y Embutidos";
            context.Categorias.Add(cat1);

            var cat2 = new Categoria();
            cat2.Descripcion = "Frutas y Verduras";
            context.Categorias.Add(cat2);

            var cat3 = new Categoria();
            cat3.Descripcion = "Pan y Dulces";
            context.Categorias.Add(cat3);

            var cat4 = new Categoria();
            cat4.Descripcion = "Lacteos";
            context.Categorias.Add(cat4);

            var cat5 = new Categoria();
            cat5.Descripcion = "Granos basicos";
            context.Categorias.Add(cat5);

            var T1 = new Tipo();
            T1.Descripcion = "Bienes de Consumo";
            context.Tipos.Add(T1);

            var T2 = new Tipo();
            T2.Descripcion = "Bienes no duraderos";
            context.Tipos.Add(T2);

            var T3 = new Tipo();
            T3.Descripcion = "Bienes de uso comun";
            context.Tipos.Add(T3);

            //var Cliente1 = new Cliente();
            //Cliente1.Nombre = "Alex";
            //context.Clientes.Add(Cliente1);

            base.Seed(context);
        }
    }
}