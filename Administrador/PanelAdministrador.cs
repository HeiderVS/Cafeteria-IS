using System;
using System.Windows.Forms;

namespace Cafeteria_IS.Administrador
{
    public partial class PanelAdministrador : Form
    {
        public PanelAdministrador()
        {
            InitializeComponent();
        }

        private void PanelAdministrador_Load(object sender, EventArgs e)
        {
            OpenAgregarUsuarios();
        }
        
        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            OpenAgregarUsuarios();
        }
        
        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            OpenEditarUsuarios();
        }
        
        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            OpenInventarioAgregar();
        }
        
        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            OpenInventarioProductos();
        }
        
        private void radBtnReports_Click(object sender, EventArgs e)
        {
            OpenAdminReportes();
        }
        
        private void OpenEditarUsuarios()
        {
            this.radPanel1.Controls.Clear();
            AdminEditar adminEditar = new AdminEditar() {TopLevel = false, TopMost = true};
            adminEditar.FormBorderStyle = FormBorderStyle.None;
            this.radPanel1.Controls.Add(adminEditar);
            adminEditar.Show();
        }
        
        private void OpenInventarioProductos()
        {
            this.radPanel1.Controls.Clear();
            InventarioProductos inventarioProductos = new InventarioProductos() {TopLevel = false, TopMost = true};
            inventarioProductos.FormBorderStyle = FormBorderStyle.None;
            this.radPanel1.Controls.Add(inventarioProductos);
            inventarioProductos.Show();
        }
        
        private void OpenInventarioAgregar()
        {
            this.radPanel1.Controls.Clear();
            InventarioAgregar inventarioAgregar = new InventarioAgregar() {TopLevel = false, TopMost = true};
            inventarioAgregar.FormBorderStyle = FormBorderStyle.None;
            this.radPanel1.Controls.Add(inventarioAgregar);
            inventarioAgregar.Show();
        }

        private void OpenAgregarUsuarios()
        {
            this.radPanel1.Controls.Clear();
            UsuariosAgregar usuariosAgregar = new UsuariosAgregar() {TopLevel = false, TopMost = true};
            usuariosAgregar.FormBorderStyle = FormBorderStyle.None;
            this.radPanel1.Controls.Add(usuariosAgregar);
            usuariosAgregar.Show();
        }
        
        private void OpenAdminReportes()
        {
            this.radPanel1.Controls.Clear();
            AdminReportes adminReportes = new AdminReportes() {TopLevel = false, TopMost = true};
            adminReportes.FormBorderStyle = FormBorderStyle.None;
            this.radPanel1.Controls.Add(adminReportes);
            adminReportes.Show();
        }
    }
}