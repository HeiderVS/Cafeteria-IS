using System;
using System.Collections.Generic;
using System.Linq;
using Modelos;
using Modelos.Inventario;

namespace Controladores.Administrador
{
    public class InventarioControlador
    {
        public IEnumerable<CategoriaViewModel> GetCategorias()
        {
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            IEnumerable<CategoriaViewModel> categoriaViewModels = (from categoria in dbContext.Categorias
                select new CategoriaViewModel
                {
                    id = categoria.id,
                    categoria = categoria.categoria
                }).ToList();
            return categoriaViewModels;
        }

        public IEnumerable<ProductoViewModel> GetProductos()
        {
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            return (from producto in dbContext.Productos
                select new ProductoViewModel
                {
                    categoria = producto.categoria.categoria,
                    id = producto.id,
                    marca = producto.marca,
                    nombre = producto.nombre,
                    precio = producto.precio
                }).ToList();
        }

        public void RegistraProducto(String nombre, String marca, int categoria, Decimal precio, int cantidad)
        {
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            dbContext.Productos.Add(new Producto
            {
                cantidad = cantidad,
                categoriaId = categoria,
                marca = marca,
                nombre = nombre,
                precio = precio
            });
            dbContext.SaveChanges();
        }
    }
}