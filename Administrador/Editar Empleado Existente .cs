using System;
using System.Windows.Forms;
using Cafeteria_IS.Administrador;
using Controladores.Administrador;

namespace Cafeteria_IS
{
    public partial class Editar_Empleado_Existente : Form
    {
        private EditarUsuarioControlador _usuarioControlador;
        public Editar_Empleado_Existente(UsuarioInfoViewModel usuarioInfoViewModel)
        {
            InitializeComponent();
            _usuarioControlador = new EditarUsuarioControlador(usuarioInfoViewModel);
        }
        private void Editar_Empleado_Existente_Load(object sender, EventArgs e)
        {
            txtNombreNuevo.Text = _usuarioControlador.UsuarioInfoViewModel.name;
            txtApPaternoNuevo.Text = _usuarioControlador.UsuarioInfoViewModel.paternal;
            txtApMaternoNuevo.Text = _usuarioControlador.UsuarioInfoViewModel.maternal;
            radEtUsuario.Text = _usuarioControlador.UsuarioInfoViewModel.username;
        }

        private void radBtnReestablecer_Click(object sender, EventArgs e)
        {
            var value = "";
            if (AuthenticationBox.Show("Autenticacion", "Ingrese la contrasena de administrador", ref value) !=
                DialogResult.OK) return;
            
            if (_usuarioControlador.AuthAdministrador(value) == null)
            {
                MessageBox.Show("Usuario no valido");
                return;
            }

            radTextBox1.Text = _usuarioControlador.ReestablecerUsuario(_usuarioControlador.UsuarioInfoViewModel);
            this.radBtnGuardar.Visible = true;
        }

        private void radBtnGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
