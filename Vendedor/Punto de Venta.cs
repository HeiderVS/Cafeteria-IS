using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Controladores.Administrador;
using Controladores.Vendedor;
using Modelos.Usuarios;
using Telerik.WinControls.UI;

namespace Cafeteria_IS
{
    public partial class Punto_de_Venta : Form
    {
        private Timer _timer;
        private PuntoVentaControlador _puntoVentaControlador = new PuntoVentaControlador();

        public Punto_de_Venta(UsuarioInfoViewModel usuarioViewModel)
        {
            _puntoVentaControlador.UsuarioInfoViewModel = usuarioViewModel;
            InitializeComponent();
        }

        private void Punto_de_Venta_Load(object sender, EventArgs e)
        {
            _timer = new Timer();
            _timer.Interval = 500;
            _timer.Tick += new EventHandler(Reloj);
            _timer.Enabled = true;
            InitOrdenGrid();
            InitProductosGrid();
        }

        private void InitProductosGrid()
        {
            this.radGridProductos.DataSource = _puntoVentaControlador.GetProductos();
            GridViewCheckBoxColumn checkBoxColumn = new GridViewCheckBoxColumn();
            checkBoxColumn.DataType = typeof(bool);
            checkBoxColumn.Name = "OrdenCompra";
            checkBoxColumn.FieldName = "OrdenCompra";
            checkBoxColumn.HeaderText = "Orden de Compra";
            this.radGridProductos.Columns.Add(checkBoxColumn);
            //this.radGridProductos.Columns[]
        }

        private void InitOrdenGrid()
        {
            this.radGridOrden.DataSource = _puntoVentaControlador.OrdenCompra;

            /*GridViewDecimalColumn units = new GridViewDecimalColumn();
            units.Name = "cantidad";
            units.HeaderText = "Cant.";
            units.FieldName = "cantidad";
            units.Minimum = 1;
            units.DecimalPlaces = 0;
            radGridOrden.MasterTemplate.Columns.Add(units);*/

            GridViewSummaryItem totalItem = new GridViewSummaryItem();
            totalItem.Name = "precio";
            totalItem.AggregateExpression = "Sum(precio * cantidad)";
            totalItem.FormatString = "Total $ {0}";
            GridViewSummaryRowItem totalRow = new GridViewSummaryRowItem();
            totalRow.Add(totalItem);
            radGridOrden.SummaryRowsBottom.Add(totalRow);
            radGridOrden.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;
            radGridOrden.GroupSummaryEvaluate += this.radGridOrden_GroupSummaryEvaluate;
        }

        private void radLabel6_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Esta seguro que quiere cerrar sesion?", "Confirmacion", botones,
                MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Esta seguro que quiere cancelar la compra?", "Confirmacion", botones,
                MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                _puntoVentaControlador.LimpiarCompra();
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Esta seguro que quiere Finalizar la compra?", "Confirmacion", botones,
                MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                _puntoVentaControlador.FinalizarCompra();
                this.radGridProductos.DataSource = _puntoVentaControlador.GetProductos();
                ImprimirTicket();
            }
        }

        private void radBtnAgregar_Click(object sender, EventArgs e)
        {
            //GridViewSelectedRowsCollection selectedProductos = radGridView1.SelectedRows;
        }

        private void radGridProductos_ValueChanged(object sender, EventArgs e)
        {
            if (this.radGridProductos.ActiveEditor is RadCheckBoxEditor)
            {
                if ((CheckState) radGridProductos.ActiveEditor.Value == CheckState.Checked)
                {
                    _puntoVentaControlador.AgregaOrdenCompra(radGridProductos
                        .Rows[radGridProductos.CurrentCell.RowIndex].DataBoundItem);
                }
                else
                {
                    _puntoVentaControlador.EliminaOrdenCompra(radGridProductos
                        .Rows[radGridProductos.CurrentCell.RowIndex].DataBoundItem);
                }
            }
        }

        private void radGridOrden_GroupSummaryEvaluate(object sender, EventArgs e)
        {
            if (((GroupSummaryEvaluationEventArgs) e).SummaryItem.Name == "precio")
            {
                this.radLabel2.Text = "$" + ((GroupSummaryEvaluationEventArgs) e).Value;
                _puntoVentaControlador.TotalPagar =
                    (decimal) (((GroupSummaryEvaluationEventArgs) e).Value ?? Decimal.Zero);
            }
            else
            {
                this.radLabel2.Text = "$0.00";
                _puntoVentaControlador.TotalPagar = 0;
            }
        }

        private void Reloj(object sender, EventArgs e)
        {
            this.radLabelFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
        }

        private void ImprimirTicket()
        {
            RadPrintDocument document = new RadPrintDocument();
            document.RightHeader = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
            document.LeftHeader = _puntoVentaControlador.UsuarioInfoViewModel.name +
                                  _puntoVentaControlador.UsuarioInfoViewModel.paternal;
            document.HeaderFont = new Font("Arial", 14);
            document.AssociatedObject = radGridOrden;
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog(document);
            dialog.ThemeName = "Material";
            dialog.Show();
            dialog.FormClosed += TicketClosed;
        }

        private void TicketClosed(object sender, EventArgs eventArgs)
        {
            _puntoVentaControlador.LimpiarCompra();
        }

        private void radGridOrden_ValueChanged(object sender, CellValidatingEventArgs e)
        {
            GridViewDataColumn column = e.Column as GridViewDataColumn;

            if (e.Row is GridViewDataRowInfo && column != null && column.Name == "cantidad")
            {
                if ((int)e.Value >
                    _puntoVentaControlador.GetCantidadProductoById(
                        (ProductoCompraViewModel) this.radGridOrden.CurrentRow.DataBoundItem))
                {
                    e.Cancel = true;
                    ((GridViewDataRowInfo) e.Row).ErrorText = "Cantidad no disponible de productos";
                }
                else
                {
                    ((GridViewDataRowInfo) e.Row).ErrorText = string.Empty;
                }
            }
        }
    }
}