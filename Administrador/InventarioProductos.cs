using System;
using System.Windows.Forms;
using Controladores.Administrador;

namespace Cafeteria_IS
{
    public partial class InventarioProductos : Form
    {
        private InventarioControlador _inventarioControlador = new InventarioControlador();

        public InventarioProductos()
        {
            InitializeComponent();
        }

        private void InventarioProductos_Load(object sender, EventArgs e)
        {
            this.radGridProductos.DataSource = _inventarioControlador.GetProductos();
        }

        private void radBtnImprimirInventario_Click(object sender, EventArgs e)
        {
            if (this.radGridProductos.RowCount > 0)
            {
                this.radGridProductos.PrintPreview();
            }
        }
    }
}