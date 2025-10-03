using GestionInventarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventarios.Data
{
    public static class AppData
    {
        public static List<Categoria> Categorias { get; set; } = new List<Categoria>();
        public static List<Producto> Productos { get; set; } = new List<Producto>();
        public static List<MovimientoInventario> Movimientos { get; set; } = new List<MovimientoInventario>();

        // Inicializar datos de prueba
        public static void InicializarDatosPrueba()
        {
            if (Categorias.Count == 0)
            {
                // Categorías
                Categorias.Add(new Categoria { Id = 1, Nombre = "Bebidas" });
                Categorias.Add(new Categoria { Id = 2, Nombre = "Abarrotes" });
                Categorias.Add(new Categoria { Id = 3, Nombre = "Electrónicos" });
                Categorias.Add(new Categoria { Id = 4, Nombre = "Limpieza" });
                Categorias.Add(new Categoria { Id = 5, Nombre = "Ropa" });

                // Productos de ejemplo
                Productos.Add(new Producto { Id = 1, Nombre = "Coca-Cola", CategoriaId = 1, Stock = 50 });
                Productos.Add(new Producto { Id = 2, Nombre = "Arroz", CategoriaId = 2, Stock = 100 });
                Productos.Add(new Producto { Id = 3, Nombre = "Celular", CategoriaId = 3, Stock = 10 });
                Productos.Add(new Producto { Id = 4, Nombre = "Detergente", CategoriaId = 4, Stock = 30 });
                Productos.Add(new Producto { Id = 5, Nombre = "Camiseta", CategoriaId = 5, Stock = 20 });

                // Movimientos iniciales
                Movimientos.Add(new MovimientoInventario
                {
                    ProductoId = 1,
                    Fecha = DateTime.Now,
                    Cantidad = 50,
                    Tipo = "Entrada",
                    StockResultante = 50
                });
                Movimientos.Add(new MovimientoInventario
                {
                    ProductoId = 2,
                    Fecha = DateTime.Now,
                    Cantidad = 100,
                    Tipo = "Entrada",
                    StockResultante = 100
                });
                Movimientos.Add(new MovimientoInventario
                {
                    ProductoId = 3,
                    Fecha = DateTime.Now,
                    Cantidad = 10,
                    Tipo = "Entrada",
                    StockResultante = 10
                });
                Movimientos.Add(new MovimientoInventario
                {
                    ProductoId = 4,
                    Fecha = DateTime.Now,
                    Cantidad = 30,
                    Tipo = "Entrada",
                    StockResultante = 30
                });
                Movimientos.Add(new MovimientoInventario
                {
                    ProductoId = 5,
                    Fecha = DateTime.Now,
                    Cantidad = 20,
                    Tipo = "Entrada",
                    StockResultante = 20
                });
            }
        }

        // Método para registrar movimientos
        public static void RegistrarMovimiento(int productoId, string tipo, int cantidad)
        {
            var producto = Productos.FirstOrDefault(p => p.Id == productoId);
            if (producto == null) return;

            if (tipo == "Entrada")
                producto.Stock += cantidad;
            else if (tipo == "Salida" && producto.Stock >= cantidad)
                producto.Stock -= cantidad;

            Movimientos.Add(new MovimientoInventario
            {
                ProductoId = productoId,
                Fecha = DateTime.Now,
                Cantidad = cantidad,
                Tipo = tipo,
                StockResultante = producto.Stock
            });
        }
    }
}
