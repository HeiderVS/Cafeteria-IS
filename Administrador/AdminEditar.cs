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
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Desea generar una nueva contraseña para este empleado?", "Confirmacion",
                botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
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

                //-----------------------------------------------------------------------
                MessageBox.Show("Contraseña Generada con exito", "Contraseña Generada", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Clipboard.SetDataObject(contraseniaAleatoria, true);
                MessageBox.Show(
                    "Su nueva Contraseña es: " + contraseniaAleatoria + "\n\n Contraseña copiada al portapapeles",
                    "Nueva Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}