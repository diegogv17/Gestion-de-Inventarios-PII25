namespace Gestión_de_Inventarios.Forms
{
    partial class InventarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProductos = new DataGridView();
            txtNombreProducto = new TextBox();
            cmbCategorias = new ComboBox();
            nudPrecio = new NumericUpDown();
            nudCantidad = new NumericUpDown();
            btnAgregarProducto = new Button();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(46, 284);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(750, 272);
            dataGridViewProductos.TabIndex = 0;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(51, 69);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(750, 23);
            txtNombreProducto.TabIndex = 1;
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(51, 108);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(387, 23);
            cmbCategorias.TabIndex = 2;
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(469, 107);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(332, 23);
            nudPrecio.TabIndex = 3;
            nudPrecio.ValueChanged += nudPrecio_ValueChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(51, 151);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(750, 23);
            nudCantidad.TabIndex = 4;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(70, 206);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(144, 46);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar ";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(238, 207);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(143, 44);
            btnEditarProducto.TabIndex = 6;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(425, 207);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(168, 45);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 600);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(nudCantidad);
            Controls.Add(nudPrecio);
            Controls.Add(cmbCategorias);
            Controls.Add(txtNombreProducto);
            Controls.Add(dataGridViewProductos);
            Name = "InventarioForm";
            Text = "InventarioForm";
            Load += InventarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private TextBox txtNombreProducto;
        private ComboBox cmbCategorias;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudCantidad;
        private Button btnAgregarProducto;
        private Button btnEditarProducto;
        private Button btnEliminarProducto;
    }
}