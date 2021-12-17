using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                select new ProductoViewModel
                {
                    categoria = producto.categoria.categoria,
                    id = producto.id,
                    marca = producto.marca,
                    nombre = producto.nombre,
                    precio = producto.precio
                }).ToList();
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
                dbContext.SaveChanges();
            }

            Console.Write("test");
        }

        public void LimpiarCompra()
        {
            OrdenCompra.Clear();
        }
    }
}