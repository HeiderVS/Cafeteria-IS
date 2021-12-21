using System;
using System.Windows.Forms;
using Controladores.Administrador;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

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

        private void radGridProductos_CellEvent(object sender, EventArgs eventArgs)
        {
            _inventarioControlador.ActualizarProducto((ProductoViewModel) ((GridViewCellEventArgs)eventArgs).Row.DataBoundItem);
        }

        private void radGridProductos_CollectionChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (GridViewDataRowInfo rowInfo in e.NewItems)
                {
                    _inventarioControlador.EliminarProducto((ProductoViewModel) rowInfo.DataBoundItem);
                }
            }
        }
    }
}