using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInventarios.Data;
using GestionInventarios.Models;


namespace Gestión_de_Inventarios.Forms
{
    public partial class CategoriasForm : Form
    {

        private void InicializarDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("CantidadProductos", "Productos Asociados");
        }

        private void CargarCategorias()
        {
            dataGridView1.Rows.Clear();

            foreach (var categoria in AppData.Categorias)
            {
                int cantidadProductos = AppData.Productos.Count(p => p.CategoriaId == categoria.Id);

                dataGridView1.Rows.Add(categoria.Id, categoria.Nombre, cantidadProductos);

            }

        }

        public CategoriasForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idSeleccionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var categoria = AppData.Categorias.FirstOrDefault(c => c.Id == idSeleccionado);

                if (categoria != null)
                {
                    string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox(
                        "Ingrese el nuevo nombre de la categoría:", "Editar Categoría", categoria.Nombre);

                    if (!string.IsNullOrWhiteSpace(nuevoNombre))
                    {
                        categoria.Nombre = nuevoNombre;
                        CargarCategorias();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para editar.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idSeleccionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var categoria = AppData.Categorias.FirstOrDefault(c => c.Id == idSeleccionado);

                if (categoria != null)
                {
                    int productosAsociados = AppData.Productos.Count(p => p.CategoriaId == categoria.Id);
                    if (productosAsociados > 0)
                    {
                        MessageBox.Show("No se puede eliminar la categoría porque tiene productos asociados.");
                        return;
                    }

                    AppData.Categorias.Remove(categoria);
                    CargarCategorias();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
            }
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {
            InicializarDataGridView();      // Primero inicializa columnas
            AppData.InicializarDatosPrueba(); // Luego inicializa datos de prueba
            CargarCategorias();             // Finalmente carga las filas

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string nombreNueva = Microsoft.VisualBasic.Interaction.InputBox(
        "Ingrese el nombre de la nueva categoría:", "Crear Categoría", "");

            if (!string.IsNullOrWhiteSpace(nombreNueva))
            {
                // Generar un nuevo Id (tomando el máximo actual + 1)
                int nuevoId = AppData.Categorias.Count > 0
                    ? AppData.Categorias.Max(c => c.Id) + 1
                    : 1;

                var nuevaCategoria = new Categoria
                {
                    Id = nuevoId,
                    Nombre = nombreNueva
                };

                AppData.Categorias.Add(nuevaCategoria);
                CargarCategorias();

                MessageBox.Show("Categoría creada con éxito.");
            }
            else
            {
                MessageBox.Show("El nombre no puede estar vacío.");
            }
        }
    }
}
