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

        private void radMenuBtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AdminEditar frm = new AdminEditar();
            frm.Show();
            this.Hide();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            AdminEliminar frm = new AdminEliminar();
            frm.Show();
            this.Hide();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            UsuariosAgregar frm = new UsuariosAgregar();
            frm.Show();
            this.Hide();
        }

        private void radDateReportStart_ValueChanged(object sender, EventArgs e)
        {
            var startDate = this.radDateReportStart.Value;
            var endDate = this.radDateReportEnd.Value;

            if (DateTime.Compare(startDate, endDate) <= 0)
            {
                this.radDateReportEnd.MinDate = startDate;
                return;
            }
            
            this.radDateReportStart.Value = DateTime.Today;
            MessageBox.Show("La fecha inicial no puede ser mayor que la final");
        }
        
        private void radDateReportEnd_ValueChanged(object sender, EventArgs e)
        {
            var startDate = this.radDateReportStart.Value;
            var endDate = this.radDateReportEnd.Value;
            
            
            if (DateTime.Compare(endDate, startDate) > 0)
            {
                this.radDateReportStart.MaxDate = endDate;
                return;
            }
            
            this.radDateReportEnd.Value = DateTime.Today;
            MessageBox.Show("La fecha final no puede ser menor que la inicial");
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var startDate = this.radDateReportStart.Value;
            var endDate = this.radDateReportEnd.Value;
            radGridView1.DataSource = _adminReportesControlador.GetReportes(startDate, endDate);
        }
    }
}