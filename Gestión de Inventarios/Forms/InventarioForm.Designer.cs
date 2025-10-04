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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(108, 324);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(621, 319);
            dataGridViewProductos.TabIndex = 0;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(48, 103);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(750, 23);
            txtNombreProducto.TabIndex = 1;
            txtNombreProducto.Tag = "";
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(48, 156);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(387, 23);
            cmbCategorias.TabIndex = 2;
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(466, 155);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(332, 23);
            nudPrecio.TabIndex = 3;
            nudPrecio.ValueChanged += nudPrecio_ValueChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(48, 209);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(750, 23);
            nudCantidad.TabIndex = 4;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(124, 259);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(144, 46);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar ";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(292, 260);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(143, 44);
            btnEditarProducto.TabIndex = 6;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(479, 260);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(168, 45);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 85);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre de producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 138);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Categoría:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 138);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 10;
            label3.Text = "Precio unitario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 191);
            label4.Name = "label4";
            label4.Size = new Size(162, 15);
            label4.TabIndex = 11;
            label4.Text = "Cantidad inicial en existencia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label5.Location = new Point(166, 9);
            label5.Name = "label5";
            label5.Size = new Size(511, 65);
            label5.TabIndex = 12;
            label5.Text = "Gestión de productos";
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 690);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}