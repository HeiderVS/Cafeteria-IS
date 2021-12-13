using System;
using System.Windows.Forms;

namespace Cafeteria_IS
{
    public partial class AdminReportes : Form
    {
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
    }
}