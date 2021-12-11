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

        private void radBtnReports_Click(object sender, EventArgs e)
        {
            AdminReportes adminReportes = new AdminReportes();
            adminReportes.Show();
            this.Hide();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            UsuariosAgregar frm = new UsuariosAgregar();
            frm.Show();
            this.Hide();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Desea generar una nueva contraseña para este empleado?", "Confirmacion",botones, MessageBoxIcon.Warning);
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
                MessageBox.Show("Contraseña Generada con exito", "Contraseña Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetDataObject(contraseniaAleatoria, true);
                MessageBox.Show("Su nueva Contraseña es: " + contraseniaAleatoria+"\n\n Contraseña copiada al portapapeles", "Nueva Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEditarUsuarioExistente_Click(object sender, EventArgs e)
        {
            Editar_Empleado_Existente frm = new Editar_Empleado_Existente();
            frm.Show();
        }
    }
}
