using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria_IS
{
    public partial class AdminEliminar : Form
    {
        public AdminEliminar()
        {
            InitializeComponent();
        }

      

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            AdminEditar frm = new AdminEditar();
            frm.Show();
            this.Hide();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            AdminEliminar frm = new AdminEliminar();
            frm.Show();
            this.Show();
        }

        private void radBtnReports_Click(object sender, EventArgs e)
        {
            AdminReportes adminReportes = new AdminReportes();
            adminReportes.Show();
            this.Hide();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            UsuariosAgregar frm = new UsuariosAgregar();
            frm.Show();
            this.Hide();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
