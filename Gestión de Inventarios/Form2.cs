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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ProductosForm = new ProductosForm();
            ProductosForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form CategoriasForm = new CategoriasForm();
            CategoriasForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form InventarioForm = new InventarioForm();
            InventarioForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
