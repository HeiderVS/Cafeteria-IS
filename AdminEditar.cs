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
    public partial class AdminEditar : Form
    {
        public AdminEditar()
        {
            InitializeComponent();
        }

        private void AdminEditar_Load(object sender, EventArgs e)
        {

        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            UsuariosAgregar frm = new UsuariosAgregar();
            frm.Show();
            this.Hide();
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
            this.Hide();
        }
    }
}
