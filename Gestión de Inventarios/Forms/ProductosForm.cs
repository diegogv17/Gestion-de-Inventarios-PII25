using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInventarios.Models;
using GestionInventarios.Data;
using Gestión_de_Inventarios.Forms;

namespace Gestión_de_Inventarios.Forms
{
    public partial class ProductosForm : Form

    {
        private void ActualizarHistorial(int productoId)
        {
            var historial = AppData.Movimientos
                                  .Where(m => m.ProductoId == productoId)
                                  .OrderByDescending(m => m.Fecha)
                                  .Select(m => new
                                  {
                                      Fecha = m.Fecha.ToString("dd/MM/yyyy HH:mm"),
                                      m.Tipo,
                                      m.Cantidad,
                                      m.StockResultante
                                  })
                                  .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = historial;
        }

        public ProductosForm()
        {
            InitializeComponent();
        }



        private void cmbproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbproductos.SelectedItem is Producto producto)
            {
                ActualizarHistorial(producto.Id);
            }
        }

       
        private void nudcantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarentrada_Click(object sender, EventArgs e)
        {
            if (cmbproductos.SelectedItem is Producto producto)
            {
                int cantidad = (int)nudcantidad.Value;
                AppData.RegistrarMovimiento(producto.Id, "Entrada", cantidad);
                ActualizarHistorial(producto.Id);
            }
        }

        private void btnRegistrarsalida_Click(object sender, EventArgs e)
        {
            if (cmbproductos.SelectedItem is Producto producto)
            {
                int cantidad = (int)nudcantidad.Value;
                AppData.RegistrarMovimiento(producto.Id, "Salida", cantidad);
                ActualizarHistorial(producto.Id);
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            AppData.InicializarDatosPrueba();

            cmbproductos.DataSource = AppData.Productos;
            cmbproductos.DisplayMember = "Nombre";
            cmbproductos.ValueMember = "Id";
        }
    }
}
