namespace MantenedorProducto
{
    partial class FormProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EliminarProd = new System.Windows.Forms.Button();
            this.btn_Modificarprodu = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ID_Local = new System.Windows.Forms.ComboBox();
            this.cb_Cod_Categoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_fechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.txt_codProducto = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txt_stockProducto = new System.Windows.Forms.TextBox();
            this.txt_nomProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(105)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btn_EliminarProd);
            this.panel1.Controls.Add(this.btn_Modificarprodu);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 352);
            this.panel1.TabIndex = 0;
            // 
            // btn_EliminarProd
            // 
            this.btn_EliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_EliminarProd.FlatAppearance.BorderSize = 0;
            this.btn_EliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarProd.Location = new System.Drawing.Point(380, 297);
            this.btn_EliminarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EliminarProd.Name = "btn_EliminarProd";
            this.btn_EliminarProd.Size = new System.Drawing.Size(74, 28);
            this.btn_EliminarProd.TabIndex = 16;
            this.btn_EliminarProd.Text = "Eliminar";
            this.btn_EliminarProd.UseVisualStyleBackColor = false;
            this.btn_EliminarProd.Click += new System.EventHandler(this.btn_EliminarProd_Click);
            // 
            // btn_Modificarprodu
            // 
            this.btn_Modificarprodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_Modificarprodu.FlatAppearance.BorderSize = 0;
            this.btn_Modificarprodu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificarprodu.Location = new System.Drawing.Point(301, 297);
            this.btn_Modificarprodu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modificarprodu.Name = "btn_Modificarprodu";
            this.btn_Modificarprodu.Size = new System.Drawing.Size(74, 28);
            this.btn_Modificarprodu.TabIndex = 15;
            this.btn_Modificarprodu.Text = "Modificar";
            this.btn_Modificarprodu.UseVisualStyleBackColor = false;
            this.btn_Modificarprodu.Click += new System.EventHandler(this.btn_Modificarprodu_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Location = new System.Drawing.Point(458, 297);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(74, 28);
            this.btn_Limpiar.TabIndex = 14;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(222, 297);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(74, 28);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_listaProductos);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(218, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(742, 281);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Productos";
            // 
            // dgv_listaProductos
            // 
            this.dgv_listaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_listaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductos.Location = new System.Drawing.Point(4, 25);
            this.dgv_listaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_listaProductos.Name = "dgv_listaProductos";
            this.dgv_listaProductos.ReadOnly = true;
            this.dgv_listaProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgv_listaProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listaProductos.RowTemplate.Height = 24;
            this.dgv_listaProductos.Size = new System.Drawing.Size(727, 250);
            this.dgv_listaProductos.TabIndex = 0;
            this.dgv_listaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaProductos_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_PrecioUnitario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cb_ID_Local);
            this.panel2.Controls.Add(this.cb_Cod_Categoria);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dt_fechaCaducidad);
            this.panel2.Controls.Add(this.txt_codProducto);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.txt_stockProducto);
            this.panel2.Controls.Add(this.txt_nomProducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 332);
            this.panel2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(10, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio Unitario";
            // 
            // txt_PrecioUnitario
            // 
            this.txt_PrecioUnitario.Location = new System.Drawing.Point(10, 162);
            this.txt_PrecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PrecioUnitario.Name = "txt_PrecioUnitario";
            this.txt_PrecioUnitario.Size = new System.Drawing.Size(128, 20);
            this.txt_PrecioUnitario.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(11, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Codigo Del Local";
            // 
            // cb_ID_Local
            // 
            this.cb_ID_Local.FormattingEnabled = true;
            this.cb_ID_Local.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_ID_Local.Location = new System.Drawing.Point(10, 303);
            this.cb_ID_Local.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ID_Local.Name = "cb_ID_Local";
            this.cb_ID_Local.Size = new System.Drawing.Size(180, 21);
            this.cb_ID_Local.TabIndex = 10;
            // 
            // cb_Cod_Categoria
            // 
            this.cb_Cod_Categoria.FormattingEnabled = true;
            this.cb_Cod_Categoria.Location = new System.Drawing.Point(10, 262);
            this.cb_Cod_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Cod_Categoria.Name = "cb_Cod_Categoria";
            this.cb_Cod_Categoria.Size = new System.Drawing.Size(182, 21);
            this.cb_Cod_Categoria.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(10, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo Categoria Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de Caducidad";
            // 
            // dt_fechaCaducidad
            // 
            this.dt_fechaCaducidad.Location = new System.Drawing.Point(10, 219);
            this.dt_fechaCaducidad.Margin = new System.Windows.Forms.Padding(2);
            this.dt_fechaCaducidad.Name = "dt_fechaCaducidad";
            this.dt_fechaCaducidad.Size = new System.Drawing.Size(182, 20);
            this.dt_fechaCaducidad.TabIndex = 6;
            // 
            // txt_codProducto
            // 
            this.txt_codProducto.Enabled = false;
            this.txt_codProducto.Location = new System.Drawing.Point(10, 26);
            this.txt_codProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codProducto.Name = "txt_codProducto";
            this.txt_codProducto.Size = new System.Drawing.Size(132, 20);
            this.txt_codProducto.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nombre.Location = new System.Drawing.Point(10, 58);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(90, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre Producto";
            // 
            // txt_stockProducto
            // 
            this.txt_stockProducto.Location = new System.Drawing.Point(10, 124);
            this.txt_stockProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stockProducto.Name = "txt_stockProducto";
            this.txt_stockProducto.Size = new System.Drawing.Size(132, 20);
            this.txt_stockProducto.TabIndex = 5;
            // 
            // txt_nomProducto
            // 
            this.txt_nomProducto.Location = new System.Drawing.Point(10, 74);
            this.txt_nomProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nomProducto.Name = "txt_nomProducto";
            this.txt_nomProducto.Size = new System.Drawing.Size(132, 20);
            this.txt_nomProducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock Producto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(803, 366);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 56);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(89, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "(044)678102";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Av. España 1970. Trujillo. Peru";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(27, 376);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(980, 430);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProducto";
            this.Text = "MantenedorProducto";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_listaProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_fechaCaducidad;
        private System.Windows.Forms.TextBox txt_codProducto;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txt_stockProducto;
        private System.Windows.Forms.TextBox txt_nomProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ComboBox cb_Cod_Categoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PrecioUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_ID_Local;
        private System.Windows.Forms.Button btn_EliminarProd;
        private System.Windows.Forms.Button btn_Modificarprodu;
    }
}