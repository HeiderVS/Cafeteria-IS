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
            UsuariosAgregar usuariosAgregar = new UsuariosAgregar();
            usuariosAgregar.Show();
            this.Hide();
        }
    }
}