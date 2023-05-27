namespace CapaPresentacion
{
    partial class FormTipoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombreTipoPedido = new System.Windows.Forms.TextBox();
            this.txtIDTipoPedido = new System.Windows.Forms.TextBox();
            this.dgvTipoPedido = new System.Windows.Forms.DataGridView();
            this.idTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarTipoPedido = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.btnModificarTipoPedido = new System.Windows.Forms.Button();
            this.btnAgregarTipoPedido = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 419);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(710, 349);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 56);
            this.panel3.TabIndex = 16;
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
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(403, 338);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.txtNombreTipoPedido);
            this.panel2.Controls.Add(this.txtIDTipoPedido);
            this.panel2.Controls.Add(this.dgvTipoPedido);
            this.panel2.Controls.Add(this.btnEliminarTipoPedido);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblTipoPedido);
            this.panel2.Controls.Add(this.btnModificarTipoPedido);
            this.panel2.Controls.Add(this.btnAgregarTipoPedido);
            this.panel2.Location = new System.Drawing.Point(16, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 322);
            this.panel2.TabIndex = 4;
            // 
            // txtNombreTipoPedido
            // 
            this.txtNombreTipoPedido.Location = new System.Drawing.Point(22, 114);
            this.txtNombreTipoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreTipoPedido.Name = "txtNombreTipoPedido";
            this.txtNombreTipoPedido.Size = new System.Drawing.Size(180, 20);
            this.txtNombreTipoPedido.TabIndex = 12;
            this.txtNombreTipoPedido.TextChanged += new System.EventHandler(this.txtNombreTipoPedido_TextChanged);
            // 
            // txtIDTipoPedido
            // 
            this.txtIDTipoPedido.Location = new System.Drawing.Point(22, 46);
            this.txtIDTipoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDTipoPedido.Name = "txtIDTipoPedido";
            this.txtIDTipoPedido.Size = new System.Drawing.Size(180, 20);
            this.txtIDTipoPedido.TabIndex = 10;
            this.txtIDTipoPedido.TextChanged += new System.EventHandler(this.txtIDTipoPedido_TextChanged);
            // 
            // dgvTipoPedido
            // 
            this.dgvTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTipoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoPedido,
            this.nombreTipoPedido});
            this.dgvTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTipoPedido.Location = new System.Drawing.Point(295, 19);
            this.dgvTipoPedido.Name = "dgvTipoPedido";
            this.dgvTipoPedido.ReadOnly = true;
            this.dgvTipoPedido.RowHeadersWidth = 51;
            this.dgvTipoPedido.RowTemplate.Height = 24;
            this.dgvTipoPedido.Size = new System.Drawing.Size(558, 217);
            this.dgvTipoPedido.TabIndex = 6;
            this.dgvTipoPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPedido_CellContentClick);
            this.dgvTipoPedido.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoPedido_CellMouseDoubleClick);
            // 
            // idTipoPedido
            // 
            this.idTipoPedido.DataPropertyName = "IdTipoPedido";
            this.idTipoPedido.HeaderText = "ID";
            this.idTipoPedido.MinimumWidth = 6;
            this.idTipoPedido.Name = "idTipoPedido";
            this.idTipoPedido.ReadOnly = true;
            this.idTipoPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreTipoPedido
            // 
            this.nombreTipoPedido.DataPropertyName = "NombreTipoPedido";
            this.nombreTipoPedido.HeaderText = "Nombre del Tipo de Pedido";
            this.nombreTipoPedido.MinimumWidth = 6;
            this.nombreTipoPedido.Name = "nombreTipoPedido";
            this.nombreTipoPedido.ReadOnly = true;
            // 
            // btnEliminarTipoPedido
            // 
            this.btnEliminarTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnEliminarTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTipoPedido.FlatAppearance.BorderSize = 0;
            this.btnEliminarTipoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoPedido.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarTipoPedido.Location = new System.Drawing.Point(757, 250);
            this.btnEliminarTipoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTipoPedido.Name = "btnEliminarTipoPedido";
            this.btnEliminarTipoPedido.Size = new System.Drawing.Size(96, 37);
            this.btnEliminarTipoPedido.TabIndex = 8;
            this.btnEliminarTipoPedido.Text = "Eliminar";
            this.btnEliminarTipoPedido.UseVisualStyleBackColor = false;
            this.btnEliminarTipoPedido.Click += new System.EventHandler(this.btnEliminarTipoPedido_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(20, 90);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(180, 18);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre Tipo del Pedido";
            this.lblNombre.Click += new System.EventHandler(this.lblTipoPedido_Click);
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoPedido.Location = new System.Drawing.Point(20, 23);
            this.lblTipoPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(139, 18);
            this.lblTipoPedido.TabIndex = 9;
            this.lblTipoPedido.Text = "ID Tipo del Pedido";
            this.lblTipoPedido.Click += new System.EventHandler(this.lblTipoPedido_Click);
            // 
            // btnModificarTipoPedido
            // 
            this.btnModificarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnModificarTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarTipoPedido.FlatAppearance.BorderSize = 0;
            this.btnModificarTipoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTipoPedido.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificarTipoPedido.Location = new System.Drawing.Point(181, 199);
            this.btnModificarTipoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarTipoPedido.Name = "btnModificarTipoPedido";
            this.btnModificarTipoPedido.Size = new System.Drawing.Size(96, 37);
            this.btnModificarTipoPedido.TabIndex = 7;
            this.btnModificarTipoPedido.Text = "Modificar";
            this.btnModificarTipoPedido.UseVisualStyleBackColor = false;
            this.btnModificarTipoPedido.Click += new System.EventHandler(this.btnModificarTipoPedido_Click);
            // 
            // btnAgregarTipoPedido
            // 
            this.btnAgregarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnAgregarTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTipoPedido.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoPedido.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarTipoPedido.Location = new System.Drawing.Point(23, 199);
            this.btnAgregarTipoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTipoPedido.Name = "btnAgregarTipoPedido";
            this.btnAgregarTipoPedido.Size = new System.Drawing.Size(96, 37);
            this.btnAgregarTipoPedido.TabIndex = 5;
            this.btnAgregarTipoPedido.Text = "Agregar";
            this.btnAgregarTipoPedido.UseVisualStyleBackColor = false;
            this.btnAgregarTipoPedido.Click += new System.EventHandler(this.btnAgregarTipoPedido_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Location = new System.Drawing.Point(38, 355);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 41);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormTipoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 410);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTipoPedido";
            this.Text = "Tipo del Pedido";
            this.Load += new System.EventHandler(this.FormTipoPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregarTipoPedido;
        private System.Windows.Forms.DataGridView dgvTipoPedido;
        private System.Windows.Forms.Button btnModificarTipoPedido;
        private System.Windows.Forms.Button btnEliminarTipoPedido;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.TextBox txtNombreTipoPedido;
        private System.Windows.Forms.TextBox txtIDTipoPedido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoPedido;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}