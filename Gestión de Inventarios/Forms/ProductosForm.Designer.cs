namespace Gestión_de_Inventarios.Forms
{
    partial class ProductosForm
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
            cmbproductos = new ComboBox();
            nudcantidad = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnRegistrarentrada = new Button();
            btnRegistrarsalida = new Button();
            ((System.ComponentModel.ISupportInitialize)nudcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbproductos
            // 
            cmbproductos.FormattingEnabled = true;
            cmbproductos.Location = new Point(26, 139);
            cmbproductos.Name = "cmbproductos";
            cmbproductos.Size = new Size(245, 23);
            cmbproductos.TabIndex = 0;
            cmbproductos.SelectedIndexChanged += cmbproductos_SelectedIndexChanged;
            // 
            // nudcantidad
            // 
            nudcantidad.Location = new Point(26, 208);
            nudcantidad.Name = "nudcantidad";
            nudcantidad.Size = new Size(249, 23);
            nudcantidad.TabIndex = 1;
            nudcantidad.ValueChanged += nudcantidad_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 308);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRegistrarentrada
            // 
            btnRegistrarentrada.Location = new Point(17, 270);
            btnRegistrarentrada.Name = "btnRegistrarentrada";
            btnRegistrarentrada.Size = new Size(128, 38);
            btnRegistrarentrada.TabIndex = 3;
            btnRegistrarentrada.Text = "button1";
            btnRegistrarentrada.UseVisualStyleBackColor = true;
            btnRegistrarentrada.Click += btnRegistrarentrada_Click;
            // 
            // btnRegistrarsalida
            // 
            btnRegistrarsalida.Location = new Point(184, 274);
            btnRegistrarsalida.Name = "btnRegistrarsalida";
            btnRegistrarsalida.Size = new Size(139, 38);
            btnRegistrarsalida.TabIndex = 4;
            btnRegistrarsalida.Text = "button2";
            btnRegistrarsalida.UseVisualStyleBackColor = true;
            btnRegistrarsalida.Click += btnRegistrarsalida_Click;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarsalida);
            Controls.Add(btnRegistrarentrada);
            Controls.Add(dataGridView1);
            Controls.Add(nudcantidad);
            Controls.Add(cmbproductos);
            Name = "ProductosForm";
            Text = "ProductosForm";
            Load += ProductosForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbproductos;
        private NumericUpDown nudcantidad;
        private DataGridView dataGridView1;
        private Button btnRegistrarentrada;
        private Button btnRegistrarsalida;
    }
}