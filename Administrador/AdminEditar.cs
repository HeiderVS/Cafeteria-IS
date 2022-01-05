using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafeteria_IS.Administrador;
using Controladores.Administrador;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace Cafeteria_IS
{
    public partial class AdminEditar : Form
    {
        private UsuariosControlador _usuariosControlador = new UsuariosControlador();

        public AdminEditar()
        {
            InitializeComponent();
        }

        private void AdminEditar_Load(object sender, EventArgs e)
        {
            radGridView1.DataSource = _usuariosControlador.GetUsuarios();
            radGridView1.Columns[0].ReadOnly = true;
            radGridView1.Columns[4].ReadOnly = true;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Editar_Empleado_Existente editarEmpleadoExistente =
                new Editar_Empleado_Existente((UsuarioInfoViewModel) this.radGridView1.CurrentRow.DataBoundItem);
            editarEmpleadoExistente.Show();
        }

        private void btnEditarUsuarioExistente_Click(object sender, EventArgs e)
        {
            /*Editar_Empleado_Existente frm = new Editar_Empleado_Existente();
            frm.Show();*/
            this.radGridView1.PrintPreview();
        }

        private void radGridView1_CollectionChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (GridViewDataRowInfo rowInfo in e.NewItems)
                {
                    _usuariosControlador.EliminarUsuario((UsuarioInfoViewModel) rowInfo.DataBoundItem);
                }
            }
        }

        private void radGridView1_ValueChanging(object sender, GridViewCollectionChangingEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                var value = "";
                if (AuthenticationBox.Show("Autenticacion", "Ingrese la contrasena de administrador", ref value) !=
                    DialogResult.OK) e.Cancel = true;

                if (_usuariosControlador.AuthAdministrador(value) == null)
                {
                    MessageBox.Show("Usuario no valido");
                    e.Cancel = true;
                }
            }
        }

        private void radGridView1_CellValidating(object sender, CellValidatingEventArgs e)
        {
            if (e.ActiveEditor == null) return;

            if ((string) e.Value != "" && ((string) e.Value).All(char.IsLetter)) return;
            
            e.Cancel = true;
            MessageBox.Show("Caracter no permitido");
        }

        private void radGridView1_CellEvent(object sender, EventArgs eventArgs)
        {
            var value = "";

            if (AuthenticationBox.Show("Autenticacion", "Ingrese la contrasena de administrador", ref value) !=
                DialogResult.OK) return;

            if (_usuariosControlador.AuthAdministrador(value) == null)
            {
                MessageBox.Show("Usuario no valido");
                radGridView1.DataSource = _usuariosControlador.GetUsuarios();
                return;
            }

            _usuariosControlador.ActualizarUsuario(
                (UsuarioInfoViewModel) ((GridViewCellEventArgs) eventArgs).Row.DataBoundItem);
        }
    }
}