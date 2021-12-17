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
using Controladores;
using Controladores.Administrador;

namespace Cafeteria_IS
{
    public partial class Login : Form
    {
        private LoginControlador _loginControlador = new LoginControlador();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void radPictureBox1_ImageLoaded(object sender, EventArgs e)
        {
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            radTextBoxContraseña.PasswordChar = '*';
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioInfoViewModel usuario =
                _loginControlador.GetLogin(this.radTextBoxUsuario.Text, this.radTextBoxContraseña.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario no valido");
                return;
            }
            
            switch (usuario.rol)
            {
                case 0:
                    /*UsuariosAgregar frm = new UsuariosAgregar();
                    frm.Show();*/
                    PanelAdministrador admin = new PanelAdministrador();
                    admin.Show();
                    break;
                case 1:
                    Punto_de_Venta puntoDeVenta = new Punto_de_Venta(usuario);
                    puntoDeVenta.Show();
                    break;
            }

            this.Hide();
        }

        private void radRadioButton1_ToggleStateChanged(object sender,
            Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (btnMostrarContra.IsChecked == true)
            {
                radTextBoxContraseña.PasswordChar = '\0';
            }
        }
    }
}