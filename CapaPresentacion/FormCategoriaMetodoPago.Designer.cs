using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FormCategoriaMetodoPago
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_AgregarCatMetodoPago = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txtNombreCatMetodoPago = new System.Windows.Forms.TextBox();
            this.btn_ModificarCatMetodoPago = new System.Windows.Forms.Button();
            this.btn_EliminarCatMetodoPago = new System.Windows.Forms.Button();
            this.gbListaCatMetodoPago = new System.Windows.Forms.GroupBox();
            this.dgvCatMetodoPago = new System.Windows.Forms.DataGridView();
            this.txtCodigoCatMetodoPago = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbListaCatMetodoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatMetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.ForeColor = System.Drawing.Color.White;
            this.lbl_1.Location = new System.Drawing.Point(81, 22);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(104, 13);
            this.lbl_1.TabIndex = 1;
            this.lbl_1.Text = "Código de categoría";
            // 
            // btn_AgregarCatMetodoPago
            // 
            this.btn_AgregarCatMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_AgregarCatMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCatMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarCatMetodoPago.ForeColor = System.Drawing.Color.Black;
            this.btn_AgregarCatMetodoPago.Location = new System.Drawing.Point(313, 29);
            this.btn_AgregarCatMetodoPago.Name = "btn_AgregarCatMetodoPago";
            this.btn_AgregarCatMetodoPago.Size = new System.Drawing.Size(86, 41);
            this.btn_AgregarCatMetodoPago.TabIndex = 2;
            this.btn_AgregarCatMetodoPago.Text = "Agregar";
            this.btn_AgregarCatMetodoPago.UseVisualStyleBackColor = false;
            this.btn_AgregarCatMetodoPago.Click += new System.EventHandler(this.btn_AgregarCatMetodoPago_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.ForeColor = System.Drawing.Color.White;
            this.lbl_2.Location = new System.Drawing.Point(81, 61);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(44, 13);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "Nombre";
            // 
            // txtNombreCatMetodoPago
            // 
            this.txtNombreCatMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.txtNombreCatMetodoPago.ForeColor = System.Drawing.Color.White;
            this.txtNombreCatMetodoPago.Location = new System.Drawing.Point(81, 84);
            this.txtNombreCatMetodoPago.Name = "txtNombreCatMetodoPago";
            this.txtNombreCatMetodoPago.Size = new System.Drawing.Size(209, 20);
            this.txtNombreCatMetodoPago.TabIndex = 7;
            // 
            // btn_ModificarCatMetodoPago
            // 
            this.btn_ModificarCatMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_ModificarCatMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarCatMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarCatMetodoPago.ForeColor = System.Drawing.Color.Black;
            this.btn_ModificarCatMetodoPago.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_ModificarCatMetodoPago.Location = new System.Drawing.Point(313, 76);
            this.btn_ModificarCatMetodoPago.Name = "btn_ModificarCatMetodoPago";
            this.btn_ModificarCatMetodoPago.Size = new System.Drawing.Size(86, 34);
            this.btn_ModificarCatMetodoPago.TabIndex = 18;
            this.btn_ModificarCatMetodoPago.Text = "Modificar";
            this.btn_ModificarCatMetodoPago.UseVisualStyleBackColor = false;
            this.btn_ModificarCatMetodoPago.Click += new System.EventHandler(this.btn_ModificarCatMetodoPago_Click);
            // 
            // btn_EliminarCatMetodoPago
            // 
            this.btn_EliminarCatMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_EliminarCatMetodoPago.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_EliminarCatMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarCatMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarCatMetodoPago.ForeColor = System.Drawing.Color.Black;
            this.btn_EliminarCatMetodoPago.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_EliminarCatMetodoPago.Location = new System.Drawing.Point(313, 128);
            this.btn_EliminarCatMetodoPago.Name = "btn_EliminarCatMetodoPago";
            this.btn_EliminarCatMetodoPago.Size = new System.Drawing.Size(86, 34);
            this.btn_EliminarCatMetodoPago.TabIndex = 19;
            this.btn_EliminarCatMetodoPago.Text = "Eliminar";
            this.btn_EliminarCatMetodoPago.UseVisualStyleBackColor = false;
            this.btn_EliminarCatMetodoPago.MouseEnter += new System.EventHandler(this.btn_EliminarCatMetodoPago_MouseEnter);
            this.btn_EliminarCatMetodoPago.MouseLeave += new System.EventHandler(this.btn_EliminarCatMetodoPago_MouseLeave);
            // 
            // gbListaCatMetodoPago
            // 
            this.gbListaCatMetodoPago.Controls.Add(this.dgvCatMetodoPago);
            this.gbListaCatMetodoPago.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbListaCatMetodoPago.ForeColor = System.Drawing.Color.Black;
            this.gbListaCatMetodoPago.Location = new System.Drawing.Point(36, 119);
            this.gbListaCatMetodoPago.Name = "gbListaCatMetodoPago";
            this.gbListaCatMetodoPago.Size = new System.Drawing.Size(260, 230);
            this.gbListaCatMetodoPago.TabIndex = 20;
            this.gbListaCatMetodoPago.TabStop = false;
            this.gbListaCatMetodoPago.Text = "Lista de registro";
            // 
            // dgvCatMetodoPago
            // 
            this.dgvCatMetodoPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCatMetodoPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatMetodoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatMetodoPago.Location = new System.Drawing.Point(8, 18);
            this.dgvCatMetodoPago.Name = "dgvCatMetodoPago";
            this.dgvCatMetodoPago.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatMetodoPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCatMetodoPago.Size = new System.Drawing.Size(246, 192);
            this.dgvCatMetodoPago.TabIndex = 0;
            this.dgvCatMetodoPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatMetodoPago_CellContentClick);
            this.dgvCatMetodoPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatMetodoPago_CellDoubleClick);
            // 
            // txtCodigoCatMetodoPago
            // 
            this.txtCodigoCatMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.txtCodigoCatMetodoPago.ForeColor = System.Drawing.Color.White;
            this.txtCodigoCatMetodoPago.Location = new System.Drawing.Point(81, 38);
            this.txtCodigoCatMetodoPago.Name = "txtCodigoCatMetodoPago";
            this.txtCodigoCatMetodoPago.Size = new System.Drawing.Size(209, 20);
            this.txtCodigoCatMetodoPago.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSalir.Location = new System.Drawing.Point(313, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 34);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(310, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 41);
            this.label2.TabIndex = 24;
            this.label2.Text = "Haga doble click en el cuadro para eliminar un registro";
            this.label2.Visible = false;
            // 
            // FormCategoriaMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(432, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCodigoCatMetodoPago);
            this.Controls.Add(this.gbListaCatMetodoPago);
            this.Controls.Add(this.btn_EliminarCatMetodoPago);
            this.Controls.Add(this.btn_ModificarCatMetodoPago);
            this.Controls.Add(this.txtNombreCatMetodoPago);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_AgregarCatMetodoPago);
            this.Controls.Add(this.lbl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoriaMetodoPago";
            this.Text = "FormCategoriaMetodoPago";
            this.gbListaCatMetodoPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatMetodoPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_1;
        private Button btn_AgregarCatMetodoPago;
        private Label lbl_2;
        private TextBox txtNombreCatMetodoPago;
        private Button btn_ModificarCatMetodoPago;
        private Button btn_EliminarCatMetodoPago;
        private GroupBox gbListaCatMetodoPago;
        private DataGridView dgvCatMetodoPago;
        private TextBox txtCodigoCatMetodoPago;
        private Button btnSalir;
        private Label label2;
    }
}