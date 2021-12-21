using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                where producto.activo == true
                select new ProductoViewModel
                {
                    categoria = producto.categoria.categoria,
                    id = producto.id,
                    marca = producto.marca,
                    nombre = producto.nombre,
                    precio = producto.precio
                }).ToList();
        }

        public Producto GetProductoById(ProductoViewModel productoVm)
        {
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            return dbContext.Productos.Find(productoVm.id);
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
                precio = precio,
                activo = true
            });
            dbContext.SaveChanges();
        }

        public void EliminarProducto(ProductoViewModel producto)
        {
            using (CafeteriaDBContext dbContext = new CafeteriaDBContext())
            {
                Producto editProducto = GetProductoById(producto);
                editProducto.activo = false;
                dbContext.Entry(editProducto).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void ActualizarProducto(ProductoViewModel producto)
        {
            using (CafeteriaDBContext dbContext = new CafeteriaDBContext())
            {
                Producto editProducto = GetProductoById(producto);
                editProducto.nombre = producto.nombre;
                editProducto.marca = producto.marca;
                editProducto.precio = producto.precio;
                dbContext.Entry(editProducto).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
    }
}