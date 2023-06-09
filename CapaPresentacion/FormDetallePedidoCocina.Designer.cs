namespace CapaPresentacion
{
    partial class FormDetallePedidoCocina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallePedidoCocina));
            this.panelCambioEstado = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPedido = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvDetallePedidos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCambioEstado.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCambioEstado
            // 
            this.panelCambioEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCambioEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(92)))));
            this.panelCambioEstado.Controls.Add(this.btnAtras);
            this.panelCambioEstado.Controls.Add(this.panel3);
            this.panelCambioEstado.Controls.Add(this.pictureBox1);
            this.panelCambioEstado.Controls.Add(this.panel2);
            this.panelCambioEstado.Location = new System.Drawing.Point(0, 0);
            this.panelCambioEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCambioEstado.Name = "panelCambioEstado";
            this.panelCambioEstado.Size = new System.Drawing.Size(544, 345);
            this.panelCambioEstado.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.Location = new System.Drawing.Point(9, 300);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(101, 34);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(340, 278);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.panel3.Size = new System.Drawing.Size(194, 56);
            this.panel3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(108, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "(044) 678102";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Av. España 1970, Trujillo, Peru";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.lblPedido);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.dgvDetallePedidos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 253);
            this.panel2.TabIndex = 0;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPedido.Location = new System.Drawing.Point(382, 14);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(132, 31);
            this.lblPedido.TabIndex = 13;
            this.lblPedido.Text = "lbl Pedido";
            this.lblPedido.Click += new System.EventHandler(this.lblPedido_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // dgvDetallePedidos
            // 
            this.dgvDetallePedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallePedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.IdPedido,
            this.Cantidad});
            this.dgvDetallePedidos.Location = new System.Drawing.Point(21, 58);
            this.dgvDetallePedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetallePedidos.Name = "dgvDetallePedidos";
            this.dgvDetallePedidos.RowHeadersWidth = 51;
            this.dgvDetallePedidos.RowTemplate.Height = 24;
            this.dgvDetallePedidos.Size = new System.Drawing.Size(489, 175);
            this.dgvDetallePedidos.TabIndex = 11;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "idProducto";
            this.IdProducto.HeaderText = "Producto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            // 
            // IdPedido
            // 
            this.IdPedido.DataPropertyName = "idPedido";
            this.IdPedido.HeaderText = "Cliente";
            this.IdPedido.MinimumWidth = 6;
            this.IdPedido.Name = "IdPedido";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Detalle del Pedidos Pagado:";
            // 
            // FormDetallePedidoCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 344);
            this.Controls.Add(this.panelCambioEstado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDetallePedidoCocina";
            this.Text = "FormDetallePedidoCocina";
            this.Load += new System.EventHandler(this.FormDetallePedidoCocina_Load);
            this.panelCambioEstado.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCambioEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetallePedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label lblPedido;
    }
}