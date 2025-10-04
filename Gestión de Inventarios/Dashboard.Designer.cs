namespace Gestión_de_Inventarios
{
    partial class Dashboard
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            lblProductoMayorStock = new Label();
            panel5 = new Panel();
            label3 = new Label();
            lblTotalCategorias = new Label();
            panel4 = new Panel();
            label2 = new Label();
            lblValorInventario = new Label();
            panel3 = new Panel();
            label1 = new Label();
            lblTotalProductos = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 218);
            button1.Name = "button1";
            button1.Size = new Size(127, 44);
            button1.TabIndex = 0;
            button1.Text = "Movimientos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 136);
            button2.Name = "button2";
            button2.Size = new Size(127, 44);
            button2.TabIndex = 1;
            button2.Text = "Categoria";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 297);
            button3.Name = "button3";
            button3.Size = new Size(127, 44);
            button3.TabIndex = 2;
            button3.Text = "Inventario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 450);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Walmart_spark__2025__svg;
            pictureBox1.InitialImage = Properties.Resources.Walmart_spark__2025__svg;
            pictureBox1.Location = new Point(4, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(162, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(638, 450);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(label4);
            panel6.Controls.Add(lblProductoMayorStock);
            panel6.Location = new Point(345, 264);
            panel6.Name = "panel6";
            panel6.Size = new Size(227, 166);
            panel6.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(44, 15);
            label4.Name = "label4";
            label4.Size = new Size(139, 50);
            label4.TabIndex = 4;
            label4.Text = "Producto con \r\nmayor stock:";
            // 
            // lblProductoMayorStock
            // 
            lblProductoMayorStock.AutoSize = true;
            lblProductoMayorStock.Location = new Point(93, 120);
            lblProductoMayorStock.Name = "lblProductoMayorStock";
            lblProductoMayorStock.Size = new Size(38, 15);
            lblProductoMayorStock.TabIndex = 3;
            lblProductoMayorStock.Text = "label1";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblValorInventario);
            panel5.Location = new Point(60, 264);
            panel5.Name = "panel5";
            panel5.Size = new Size(229, 163);
            panel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(51, 15);
            label3.Name = "label3";
            label3.Size = new Size(137, 50);
            label3.TabIndex = 2;
            label3.Text = "Valor total del\r\n inventario:";
            // 
            // lblTotalCategorias
            // 
            lblTotalCategorias.AutoSize = true;
            lblTotalCategorias.Location = new Point(93, 104);
            lblTotalCategorias.Name = "lblTotalCategorias";
            lblTotalCategorias.Size = new Size(38, 15);
            lblTotalCategorias.TabIndex = 1;
            lblTotalCategorias.Text = "label1";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lblTotalCategorias);
            panel4.Location = new Point(345, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 162);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(8, 30);
            label2.Name = "label2";
            label2.Size = new Size(214, 25);
            label2.TabIndex = 3;
            label2.Text = "Categorías registradas:";
            // 
            // lblValorInventario
            // 
            lblValorInventario.AutoSize = true;
            lblValorInventario.Location = new Point(92, 120);
            lblValorInventario.Name = "lblValorInventario";
            lblValorInventario.Size = new Size(38, 15);
            lblValorInventario.TabIndex = 2;
            lblValorInventario.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblTotalProductos);
            panel3.Location = new Point(60, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 162);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 30);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 1;
            label1.Text = "Productos registrados:";
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Location = new Point(92, 104);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(38, 15);
            lblTotalProductos.TabIndex = 0;
            lblTotalProductos.Text = "label1";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblProductoMayorStock;
        private Label lblValorInventario;
        private Label lblTotalCategorias;
        private Label lblTotalProductos;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}