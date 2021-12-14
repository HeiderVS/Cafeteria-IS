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
    public partial class Login : Form
    {

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
            txtContra.UseSystemPasswordChar = true;

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (radTextBoxUsuario.Text == "Heider" || txtContra.Text == "123")
                {
                    MessageBox.Show("Bienvenido", "Bienvenido");
                    Punto_de_Venta frm = new Punto_de_Venta();
                    frm.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Bienvenido", "Bienvenido");
                    UsuariosAgregar frm = new UsuariosAgregar();
                    frm.Show();
                    this.Hide();
                }
;
            }
            catch
            {

            }
        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            
            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtContra.UseSystemPasswordChar = true;
            }
        }
    }
}
