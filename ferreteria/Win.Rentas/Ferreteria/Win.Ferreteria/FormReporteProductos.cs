using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Ferreteria
{
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();

            var _productoBL = new ProductosBL();
            var bindingsource = new BindingSource();
            bindingsource.DataSource = _productoBL.ObtenerProductos();

            var reporte = new ReporteProductos();
            reporte.SetDataSource(bindingsource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void FormReporteProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
