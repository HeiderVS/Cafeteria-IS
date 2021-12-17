using System.ComponentModel;

namespace Cafeteria_IS
{
    partial class InventarioAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioAgregar));
            this.btnCancelarAgrUsuario = new Telerik.WinControls.UI.RadLabel();
            this.lbl1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radEtMarca = new Telerik.WinControls.UI.RadTextBox();
            this.radEtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnRegistraProducto = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radDropCategorias = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinPrecio = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinCantidad = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize) (this.btnCancelarAgrUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.lbl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radEtMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radEtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnRegistraProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).BeginInit();
            this.radLabel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radDropCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radSpinPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radSpinCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarAgrUsuario
            // 
            this.btnCancelarAgrUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarAgrUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAgrUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCancelarAgrUsuario.Location = new System.Drawing.Point(160, 654);
            this.btnCancelarAgrUsuario.Name = "btnCancelarAgrUsuario";
            this.btnCancelarAgrUsuario.Size = new System.Drawing.Size(66, 24);
            this.btnCancelarAgrUsuario.TabIndex = 27;
            this.btnCancelarAgrUsuario.Text = "Cancelar";
            this.btnCancelarAgrUsuario.Click += new System.EventHandler(this.btnCancelarAgrUsuario_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl1.Location = new System.Drawing.Point(43, 498);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(86, 30);
            this.lbl1.TabIndex = 26;
            this.lbl1.Text = "Cantidad";
            // 
            // radLabel6
            // 
            this.radLabel6.BackColor = System.Drawing.Color.Transparent;
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel6.Location = new System.Drawing.Point(40, 271);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(62, 30);
            this.radLabel6.TabIndex = 21;
            this.radLabel6.Text = "Marca";
            // 
            // radLabel5
            // 
            this.radLabel5.BackColor = System.Drawing.Color.Transparent;
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel5.Location = new System.Drawing.Point(37, 156);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(363, 24);
            this.radLabel5.TabIndex = 22;
            this.radLabel5.Text = "Registre un nuevo integrante a su equipo de trabajo";
            // 
            // radEtMarca
            // 
            this.radEtMarca.AutoSize = false;
            this.radEtMarca.BackColor = System.Drawing.Color.White;
            this.radEtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.radEtMarca.Location = new System.Drawing.Point(40, 307);
            this.radEtMarca.Name = "radEtMarca";
            this.radEtMarca.Size = new System.Drawing.Size(172, 36);
            this.radEtMarca.TabIndex = 29;
            this.radEtMarca.ThemeName = "Material";
            // 
            // radEtNombre
            // 
            this.radEtNombre.AutoSize = false;
            this.radEtNombre.BackColor = System.Drawing.Color.White;
            this.radEtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.radEtNombre.Location = new System.Drawing.Point(40, 236);
            this.radEtNombre.Name = "radEtNombre";
            this.radEtNombre.Size = new System.Drawing.Size(172, 36);
            this.radEtNombre.TabIndex = 28;
            this.radEtNombre.ThemeName = "Material";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel2.Location = new System.Drawing.Point(40, 200);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 30);
            this.radLabel2.TabIndex = 20;
            this.radLabel2.Text = "Nombre";
            // 
            // btnRegistraProducto
            // 
            this.btnRegistraProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistraProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistraProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistraProducto.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistraProducto.Location = new System.Drawing.Point(40, 614);
            this.btnRegistraProducto.Name = "btnRegistraProducto";
            this.btnRegistraProducto.Size = new System.Drawing.Size(304, 36);
            this.btnRegistraProducto.TabIndex = 24;
            this.btnRegistraProducto.Text = "Registrar";
            this.btnRegistraProducto.ThemeName = "Material";
            this.btnRegistraProducto.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel3.Location = new System.Drawing.Point(40, 427);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(62, 30);
            this.radLabel3.TabIndex = 23;
            this.radLabel3.Text = "Precio";
            // 
            // radLabel1
            // 
            this.radLabel1.Controls.Add(this.radLabel4);
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel1.Location = new System.Drawing.Point(40, 94);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(199, 56);
            this.radLabel1.TabIndex = 19;
            this.radLabel1.Text = "Inventario";
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel4.Location = new System.Drawing.Point(3, 50);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(75, 30);
            this.radLabel4.TabIndex = 9;
            this.radLabel4.Text = "Usuario";
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("radPictureBox1.Image")));
            this.radPictureBox1.ImageLayout = Telerik.WinControls.UI.RadImageLayout.Stretch;
            this.radPictureBox1.Location = new System.Drawing.Point(447, 0);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.Size = new System.Drawing.Size(687, 852);
            this.radPictureBox1.TabIndex = 17;
            // 
            // radDropCategorias
            // 
            this.radDropCategorias.DropDownAnimationEnabled = true;
            this.radDropCategorias.Location = new System.Drawing.Point(40, 385);
            this.radDropCategorias.Name = "radDropCategorias";
            this.radDropCategorias.Size = new System.Drawing.Size(172, 36);
            this.radDropCategorias.TabIndex = 33;
            this.radDropCategorias.Text = "Seleccione una categoria";
            this.radDropCategorias.ThemeName = "Material";
            // 
            // radLabel7
            // 
            this.radLabel7.BackColor = System.Drawing.Color.Transparent;
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel7.Location = new System.Drawing.Point(40, 349);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(92, 30);
            this.radLabel7.TabIndex = 24;
            this.radLabel7.Text = "Categoria";
            // 
            // radSpinPrecio
            // 
            this.radSpinPrecio.DecimalPlaces = 2;
            this.radSpinPrecio.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.radSpinPrecio.Location = new System.Drawing.Point(43, 463);
            this.radSpinPrecio.Name = "radSpinPrecio";
            this.radSpinPrecio.Size = new System.Drawing.Size(169, 36);
            this.radSpinPrecio.TabIndex = 34;
            this.radSpinPrecio.ThemeName = "Material";
            // 
            // radSpinCantidad
            // 
            this.radSpinCantidad.Location = new System.Drawing.Point(43, 534);
            this.radSpinCantidad.Name = "radSpinCantidad";
            this.radSpinCantidad.Size = new System.Drawing.Size(172, 36);
            this.radSpinCantidad.TabIndex = 35;
            this.radSpinCantidad.ThemeName = "Material";
            // 
            // InventarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 845);
            this.Controls.Add(this.radSpinCantidad);
            this.Controls.Add(this.radSpinPrecio);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radDropCategorias);
            this.Controls.Add(this.btnCancelarAgrUsuario);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radEtMarca);
            this.Controls.Add(this.radEtNombre);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnRegistraProducto);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radPictureBox1);
            this.Name = "InventarioAgregar";
            this.Text = "InventarioAgregar";
            this.Load += new System.EventHandler(this.InventarioAgregar_Load);
            ((System.ComponentModel.ISupportInitialize) (this.btnCancelarAgrUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.lbl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radEtMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radEtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnRegistraProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).EndInit();
            this.radLabel1.ResumeLayout(false);
            this.radLabel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radDropCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radSpinPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radSpinCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Telerik.WinControls.UI.RadSpinEditor radSpinCantidad;

        private Telerik.WinControls.UI.RadSpinEditor radSpinPrecio;

        private Telerik.WinControls.UI.RadButton btnRegistraProducto;

        private Telerik.WinControls.UI.RadDropDownList radDropCategorias;

        private Telerik.WinControls.UI.RadLabel radLabel7;

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;

        private Telerik.WinControls.UI.RadTextBox radEtNombre;
        private Telerik.WinControls.UI.RadTextBox radEtMarca;

        private Telerik.WinControls.UI.RadLabel btnCancelarAgrUsuario;
        private Telerik.WinControls.UI.RadLabel lbl1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;

        #endregion
    }
}