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
    public partial class Editar_Empleado_Existente : Form
    {
        public Editar_Empleado_Existente()
        {
            InitializeComponent();
        }

        private void btnAceptarEditarUserExistente_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (ValidarCampos())
            {
                MessageBox.Show("Nuevo Nombre de Usuario Generado", "Usuario Generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnGuardarNuevoUsuario.Visible = true;
                string NomU = Convert.ToString(txtNombreNuevo.Text).Substring(0, 3) + Convert.ToString(txtApPaternoNuevo.Text).Substring(0, 3) + Convert.ToString(txtApMaternoNuevo.Text).Substring(0, 3);
                lblNuevoNombreUsuario.Text = NomU;
                lblTitulo.Visible = true;
                lblNuevoNombreUsuario.Visible = true;
            }

        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombreNuevo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreNuevo, "Ingrese un Nombre Valido (Solo letras)");
            }
            if (txtApPaternoNuevo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApPaternoNuevo, "Ingrese un Apellido Valido (Solo letras)");
            }
            if (txtApMaternoNuevo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApMaternoNuevo, "Ingrese un Apellido Valido (Solo letras)");
            }
            return ok;
        }
        private void BorrarMensajesError()
        {
            errorProvider1.SetError(txtNombreNuevo, "");
            errorProvider1.SetError(txtApPaternoNuevo, "");
            errorProvider1.SetError(txtApMaternoNuevo, "");
        }

        private void btnGuardarNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("Desea guardar los nuevos datos?", "Confirmacion", botones, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Datos nuevos guartdados", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblNuevoNombreUsuario.Text = "";
                    this.Hide();
                }
                

            }
            catch
            {
                MessageBox.Show("Ocurrio un Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
