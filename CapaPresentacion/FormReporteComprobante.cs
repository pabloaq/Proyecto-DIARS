using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReporteComprobante : Form
    {
        public System.Drawing.Point MoveForm_MousePosition;
        public FormReporteComprobante()
        {
            InitializeComponent();
        }

        private void FormReporteComprobante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDWILSONDataSet.Comprobante' Puede moverla o quitarla según sea necesario.
            this.comprobanteTableAdapter.Fill(this.bDWILSONDataSet.Comprobante);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("sDate", " "));
            reportParameters.Add(new ReportParameter("eDate", " "));
            reporteComprobante.LocalReport.SetParameters(reportParameters);
            this.reporteComprobante.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.comprobanteTableAdapter.filterDate(this.bDWILSONDataSet.Comprobante, dtInicio.Value.ToString("yyyy/MM/dd"), dtFin.Value.ToString("yyyy/MM/dd"));
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("sDate", dtInicio.Value.ToString("yyyy/MM/dd")));
            reportParameters.Add(new ReportParameter("eDate", dtFin.Value.ToString("yyyy/MM/dd")));
            reporteComprobante.LocalReport.SetParameters(reportParameters);
            this.reporteComprobante.RefreshReport();
        }

        private void ptnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelBotones_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm_MousePosition = new System.Drawing.Point(-e.X, -e.Y);
        }

        private void panelBotones_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Drawing.Point mousePosition = Control.MousePosition;
                mousePosition.Offset(MoveForm_MousePosition.X, MoveForm_MousePosition.Y);
                this.Location = mousePosition;
            }
        }
    }
}
