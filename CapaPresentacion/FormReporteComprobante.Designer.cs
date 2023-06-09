namespace CapaPresentacion
{
    partial class FormReporteComprobante
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteComprobante));
            this.comprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDWILSONDataSet = new CapaPresentacion.BDWILSONDataSet();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lbInicio = new System.Windows.Forms.Label();
            this.lbFin = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reporteComprobante = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comprobanteTableAdapter = new CapaPresentacion.BDWILSONDataSetTableAdapters.ComprobanteTableAdapter();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.ptnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDWILSONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // comprobanteBindingSource
            // 
            this.comprobanteBindingSource.DataMember = "Comprobante";
            this.comprobanteBindingSource.DataSource = this.bDWILSONDataSet;
            // 
            // bDWILSONDataSet
            // 
            this.bDWILSONDataSet.DataSetName = "BDWILSONDataSet";
            this.bDWILSONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtFin
            // 
            this.dtFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFin.CustomFormat = "yyyy/MM/dd";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(62, 321);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(153, 20);
            this.dtFin.TabIndex = 14;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(91, 377);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(105, 42);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.ForeColor = System.Drawing.Color.White;
            this.lbInicio.Location = new System.Drawing.Point(57, 212);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(84, 28);
            this.lbInicio.TabIndex = 12;
            this.lbInicio.Text = "INICIO";
            // 
            // lbFin
            // 
            this.lbFin.AutoSize = true;
            this.lbFin.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFin.ForeColor = System.Drawing.Color.White;
            this.lbFin.Location = new System.Drawing.Point(57, 281);
            this.lbFin.Name = "lbFin";
            this.lbFin.Size = new System.Drawing.Size(48, 28);
            this.lbFin.TabIndex = 11;
            this.lbFin.Text = "FIN";
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "yyyy/MM/dd";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(62, 249);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(153, 20);
            this.dtInicio.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(60, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // reporteComprobante
            // 
            reportDataSource1.Name = "ReporteComprobante";
            reportDataSource1.Value = this.comprobanteBindingSource;
            this.reporteComprobante.LocalReport.DataSources.Add(reportDataSource1);
            this.reporteComprobante.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteComprobante.rdlc";
            this.reporteComprobante.Location = new System.Drawing.Point(277, 63);
            this.reporteComprobante.Name = "reporteComprobante";
            this.reporteComprobante.ServerReport.BearerToken = null;
            this.reporteComprobante.Size = new System.Drawing.Size(851, 382);
            this.reporteComprobante.TabIndex = 15;
            // 
            // comprobanteTableAdapter
            // 
            this.comprobanteTableAdapter.ClearBeforeFill = true;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.ptnClose);
            this.panelBotones.Location = new System.Drawing.Point(0, 1);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1175, 38);
            this.panelBotones.TabIndex = 16;
            this.panelBotones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBotones_MouseDown);
            this.panelBotones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBotones_MouseMove);
            // 
            // ptnClose
            // 
            this.ptnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnClose.Image = ((System.Drawing.Image)(resources.GetObject("ptnClose.Image")));
            this.ptnClose.Location = new System.Drawing.Point(1143, 7);
            this.ptnClose.Name = "ptnClose";
            this.ptnClose.Size = new System.Drawing.Size(25, 25);
            this.ptnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptnClose.TabIndex = 6;
            this.ptnClose.TabStop = false;
            this.ptnClose.Click += new System.EventHandler(this.ptnClose_Click);
            // 
            // FormReporteComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1174, 481);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.reporteComprobante);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.lbFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteComprobante";
            this.Load += new System.EventHandler(this.FormReporteComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDWILSONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label lbFin;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reporteComprobante;
        private BDWILSONDataSet bDWILSONDataSet;
        private System.Windows.Forms.BindingSource comprobanteBindingSource;
        private BDWILSONDataSetTableAdapters.ComprobanteTableAdapter comprobanteTableAdapter;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.PictureBox ptnClose;
    }
}