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
    }
}