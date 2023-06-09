namespace CapaPresentacion
{
    partial class FormEstadoPedido2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadoPedido2));
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetallePedidosEntregados = new System.Windows.Forms.Button();
            this.btnActualizarPedido = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.dgvPedidosPagados = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCambioEstado = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosPagados)).BeginInit();
            this.panelCambioEstado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtras.Location = new System.Drawing.Point(200, 360);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(106, 37);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.btnDetallePedidosEntregados);
            this.panel1.Controls.Add(this.btnActualizarPedido);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCambiarEstado);
            this.panel1.Controls.Add(this.dgvPedidosPagados);
            this.panel1.Location = new System.Drawing.Point(200, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 335);
            this.panel1.TabIndex = 12;
            // 
            // btnDetallePedidosEntregados
            // 
            this.btnDetallePedidosEntregados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetallePedidosEntregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnDetallePedidosEntregados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetallePedidosEntregados.FlatAppearance.BorderSize = 0;
            this.btnDetallePedidosEntregados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDetallePedidosEntregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetallePedidosEntregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetallePedidosEntregados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetallePedidosEntregados.Location = new System.Drawing.Point(484, 287);
            this.btnDetallePedidosEntregados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetallePedidosEntregados.Name = "btnDetallePedidosEntregados";
            this.btnDetallePedidosEntregados.Size = new System.Drawing.Size(115, 38);
            this.btnDetallePedidosEntregados.TabIndex = 12;
            this.btnDetallePedidosEntregados.Text = "Ver Detalle";
            this.btnDetallePedidosEntregados.UseVisualStyleBackColor = false;
            this.btnDetallePedidosEntregados.Click += new System.EventHandler(this.btnDetallePedidosEntregados_Click);
            // 
            // btnActualizarPedido
            // 
            this.btnActualizarPedido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnActualizarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarPedido.FlatAppearance.BorderSize = 0;
            this.btnActualizarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnActualizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizarPedido.Location = new System.Drawing.Point(234, 287);
            this.btnActualizarPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarPedido.Name = "btnActualizarPedido";
            this.btnActualizarPedido.Size = new System.Drawing.Size(101, 38);
            this.btnActualizarPedido.TabIndex = 11;
            this.btnActualizarPedido.Text = "Actualizar";
            this.btnActualizarPedido.UseVisualStyleBackColor = false;
            this.btnActualizarPedido.Click += new System.EventHandler(this.btnActualizarPedido_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista Pedidos Pagados";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.AllowDrop = true;
            this.btnCambiarEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCambiarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnCambiarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCambiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarEstado.Location = new System.Drawing.Point(13, 287);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(94, 38);
            this.btnCambiarEstado.TabIndex = 10;
            this.btnCambiarEstado.Text = " Entregar";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // dgvPedidosPagados
            // 
            this.dgvPedidosPagados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidosPagados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidosPagados.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPedidosPagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosPagados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.idTipoPedido,
            this.nombreCliente,
            this.direccion,
            this.fechaRegistro,
            this.estado});
            this.dgvPedidosPagados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPedidosPagados.Location = new System.Drawing.Point(4, 59);
            this.dgvPedidosPagados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPedidosPagados.Name = "dgvPedidosPagados";
            this.dgvPedidosPagados.RowHeadersWidth = 51;
            this.dgvPedidosPagados.RowTemplate.Height = 24;
            this.dgvPedidosPagados.Size = new System.Drawing.Size(595, 223);
            this.dgvPedidosPagados.TabIndex = 1;
            this.dgvPedidosPagados.SelectionChanged += new System.EventHandler(this.dgvPedidosPagados_SelectionChanged);
            // 
            // idPedido
            // 
            this.idPedido.DataPropertyName = "idPedido";
            this.idPedido.HeaderText = "Id Pedido";
            this.idPedido.MinimumWidth = 6;
            this.idPedido.Name = "idPedido";
            // 
            // idTipoPedido
            // 
            this.idTipoPedido.DataPropertyName = "idTipoPedido";
            this.idTipoPedido.HeaderText = "Id Tipo Pedido";
            this.idTipoPedido.MinimumWidth = 6;
            this.idTipoPedido.Name = "idTipoPedido";
            // 
            // nombreCliente
            // 
            this.nombreCliente.DataPropertyName = "nombreCliente";
            this.nombreCliente.HeaderText = "Cliente";
            this.nombreCliente.MinimumWidth = 6;
            this.nombreCliente.Name = "nombreCliente";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.DataPropertyName = "fechaRegistro";
            this.fechaRegistro.HeaderText = "Fecha de Registro";
            this.fechaRegistro.MinimumWidth = 6;
            this.fechaRegistro.Name = "fechaRegistro";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado del pedido";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            // 
            // panelCambioEstado
            // 
            this.panelCambioEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCambioEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(92)))));
            this.panelCambioEstado.Controls.Add(this.panel2);
            this.panelCambioEstado.Controls.Add(this.btnAtras);
            this.panelCambioEstado.Controls.Add(this.panel1);
            this.panelCambioEstado.Controls.Add(this.pictureBox1);
            this.panelCambioEstado.Location = new System.Drawing.Point(-163, 0);
            this.panelCambioEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCambioEstado.Name = "panelCambioEstado";
            this.panelCambioEstado.Size = new System.Drawing.Size(828, 413);
            this.panelCambioEstado.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(626, 356);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 47);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(82, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(044) 678102";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Av. España 1970, Trujillo, Peru";
            // 
            // FormEstadoPedido2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 413);
            this.Controls.Add(this.panelCambioEstado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEstadoPedido2";
            this.Text = "Cambiar Estado del Pedido";
            this.Load += new System.EventHandler(this.FormEstadoPedido2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosPagados)).EndInit();
            this.panelCambioEstado.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPedidosPagados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizarPedido;
        private System.Windows.Forms.Button btnDetallePedidosEntregados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Panel panelCambioEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}