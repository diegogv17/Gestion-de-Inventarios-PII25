using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestión_de_Inventarios.Forms;
using GestionInventarios.Data;
using GestionInventarios.Models;

namespace Gestión_de_Inventarios
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void ActualizarDashboard()
        {
            lblTotalProductos.Text = AppData.Productos.Count.ToString();
            lblTotalCategorias.Text = AppData.Categorias.Count.ToString();
            lblValorInventario.Text = AppData.Productos.Sum(p => p.Precio * p.Stock).ToString("C");

            var productoMayorStock = AppData.Productos.OrderByDescending(p => p.Stock).FirstOrDefault();
            lblProductoMayorStock.Text = productoMayorStock != null
                ? $"{productoMayorStock.Nombre} ({productoMayorStock.Stock})"
                : "N/A";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productosForm = new ProductosForm();
            productosForm.FormClosed += (s, e) => ActualizarDashboard();
            productosForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var categoriasForm = new CategoriasForm();
            categoriasForm.FormClosed += (s, e) => ActualizarDashboard();
            categoriasForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var inventarioForm = new InventarioForm();
            inventarioForm.FormClosed += (s, e) => ActualizarDashboard();
            inventarioForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ActualizarDashboard();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
