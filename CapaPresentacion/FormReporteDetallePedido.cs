using CapaDatos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReporteDetallePedido : Form
    {
        public FormReporteDetallePedido()
        {
            InitializeComponent();
        }

        private void FormReporteDetallePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDWILSONDataSet.DetallePedido' Puede moverla o quitarla según sea necesario.
            this.detallePedidoTableAdapter.Fill(this.bDWILSONDataSet.DetallePedido);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("sDate", dtInicio.Value.ToString("yyyy/MM/dd")));
            reportParameters.Add(new ReportParameter("eDate", dtFin.Value.ToString("yyyy/MM/dd")));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.detallePedidoTableAdapter.filterDate(this.bDWILSONDataSet.DetallePedido, dtInicio.Value.ToString("yyyy/MM/dd"), dtFin.Value.ToString("yyyy/MM/dd"));
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("sDate", dtInicio.Value.ToString("yyyy/MM/dd")));
            reportParameters.Add(new ReportParameter("eDate", dtFin.Value.ToString("yyyy/MM/dd")));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
