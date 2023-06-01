namespace CapaPresentacion
{
    partial class formAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdministrador));
            this.panelBARRA = new System.Windows.Forms.Panel();
            this.ptnMin = new System.Windows.Forms.PictureBox();
            this.ptnMinimize = new System.Windows.Forms.PictureBox();
            this.ptnMax = new System.Windows.Forms.PictureBox();
            this.ptnClose = new System.Windows.Forms.PictureBox();
            this.panelVERTICAL = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCatMetodo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSubVert = new System.Windows.Forms.Panel();
            this.ptnBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCatProduct = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.subReport = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.nameTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelBARRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnClose)).BeginInit();
            this.panelVERTICAL.SuspendLayout();
            this.panelSubVert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.subReport.SuspendLayout();
            this.panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBARRA
            // 
            this.panelBARRA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBARRA.Controls.Add(this.ptnMin);
            this.panelBARRA.Controls.Add(this.ptnMinimize);
            this.panelBARRA.Controls.Add(this.ptnMax);
            this.panelBARRA.Controls.Add(this.ptnClose);
            this.panelBARRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBARRA.Location = new System.Drawing.Point(0, 0);
            this.panelBARRA.Name = "panelBARRA";
            this.panelBARRA.Size = new System.Drawing.Size(1300, 38);
            this.panelBARRA.TabIndex = 0;
            this.panelBARRA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBARRA_MouseDown);
            // 
            // ptnMin
            // 
            this.ptnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnMin.Image = ((System.Drawing.Image)(resources.GetObject("ptnMin.Image")));
            this.ptnMin.Location = new System.Drawing.Point(1221, 7);
            this.ptnMin.Name = "ptnMin";
            this.ptnMin.Size = new System.Drawing.Size(25, 25);
            this.ptnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptnMin.TabIndex = 5;
            this.ptnMin.TabStop = false;
            this.ptnMin.Visible = false;
            this.ptnMin.Click += new System.EventHandler(this.ptnMin_Click);
            // 
            // ptnMinimize
            // 
            this.ptnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptnMinimize.Image")));
            this.ptnMinimize.Location = new System.Drawing.Point(1179, 7);
            this.ptnMinimize.Name = "ptnMinimize";
            this.ptnMinimize.Size = new System.Drawing.Size(25, 25);
            this.ptnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptnMinimize.TabIndex = 4;
            this.ptnMinimize.TabStop = false;
            this.ptnMinimize.Click += new System.EventHandler(this.ptnMinimize_Click);
            // 
            // ptnMax
            // 
            this.ptnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnMax.Image = ((System.Drawing.Image)(resources.GetObject("ptnMax.Image")));
            this.ptnMax.Location = new System.Drawing.Point(1221, 7);
            this.ptnMax.Name = "ptnMax";
            this.ptnMax.Size = new System.Drawing.Size(25, 25);
            this.ptnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptnMax.TabIndex = 3;
            this.ptnMax.TabStop = false;
            this.ptnMax.Click += new System.EventHandler(this.ptnMax_Click);
            // 
            // ptnClose
            // 
            this.ptnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnClose.Image = ((System.Drawing.Image)(resources.GetObject("ptnClose.Image")));
            this.ptnClose.Location = new System.Drawing.Point(1263, 7);
            this.ptnClose.Name = "ptnClose";
            this.ptnClose.Size = new System.Drawing.Size(25, 25);
            this.ptnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptnClose.TabIndex = 2;
            this.ptnClose.TabStop = false;
            this.ptnClose.Click += new System.EventHandler(this.ptnClose_Click);
            // 
            // panelVERTICAL
            // 
            this.panelVERTICAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(7)))));
            this.panelVERTICAL.Controls.Add(this.panel6);
            this.panelVERTICAL.Controls.Add(this.btnReportes);
            this.panelVERTICAL.Controls.Add(this.panel5);
            this.panelVERTICAL.Controls.Add(this.btnMetodo);
            this.panelVERTICAL.Controls.Add(this.panel3);
            this.panelVERTICAL.Controls.Add(this.panel4);
            this.panelVERTICAL.Controls.Add(this.btnCatMetodo);
            this.panelVERTICAL.Controls.Add(this.panel2);
            this.panelVERTICAL.Controls.Add(this.btnProducto);
            this.panelVERTICAL.Controls.Add(this.panel1);
            this.panelVERTICAL.Controls.Add(this.panelSubVert);
            this.panelVERTICAL.Controls.Add(this.btnCatProduct);
            this.panelVERTICAL.Controls.Add(this.btnRegistrar);
            this.panelVERTICAL.Controls.Add(this.subReport);
            this.panelVERTICAL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVERTICAL.Location = new System.Drawing.Point(0, 38);
            this.panelVERTICAL.Name = "panelVERTICAL";
            this.panelVERTICAL.Size = new System.Drawing.Size(200, 712);
            this.panelVERTICAL.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(-3, 541);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 73);
            this.panel6.TabIndex = 11;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(3, 541);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReportes.Size = new System.Drawing.Size(197, 73);
            this.btnReportes.TabIndex = 12;
            this.btnReportes.Text = "    Reportes ";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(-3, 462);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 73);
            this.panel5.TabIndex = 9;
            // 
            // btnMetodo
            // 
            this.btnMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnMetodo.FlatAppearance.BorderSize = 0;
            this.btnMetodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodo.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo.ForeColor = System.Drawing.Color.Black;
            this.btnMetodo.Image = ((System.Drawing.Image)(resources.GetObject("btnMetodo.Image")));
            this.btnMetodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetodo.Location = new System.Drawing.Point(3, 462);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMetodo.Size = new System.Drawing.Size(197, 73);
            this.btnMetodo.TabIndex = 10;
            this.btnMetodo.Text = "    Metodo de\r\n    Pago";
            this.btnMetodo.UseVisualStyleBackColor = false;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(-3, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 73);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(-3, 383);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 73);
            this.panel4.TabIndex = 7;
            // 
            // btnCatMetodo
            // 
            this.btnCatMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnCatMetodo.FlatAppearance.BorderSize = 0;
            this.btnCatMetodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCatMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatMetodo.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatMetodo.ForeColor = System.Drawing.Color.Black;
            this.btnCatMetodo.Image = ((System.Drawing.Image)(resources.GetObject("btnCatMetodo.Image")));
            this.btnCatMetodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatMetodo.Location = new System.Drawing.Point(3, 383);
            this.btnCatMetodo.Name = "btnCatMetodo";
            this.btnCatMetodo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCatMetodo.Size = new System.Drawing.Size(197, 73);
            this.btnCatMetodo.TabIndex = 8;
            this.btnCatMetodo.Text = "      Categoria\r\n         Metodo de Pago";
            this.btnCatMetodo.UseVisualStyleBackColor = false;
            this.btnCatMetodo.Click += new System.EventHandler(this.btnCatMetodo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(-3, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 73);
            this.panel2.TabIndex = 3;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.Black;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(3, 304);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProducto.Size = new System.Drawing.Size(197, 73);
            this.btnProducto.TabIndex = 4;
            this.btnProducto.Text = "    Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(-3, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 73);
            this.panel1.TabIndex = 2;
            // 
            // panelSubVert
            // 
            this.panelSubVert.Controls.Add(this.ptnBack);
            this.panelSubVert.Controls.Add(this.pictureBox1);
            this.panelSubVert.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubVert.Location = new System.Drawing.Point(0, 0);
            this.panelSubVert.Name = "panelSubVert";
            this.panelSubVert.Size = new System.Drawing.Size(200, 140);
            this.panelSubVert.TabIndex = 2;
            // 
            // ptnBack
            // 
            this.ptnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ptnBack.Image = ((System.Drawing.Image)(resources.GetObject("ptnBack.Image")));
            this.ptnBack.Location = new System.Drawing.Point(0, 31);
            this.ptnBack.Name = "ptnBack";
            this.ptnBack.Size = new System.Drawing.Size(74, 109);
            this.ptnBack.TabIndex = 2;
            this.ptnBack.TabStop = false;
            this.ptnBack.Click += new System.EventHandler(this.ptnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCatProduct
            // 
            this.btnCatProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnCatProduct.FlatAppearance.BorderSize = 0;
            this.btnCatProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCatProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatProduct.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCatProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnCatProduct.Image")));
            this.btnCatProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatProduct.Location = new System.Drawing.Point(3, 225);
            this.btnCatProduct.Name = "btnCatProduct";
            this.btnCatProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCatProduct.Size = new System.Drawing.Size(197, 73);
            this.btnCatProduct.TabIndex = 2;
            this.btnCatProduct.Text = "    Categoria\r\n    Producto";
            this.btnCatProduct.UseVisualStyleBackColor = false;
            this.btnCatProduct.Click += new System.EventHandler(this.btnCatProduct_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(3, 146);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrar.Size = new System.Drawing.Size(197, 73);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "    Registro\r\n    Usuarios";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // subReport
            // 
            this.subReport.Controls.Add(this.panel9);
            this.subReport.Controls.Add(this.btnPedidos);
            this.subReport.Controls.Add(this.panel8);
            this.subReport.Controls.Add(this.btnVentas);
            this.subReport.Location = new System.Drawing.Point(27, 619);
            this.subReport.Name = "subReport";
            this.subReport.Size = new System.Drawing.Size(173, 81);
            this.subReport.TabIndex = 0;
            this.subReport.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Location = new System.Drawing.Point(-3, 42);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 36);
            this.panel9.TabIndex = 15;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPedidos.Location = new System.Drawing.Point(3, 42);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPedidos.Size = new System.Drawing.Size(170, 36);
            this.btnPedidos.TabIndex = 16;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Location = new System.Drawing.Point(-3, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 36);
            this.panel8.TabIndex = 13;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(3, 0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVentas.Size = new System.Drawing.Size(170, 36);
            this.btnVentas.TabIndex = 14;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.Controls.Add(this.nameTitulo);
            this.panelEscritorio.Controls.Add(this.pictureBox2);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(200, 38);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1100, 712);
            this.panelEscritorio.TabIndex = 2;
            // 
            // nameTitulo
            // 
            this.nameTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameTitulo.AutoSize = true;
            this.nameTitulo.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.nameTitulo.Location = new System.Drawing.Point(451, 541);
            this.nameTitulo.Name = "nameTitulo";
            this.nameTitulo.Size = new System.Drawing.Size(272, 33);
            this.nameTitulo.TabIndex = 2;
            this.nameTitulo.Text = "Pollería Wilson-Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(300, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(523, 478);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // formAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelVERTICAL);
            this.Controls.Add(this.panelBARRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAdministrador";
            this.Text = "Administrador";
            this.panelBARRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnClose)).EndInit();
            this.panelVERTICAL.ResumeLayout(false);
            this.panelSubVert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.subReport.ResumeLayout(false);
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBARRA;
        private System.Windows.Forms.Panel panelVERTICAL;
        private System.Windows.Forms.Panel panelSubVert;
        private System.Windows.Forms.PictureBox ptnClose;
        private System.Windows.Forms.PictureBox ptnMax;
        private System.Windows.Forms.PictureBox ptnMinimize;
        private System.Windows.Forms.PictureBox ptnMin;
        private System.Windows.Forms.PictureBox ptnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCatProduct;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCatMetodo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Panel subReport;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameTitulo;
    }
}