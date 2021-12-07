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
    public partial class UsuariosAgregar : Form
    {
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
            try
            {
                string NomU = Convert.ToString(txtNombre.Text).Substring(0, 3) + Convert.ToString(txtApPaterno.Text).Substring(0,3) + Convert.ToString(txtApMaterno.Text).Substring(0,3);
                BorrarMensajesError();
                if (ValidarCampos())
                {
                    MessageBox.Show("Credenciales Generadas con Exito","Credenciales",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    txtNomUsuario.Visible = true;
                    txtContraAgregarUsuario.Visible = true;
                    btnRegistrarUsuario.Visible = true;
                    btnAceptar.Visible = false;
                    btnCancelarAgrUsuario.Visible = true;

                    txtNomUsuario.Text = NomU;

                    
                }
                ValidarCampos();
            }
            catch
            {
                
            }
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
            DialogResult dr = MessageBox.Show("Seguro que quieres cancelar el registro?", "Cancelar", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                
                MessageBox.Show("Operacion Cancelada","Cancelar",MessageBoxButtons.OK ,MessageBoxIcon.Information);
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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Confirmacion para guardar al empleado", "Confirmar", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
               

                MessageBox.Show("Empleado agregado con exito ("+Convert.ToString(txtNomUsuario.Text)+")","Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //MOSTRAR SEÑAL DE ERRROR EN EL TXBOX SI NO TIENE EL FORMATO CORRECTO USANDO EL EVENTO "VALIDATING"

        /*private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            char nombre;
            if (!char.TryParse(txtNombre.Text,out nombre))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre valido (Solo letras)");
            }else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtApPaterno_Validating(object sender, CancelEventArgs e)
        {
            char apPaterno;
            if (!char.TryParse(txtApPaterno.Text, out apPaterno))
            {
                errorProvider1.SetError(txtApPaterno, "Ingrese un Nombre valido (Solo letras)");
            }
            else
            {
                errorProvider1.SetError(txtApPaterno, "");
            }
        }
        private void txtApMaterno_Validating(object sender, CancelEventArgs e)
        {
            char apMaterno;
            if (!char.TryParse(txtApMaterno.Text, out apMaterno))
            {
                errorProvider1.SetError(txtApMaterno, "Ingrese un Nombre valido (Solo letras)");
            }
            else
            {
                errorProvider1.SetError(txtApMaterno, "");
            }
        }*/




    }
}