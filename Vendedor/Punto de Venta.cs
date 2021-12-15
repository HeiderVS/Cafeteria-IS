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
    public partial class Punto_de_Venta : Form
    {
        public Punto_de_Venta()
        {
            InitializeComponent();
        }

        private void radLabel6_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Esta seguro que quiere cerrar sesion?","Confirmacion", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
        }

        private void Punto_de_Venta_Load(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Esta seguro que quiere cancelar la compra?", "Confirmacion", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Compra eliminada", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Esta seguro que quiere Finalizar la compra?", "Confirmacion", botones, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Compra guardada con exito", "Compra finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
