using GestionInventarios.Data;
using GestionInventarios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Inventarios.Forms
{
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
        }
        private void InicializarDataGridView()
        {
            dataGridViewProductos.Columns.Clear();
            dataGridViewProductos.Columns.Add("Id", "Id");
            dataGridViewProductos.Columns.Add("Nombre", "Nombre");
            dataGridViewProductos.Columns.Add("Categoria", "Categoría");
            dataGridViewProductos.Columns.Add("Stock", "Stock");
            dataGridViewProductos.Columns.Add("Disponible", "Disponible (Sí/No)");
        }

        private void CargarProductos()
        {
            dataGridViewProductos.Rows.Clear();

            foreach (var producto in AppData.Productos)
            {
                var categoria = AppData.Categorias.FirstOrDefault(c => c.Id == producto.CategoriaId);
                string nombreCategoria = categoria != null ? categoria.Nombre : "Sin categoría";

                dataGridViewProductos.Rows.Add(
                    producto.Id,
                    producto.Nombre,
                    nombreCategoria,
                    producto.Stock,
                    producto.Stock > 0 ? "Sí" : "No" // Ejemplo: se puede mostrar si tiene stock
                );
            }
        }
        private void InventarioForm_Load(object sender, EventArgs e)
        {
            AppData.InicializarDatosPrueba();

            cmbCategorias.DataSource = AppData.Categorias.ToList();
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Id";
            cmbCategorias.SelectedIndex = -1;

            InicializarDataGridView();
            CargarProductos();



        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Ingrese un nombre de producto.");
                return;
            }

            if (cmbCategorias.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero.");
                return;
            }

            if (nudCantidad.Value < 0)
            {
                MessageBox.Show("La cantidad inicial no puede ser negativa.");
                return;
            }

            int nuevoId = AppData.Productos.Count > 0 ? AppData.Productos.Max(p => p.Id) + 1 : 1;

            var producto = new Producto
            {
                Id = nuevoId,
                Nombre = txtNombreProducto.Text,
                CategoriaId = (int)cmbCategorias.SelectedValue,
                Stock = (int)nudCantidad.Value
            };

            AppData.Productos.Add(producto);

            // Registrar movimiento de inventario si la cantidad inicial > 0
            if (producto.Stock > 0)
            {
                AppData.Movimientos.Add(new MovimientoInventario
                {
                    ProductoId = producto.Id,
                    Fecha = DateTime.Now,
                    Cantidad = producto.Stock,
                    Tipo = "Entrada"
                });
            }

            CargarProductos();
            txtNombreProducto.Clear();
            cmbCategorias.SelectedIndex = -1;
            nudPrecio.Value = 0;
            nudCantidad.Value = 0;
        }
        

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para editar.");
                return;
            }

            int idSeleccionado = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells[0].Value);
            var producto = AppData.Productos.FirstOrDefault(p => p.Id == idSeleccionado);

            if (producto != null)
            {
                // Mostrar el nombre actual en un InputBox
                string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el nuevo nombre:", "Editar Producto", producto.Nombre);

                if (!string.IsNullOrWhiteSpace(nuevoNombre))
                    producto.Nombre = nuevoNombre;

                // Seleccionar automáticamente la categoría del producto en el ComboBox
                cmbCategorias.SelectedValue = producto.CategoriaId;

                // Validar que haya selección antes de actualizar
                if (cmbCategorias.SelectedIndex >= 0)
                {
                    producto.CategoriaId = (int)cmbCategorias.SelectedValue;
                }

                CargarProductos();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            int idSeleccionado = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells[0].Value);
            var producto = AppData.Productos.FirstOrDefault(p => p.Id == idSeleccionado);

            if (producto != null)
            {
                AppData.Productos.Remove(producto);

                // Opcional: eliminar movimientos asociados
                AppData.Movimientos.RemoveAll(m => m.ProductoId == producto.Id);

                CargarProductos();
            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
