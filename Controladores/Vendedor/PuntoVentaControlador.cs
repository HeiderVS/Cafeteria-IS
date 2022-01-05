using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using Controladores.Administrador;
using Modelos;
using Modelos.Inventario;
using Modelos.PuntoVenta;
using Modelos.Usuarios;

namespace Controladores.Vendedor
{
    public class PuntoVentaControlador
    {
        public ObservableCollection<ProductoCompraViewModel> OrdenCompra =
            new ObservableCollection<ProductoCompraViewModel>();

        public decimal TotalPagar;
        public UsuarioInfoViewModel UsuarioInfoViewModel { get; set; }

        public IEnumerable<ProductoViewModel> GetProductos()
        {
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            return (from producto in dbContext.Productos
                where producto.cantidad > 0
                select new ProductoViewModel
                {
                    categoria = producto.categoria.categoria,
                    id = producto.id,
                    marca = producto.marca,
                    nombre = producto.nombre,
                    precio = producto.precio, 
                    cantidad = producto.cantidad
                }).ToList();
        }

        public int GetCantidadProductoById(ProductoCompraViewModel productoOrden)
        {
            using CafeteriaDBContext dbContext = new CafeteriaDBContext();
            if (productoOrden != null)
            {
                return dbContext.Productos.Find(productoOrden.id).cantidad;
            } 
                
            return -1;
        }

        public void AgregaOrdenCompra(object producto)
        {
            OrdenCompra.Add(new ProductoCompraViewModel
            {
                id = ((ProductoViewModel) producto).id,
                nombre = ((ProductoViewModel) producto).nombre,
                precio = ((ProductoViewModel) producto).precio
            });
        }

        public void EliminaOrdenCompra(object producto)
        {
            OrdenCompra.Remove(OrdenCompra.ToList()
                .SingleOrDefault(orden => orden.id.Equals(((ProductoViewModel) producto).id)));
        }

        public void FinalizarCompra()
        {
            using (CafeteriaDBContext dbContext = new CafeteriaDBContext())
            {
                dbContext.Ventas.Add(new Ventas()
                {
                    total = TotalPagar,
                    vendedorId = UsuarioInfoViewModel.id,
                    Productos = (from ordenCompra in OrdenCompra
                        select new ProductosVendidos
                        {
                            productoId = ordenCompra.id
                        }).ToList(),
                    fecha = DateTime.Now
                });

                // actualiza cantidad de producto disponible.
                foreach (ProductoCompraViewModel productoCompra in OrdenCompra)
                {
                    Producto editProducto = dbContext.Productos.Find(productoCompra.id);
                    editProducto.cantidad = editProducto.cantidad - productoCompra.cantidad;
                    dbContext.Entry(editProducto).State = EntityState.Modified;
                }
                dbContext.SaveChanges();
            }
        }

        public void LimpiarCompra()
        {
            OrdenCompra.Clear();
        }
    }
}