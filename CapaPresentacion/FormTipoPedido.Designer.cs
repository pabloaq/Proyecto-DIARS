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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombreTipoPedido = new System.Windows.Forms.TextBox();
            this.txtIDTipoPedido = new System.Windows.Forms.TextBox();
            this.dgvTipoPedido = new System.Windows.Forms.DataGridView();
            this.btnEliminarTipoPedido = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.btnModificarTipoPedido = new System.Windows.Forms.Button();
            this.btnAgregarTipoPedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "0<|0";
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgvTipoPedido);
            this.panel2.Controls.Add(this.btnEliminarTipoPedido);
            this.panel2.Controls.Add(this.btnModificarTipoPedido);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 339);
            this.panel2.TabIndex = 4;
            // 
            // txtNombreTipoPedido
            // 
            this.txtNombreTipoPedido.Location = new System.Drawing.Point(36, 142);
            this.txtNombreTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreTipoPedido.Name = "txtNombreTipoPedido";
            this.txtNombreTipoPedido.Size = new System.Drawing.Size(239, 22);
            this.txtNombreTipoPedido.TabIndex = 12;
            this.txtNombreTipoPedido.TextChanged += new System.EventHandler(this.txtNombreTipoPedido_TextChanged);
            // 
            // txtIDTipoPedido
            // 
            this.txtIDTipoPedido.Location = new System.Drawing.Point(36, 59);
            this.txtIDTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDTipoPedido.Name = "txtIDTipoPedido";
            this.txtIDTipoPedido.Size = new System.Drawing.Size(239, 22);
            this.txtIDTipoPedido.TabIndex = 10;
            this.txtIDTipoPedido.TextChanged += new System.EventHandler(this.txtIDTipoPedido_TextChanged);
            // 
            // dgvTipoPedido
            // 
            this.dgvTipoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoPedido,
            this.nombreTipoPedido});
            this.dgvTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTipoPedido.Location = new System.Drawing.Point(353, 36);
            this.dgvTipoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTipoPedido.Name = "dgvTipoPedido";
            this.dgvTipoPedido.RowHeadersWidth = 51;
            this.dgvTipoPedido.RowTemplate.Height = 24;
            this.dgvTipoPedido.Size = new System.Drawing.Size(566, 234);
            this.dgvTipoPedido.TabIndex = 6;
            this.dgvTipoPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPedido_CellContentClick);
            this.dgvTipoPedido.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoPedido_CellMouseDoubleClick);
            // 
            // btnEliminarTipoPedido
            // 
            this.btnEliminarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnEliminarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoPedido.Location = new System.Drawing.Point(791, 276);
            this.btnEliminarTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTipoPedido.Name = "btnEliminarTipoPedido";
            this.btnEliminarTipoPedido.Size = new System.Drawing.Size(128, 46);
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
            this.lblNombre.Location = new System.Drawing.Point(34, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(176, 26);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Tipo de Pedido";
            this.lblNombre.Click += new System.EventHandler(this.lblTipoPedido_Click);
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoPedido.Location = new System.Drawing.Point(34, 30);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(205, 26);
            this.lblTipoPedido.TabIndex = 9;
            this.lblTipoPedido.Text = "ID Tipo de Pedido";
            this.lblTipoPedido.Click += new System.EventHandler(this.lblTipoPedido_Click);
            // 
            // btnModificarTipoPedido
            // 
            this.btnModificarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnModificarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnModificarTipoPedido.Location = new System.Drawing.Point(353, 276);
            this.btnModificarTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarTipoPedido.Name = "btnModificarTipoPedido";
            this.btnModificarTipoPedido.Size = new System.Drawing.Size(128, 46);
            this.btnModificarTipoPedido.TabIndex = 7;
            this.btnModificarTipoPedido.Text = "Modificar";
            this.btnModificarTipoPedido.UseVisualStyleBackColor = false;
            this.btnModificarTipoPedido.Click += new System.EventHandler(this.btnModificarTipoPedido_Click);
            // 
            // btnAgregarTipoPedido
            // 
            this.btnAgregarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnAgregarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTipoPedido.Location = new System.Drawing.Point(102, 239);
            this.btnAgregarTipoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarTipoPedido.Name = "btnAgregarTipoPedido";
            this.btnAgregarTipoPedido.Size = new System.Drawing.Size(128, 46);
            this.btnAgregarTipoPedido.TabIndex = 5;
            this.btnAgregarTipoPedido.Text = "Agregar";
            this.btnAgregarTipoPedido.UseVisualStyleBackColor = false;
            this.btnAgregarTipoPedido.Click += new System.EventHandler(this.btnAgregarTipoPedido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 355);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(791, 365);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombreTipoPedido);
            this.groupBox1.Controls.Add(this.lblTipoPedido);
            this.groupBox1.Controls.Add(this.txtIDTipoPedido);
            this.groupBox1.Controls.Add(this.btnAgregarTipoPedido);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 299);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // idTipoPedido
            // 
            this.idTipoPedido.DataPropertyName = "IdTipoPedido";
            this.idTipoPedido.HeaderText = "ID";
            this.idTipoPedido.MinimumWidth = 6;
            this.idTipoPedido.Name = "idTipoPedido";
            this.idTipoPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idTipoPedido.Width = 125;
            // 
            // nombreTipoPedido
            // 
            this.nombreTipoPedido.DataPropertyName = "NombreTipoPedido";
            this.nombreTipoPedido.HeaderText = "Tipo de Pedido";
            this.nombreTipoPedido.MinimumWidth = 6;
            this.nombreTipoPedido.Name = "nombreTipoPedido";
            this.nombreTipoPedido.Width = 400;
            // 
            // FormTipoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTipoPedido";
            this.Text = "Tipo del Pedido";
            this.Load += new System.EventHandler(this.FormTipoPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoPedido;
    }
}