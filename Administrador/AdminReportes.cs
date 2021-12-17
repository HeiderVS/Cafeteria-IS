using System;
using System.Windows.Forms;
using Controladores;

namespace Cafeteria_IS
{
    public partial class AdminReportes : Form
    {
        private AdminReportesControlador _adminReportesControlador = new AdminReportesControlador();

        public AdminReportes()
        {
            InitializeComponent();
        }

        private void radDateReportStart_ValueChanged(object sender, EventArgs e)
        {
            /*var startDate = radDateReportStart.Value;
            var endDate = radDateReportEnd.Value;

            if (DateTime.Compare(startDate, endDate) <= 0)
            {
                this.radDateReportEnd.MinDate = startDate;
                return;
            }

            this.radDateReportStart.Value = DateTime.Now;
            MessageBox.Show("La fecha inicial no puede ser mayor que la final");*/
        }

        private void radDateReportEnd_ValueChanged(object sender, EventArgs e)
        {
            /*var startDate = this.radDateReportStart.Value;
            var endDate = this.radDateReportEnd.Value;


            if (DateTime.Compare(endDate, startDate) > 0)
            {
                this.radDateReportStart.MaxDate = endDate;
                return;
            }

            this.radDateReportEnd.Value = DateTime.Now;
            MessageBox.Show("La fecha final no puede ser menor que la inicial");*/
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var startDate = this.radDateReportStart.Value;
            var endDate = this.radDateReportEnd.Value;
            radGridView1.DataSource = _adminReportesControlador.GetReportes(startDate, endDate);
        }

        private void radBtnImprimir_Click(object sender, EventArgs e)
        {
            if (this.radGridView1.RowCount > 0)
            {
                this.radGridView1.PrintPreview();
            }
        }
    }
}