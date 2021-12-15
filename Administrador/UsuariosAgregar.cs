using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores.Administrador;
using Modelos.Usuarios;

namespace Cafeteria_IS
{
    public partial class UsuariosAgregar : Form
    {
        private UsuariosControlador _usuariosControlador = new UsuariosControlador();

        public UsuariosAgregar()
        {
            InitializeComponent();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            AdminEditar frm = new AdminEditar();
            frm.Show();
            this.Hide();
        }

        private void UsuariosAgregar_Load(object sender, EventArgs e)
        {
        }

        private void radBtnReports_Click(object sender, EventArgs e)
        {
            AdminReportes adminReportes = new AdminReportes();
            adminReportes.Show();
            this.Hide();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            AdminEliminar frm = new AdminEliminar();
            frm.Show();
            this.Hide();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            UsuariosAgregar frm = new UsuariosAgregar();
            frm.Show();
            this.Hide();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (ValidarCampos())
            {
                MessageBox.Show("Credenciales Generadas con Exito", "Credenciales", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                lbl1.Visible = true;
                lbl2.Visible = true;
                txtNomUsuario.Visible = true;
                txtContraAgregarUsuario.Visible = true;
                btnRegistrarUsuario.Visible = true;
                btnAceptar.Visible = false;
                btnCancelarAgrUsuario.Visible = true;

                CredencialesViewModel userCredentials =
                    _usuariosControlador.RegistraUsuario(txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text);

                txtNomUsuario.Text = userCredentials.username;
                txtContraAgregarUsuario.Text = userCredentials.generatedPassword;

                /*
                 *
                 * string NomU = Convert.ToString(txtNombre.Text).Substring(0, 3) +
                              Convert.ToString(txtApPaterno.Text).Substring(0, 3) +
                              Convert.ToString(txtApMaterno.Text).Substring(0, 3);
                txtNomUsuario.Text = NomU;

                //Generando Contraseña Aleatoria
                Random rdn = new Random();
                string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890=+/?*&#";
                int longitud = caracteres.Length;
                char letra;
                int longitudContrasenia = 10;
                string contraseniaAleatoria = string.Empty;
                for (int i = 0; i < longitudContrasenia; i++)
                {
                    letra = caracteres[rdn.Next(longitud)];
                    contraseniaAleatoria += letra.ToString();
                }

                txtContraAgregarUsuario.Text = contraseniaAleatoria;
                //-----------------------------------------------------------------------
                 */
            }

            ValidarCampos();
        }


        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre Valido (Solo letras)");
            }

            if (txtApPaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApPaterno, "Ingrese un Apellido Valido (Solo letras)");
            }

            if (txtApMaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApMaterno, "Ingrese un Apellido Valido (Solo letras)");
            }

            return ok;
        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApPaterno, "");
            errorProvider1.SetError(txtApMaterno, "");
        }

        private void btnCancelarAgrUsuario_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Seguro que quieres cancelar el registro?", "Cancelar", botones,
                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Operacion Cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApPaterno.Clear();
                txtApMaterno.Clear();
                lbl1.Visible = false;
                lbl2.Visible = false;
                txtNomUsuario.Visible = false;
                txtContraAgregarUsuario.Visible = false;
                btnRegistrarUsuario.Visible = false;
                btnAceptar.Visible = true;
                btnCancelarAgrUsuario.Visible = false;
                txtNomUsuario.Clear();
                txtContraAgregarUsuario.Clear();
                txtNomUsuario.Clear();
                txtContraAgregarUsuario.Clear();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char) Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras en este campo", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApPaterno_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char) Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras en este campo", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char) Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras en este campo", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Desea Agregar este Empleado?: (" + txtNomUsuario.Text + ")", "Confirmar",
                botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Empleado agregado con exito (" + txtNomUsuario.Text + ")", "Guardado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApPaterno.Clear();
                txtApMaterno.Clear();
                lbl1.Visible = false;
                lbl2.Visible = false;
                txtNomUsuario.Visible = false;
                txtContraAgregarUsuario.Visible = false;
                btnRegistrarUsuario.Visible = false;
                btnAceptar.Visible = true;
                btnCancelarAgrUsuario.Visible = false;
                txtNomUsuario.Clear();
                txtContraAgregarUsuario.Clear();
            }
            else
            {
                txtNombre.Clear();
                txtApPaterno.Clear();
                txtApMaterno.Clear();
                lbl1.Visible = false;
                lbl2.Visible = false;
                txtNomUsuario.Visible = false;
                txtContraAgregarUsuario.Visible = false;
                btnRegistrarUsuario.Visible = false;
                btnAceptar.Visible = true;
                btnCancelarAgrUsuario.Visible = false;
                txtNomUsuario.Clear();
                txtContraAgregarUsuario.Clear();
            }
        }

        private void txtContraAgregarUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            InventarioAgregar inventarioAgregar = new InventarioAgregar();
            inventarioAgregar.Show();
            this.Hide();
        }
    }
}