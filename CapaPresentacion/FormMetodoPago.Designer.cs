using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FormMetodoPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMetodoPago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategoriaMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtIdMetodoPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarMetodoPago = new System.Windows.Forms.Button();
            this.btnEliminarMetodoPago = new System.Windows.Forms.Button();
            this.btnAgregarMetodoPago = new System.Windows.Forms.Button();
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMetodoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.cbCategoriaMetodoPago);
            this.panel1.Controls.Add(this.txtIdMetodoPago);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnModificarMetodoPago);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnEliminarMetodoPago);
            this.panel1.Controls.Add(this.btnAgregarMetodoPago);
            this.panel1.Controls.Add(this.dgvMetodoPago);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreMetodoPago);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 240);
            this.panel1.TabIndex = 1;
            // 
            // cbCategoriaMetodoPago
            // 
            this.cbCategoriaMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaMetodoPago.FormattingEnabled = true;
            this.cbCategoriaMetodoPago.Location = new System.Drawing.Point(22, 115);
            this.cbCategoriaMetodoPago.Name = "cbCategoriaMetodoPago";
            this.cbCategoriaMetodoPago.Size = new System.Drawing.Size(226, 21);
            this.cbCategoriaMetodoPago.TabIndex = 14;
            // 
            // txtIdMetodoPago
            // 
            this.txtIdMetodoPago.Enabled = false;
            this.txtIdMetodoPago.Location = new System.Drawing.Point(22, 59);
            this.txtIdMetodoPago.Name = "txtIdMetodoPago";
            this.txtIdMetodoPago.Size = new System.Drawing.Size(231, 20);
            this.txtIdMetodoPago.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Metodo de Pago ID";
            // 
            // btnModificarMetodoPago
            // 
            this.btnModificarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnModificarMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnModificarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMetodoPago.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificarMetodoPago.Location = new System.Drawing.Point(268, 87);
            this.btnModificarMetodoPago.Name = "btnModificarMetodoPago";
            this.btnModificarMetodoPago.Size = new System.Drawing.Size(94, 33);
            this.btnModificarMetodoPago.TabIndex = 10;
            this.btnModificarMetodoPago.Text = "Modificar";
            this.btnModificarMetodoPago.UseVisualStyleBackColor = false;
            this.btnModificarMetodoPago.Click += new System.EventHandler(this.btnModificarMetodoPago_Click);
            // 
            // btnEliminarMetodoPago
            // 
            this.btnEliminarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnEliminarMetodoPago.Cursor = System.Windows.Forms.Cursors.No;
            this.btnEliminarMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnEliminarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMetodoPago.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarMetodoPago.Location = new System.Drawing.Point(268, 139);
            this.btnEliminarMetodoPago.Name = "btnEliminarMetodoPago";
            this.btnEliminarMetodoPago.Size = new System.Drawing.Size(94, 33);
            this.btnEliminarMetodoPago.TabIndex = 9;
            this.btnEliminarMetodoPago.Text = "Eliminar";
            this.btnEliminarMetodoPago.UseVisualStyleBackColor = false;
            this.btnEliminarMetodoPago.MouseEnter += new System.EventHandler(this.btn_EliminarMetodoPago_MouseEnter);
            this.btnEliminarMetodoPago.MouseLeave += new System.EventHandler(this.btn_EliminarMetodoPago_MouseLeave);
            // 
            // btnAgregarMetodoPago
            // 
            this.btnAgregarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnAgregarMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnAgregarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMetodoPago.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarMetodoPago.Location = new System.Drawing.Point(268, 35);
            this.btnAgregarMetodoPago.Name = "btnAgregarMetodoPago";
            this.btnAgregarMetodoPago.Size = new System.Drawing.Size(94, 33);
            this.btnAgregarMetodoPago.TabIndex = 8;
            this.btnAgregarMetodoPago.Text = "Agregar";
            this.btnAgregarMetodoPago.UseVisualStyleBackColor = false;
            this.btnAgregarMetodoPago.Click += new System.EventHandler(this.btnAgregarMetodoPago_Click);
            // 
            // dgvMetodoPago
            // 
            this.dgvMetodoPago.AllowUserToAddRows = false;
            this.dgvMetodoPago.AllowUserToDeleteRows = false;
            this.dgvMetodoPago.AllowUserToResizeColumns = false;
            this.dgvMetodoPago.AllowUserToResizeRows = false;
            this.dgvMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMetodoPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetodoPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMetodoPago.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMetodoPago.Location = new System.Drawing.Point(368, 46);
            this.dgvMetodoPago.Name = "dgvMetodoPago";
            this.dgvMetodoPago.ReadOnly = true;
            this.dgvMetodoPago.Size = new System.Drawing.Size(344, 174);
            this.dgvMetodoPago.TabIndex = 6;
            this.dgvMetodoPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodoPago_CellContentClick);
            this.dgvMetodoPago.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodoPago_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria Metodo Pago :";
            // 
            // txtNombreMetodoPago
            // 
            this.txtNombreMetodoPago.Location = new System.Drawing.Point(22, 175);
            this.txtNombreMetodoPago.Name = "txtNombreMetodoPago";
            this.txtNombreMetodoPago.Size = new System.Drawing.Size(231, 20);
            this.txtNombreMetodoPago.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(19, 250);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 37);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(534, 240);
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
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(268, 187);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 33);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.MouseEnter += new System.EventHandler(this.btn_EliminarMetodoPago_MouseEnter);
            this.btnLimpiar.MouseLeave += new System.EventHandler(this.btn_EliminarMetodoPago_MouseLeave);
            // 
            // FormMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(721, 299);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMetodoPago";
            this.Text = "MantenedorMetodoPago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdMetodoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarMetodoPago;
        private System.Windows.Forms.Button btnEliminarMetodoPago;
        private System.Windows.Forms.Button btnAgregarMetodoPago;
        private System.Windows.Forms.DataGridView dgvMetodoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCategoriaMetodoPago;
        private Button btnSalir;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Button btnLimpiar;
    }
}