using System;
using System.Linq;
using System.Windows.Forms;
using Controladores.Administrador;
using Modelos.Inventario;
using Telerik.WinControls.UI;

namespace Cafeteria_IS
{
    public partial class InventarioAgregar : Form
    {
        private InventarioControlador _inventarioControlador = new InventarioControlador();

        public InventarioAgregar()
        {
            InitializeComponent();
        }


        private void InventarioAgregar_Load(object sender, EventArgs e)
        {
            this.radDropCategorias.DataSource = _inventarioControlador.GetCategorias();
            this.radDropCategorias.DisplayMember = "categoria";
            this.radDropCategorias.ValueMember = "id";
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (radSpinCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad en inventario debe ser mayor a 0");
                return;
            }
            
            if (radSpinPrecio.Value == 0)
            {
                MessageBox.Show("Precio de producto debe ser mayor a $0");
                return;
            }

            _inventarioControlador.RegistraProducto(this.radEtNombre.Text,
                this.radEtMarca.Text,
                (int) this.radDropCategorias.SelectedItem.Value,
                this.radSpinPrecio.Value,
                (int) this.radSpinCantidad.Value);

            if (MessageBox.Show("Producto registrado en inventario") == DialogResult.OK) Clear();
        }

        private bool ValidarCampos()
        {
            bool validateNombre = ValidationUtils.TextBoxEmptyValidation(this.radEtNombre, this.errorProvider1);
            bool validateMarca = ValidationUtils.TextBoxEmptyValidation(this.radEtMarca, this.errorProvider1);
            return validateNombre && validateMarca;
        }

        private void Clear()
        {
            this.radEtNombre.Text = string.Empty;
            this.radEtMarca.Text = string.Empty;
            this.radDropCategorias.SelectedIndex = 0;
            this.radSpinPrecio.Value = new decimal(0.00);
            this.radSpinCantidad.Value = new decimal(0.00);
        }

        private void btnCancelarAgrUsuario_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}