using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReporteDetallePedido : Form
    {
        public System.Drawing.Point MoveForm_MousePosition;
        public FormReporteDetallePedido()
        {
            InitializeComponent();
        }

        private void FormReporteDetallePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDWILSONDataSet.DetallePedido' Puede moverla o quitarla según sea necesario.
            this.detallePedidoTableAdapter.Fill(this.bDWILSONDataSet.DetallePedido);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("sDate", " "));
            reportParameters.Add(new ReportParameter("eDate", " "));
            reporteDetallePedido.LocalReport.SetParameters(reportParameters);
            this.reporteDetallePedido.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.detallePedidoTableAdapter.filterDate(this.bDWILSONDataSet.DetallePedido, dtInicio.Value.ToString("yyyy/MM/dd"), dtFin.Value.ToString("yyyy/MM/dd"));
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("sDate", dtInicio.Value.ToString("yyyy/MM/dd")));
            reportParameters.Add(new ReportParameter("eDate", dtFin.Value.ToString("yyyy/MM/dd")));
            reporteDetallePedido.LocalReport.SetParameters(reportParameters);
            this.reporteDetallePedido.RefreshReport();
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
