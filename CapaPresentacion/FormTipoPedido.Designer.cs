﻿namespace CapaPresentacion
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(59)))), ((int)(((byte)(11)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 415);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.txtNombreTipoPedido);
            this.panel2.Controls.Add(this.txtIDTipoPedido);
            this.panel2.Controls.Add(this.dgvTipoPedido);
            this.panel2.Controls.Add(this.btnEliminarTipoPedido);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblTipoPedido);
            this.panel2.Controls.Add(this.btnModificarTipoPedido);
            this.panel2.Controls.Add(this.btnAgregarTipoPedido);
            this.panel2.Location = new System.Drawing.Point(21, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 329);
            this.panel2.TabIndex = 4;
            // 
            // txtNombreTipoPedido
            // 
            this.txtNombreTipoPedido.Location = new System.Drawing.Point(30, 140);
            this.txtNombreTipoPedido.Name = "txtNombreTipoPedido";
            this.txtNombreTipoPedido.Size = new System.Drawing.Size(239, 22);
            this.txtNombreTipoPedido.TabIndex = 12;
            this.txtNombreTipoPedido.TextChanged += new System.EventHandler(this.txtNombreTipoPedido_TextChanged);
            // 
            // txtIDTipoPedido
            // 
            this.txtIDTipoPedido.Location = new System.Drawing.Point(30, 57);
            this.txtIDTipoPedido.Name = "txtIDTipoPedido";
            this.txtIDTipoPedido.Size = new System.Drawing.Size(239, 22);
            this.txtIDTipoPedido.TabIndex = 10;
            this.txtIDTipoPedido.TextChanged += new System.EventHandler(this.txtIDTipoPedido_TextChanged);
            // 
            // dgvTipoPedido
            // 
            this.dgvTipoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPedido.Location = new System.Drawing.Point(295, 19);
            this.dgvTipoPedido.Name = "dgvTipoPedido";
            this.dgvTipoPedido.RowHeadersWidth = 51;
            this.dgvTipoPedido.RowTemplate.Height = 24;
            this.dgvTipoPedido.Size = new System.Drawing.Size(621, 217);
            this.dgvTipoPedido.TabIndex = 6;
            this.dgvTipoPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPedido_CellContentClick);
            // 
            // btnEliminarTipoPedido
            // 
            this.btnEliminarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnEliminarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTipoPedido.Location = new System.Drawing.Point(801, 264);
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
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(26, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(203, 21);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre Tipo del Pedido";
            this.lblNombre.Click += new System.EventHandler(this.lblTipoPedido_Click);
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoPedido.Location = new System.Drawing.Point(26, 28);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(157, 21);
            this.lblTipoPedido.TabIndex = 9;
            this.lblTipoPedido.Text = "ID Tipo del Pedido";
            this.lblTipoPedido.Click += new System.EventHandler(this.lblTipoPedido_Click);
            // 
            // btnModificarTipoPedido
            // 
            this.btnModificarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnModificarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnModificarTipoPedido.Location = new System.Drawing.Point(295, 264);
            this.btnModificarTipoPedido.Name = "btnModificarTipoPedido";
            this.btnModificarTipoPedido.Size = new System.Drawing.Size(128, 46);
            this.btnModificarTipoPedido.TabIndex = 7;
            this.btnModificarTipoPedido.Text = "Modificar";
            this.btnModificarTipoPedido.UseVisualStyleBackColor = false;
            this.btnModificarTipoPedido.Click += new System.EventHandler(this.btnModificarTipoPedido_Click);
            // 
            // btnAgregarTipoPedido
            // 
            this.btnAgregarTipoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnAgregarTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTipoPedido.Location = new System.Drawing.Point(66, 264);
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
            this.pictureBox1.Location = new System.Drawing.Point(21, 345);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(825, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormTipoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 412);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTipoPedido";
            this.Text = "Tipo del Pedido";
            this.Load += new System.EventHandler(this.FormTipoPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}