
namespace Cafeteria_IS
{
    partial class Punto_de_Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGridOrden = new Telerik.WinControls.UI.RadGridView();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelTotal = new Telerik.WinControls.UI.RadLabel();
            this.radGridProductos = new Telerik.WinControls.UI.RadGridView();
            this.radApplicationMenu1 = new Telerik.WinControls.UI.RadApplicationMenu();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radLabelFecha = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize) (this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.radGridOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridOrden.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabelTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radApplicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabelFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.radPanel1.Controls.Add(this.radGridOrden);
            this.radPanel1.Controls.Add(this.radButton2);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radLabelTotal);
            this.radPanel1.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(660, 12);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.ApplyShapeToControl = false;
            this.radPanel1.RootElement.ShadowDepth = 100;
            this.radPanel1.RootElement.StretchHorizontally = false;
            this.radPanel1.RootElement.StretchVertically = false;
            this.radPanel1.RootElement.UseDefaultDisabledPaint = true;
            this.radPanel1.Size = new System.Drawing.Size(499, 975);
            this.radPanel1.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPanelElement) (this.radPanel1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadPanelElement) (this.radPanel1.GetChildAt(0))).EnableFocusBorder = false;
            ((Telerik.WinControls.UI.RadPanelElement) (this.radPanel1.GetChildAt(0))).CanFocus = false;
            ((Telerik.WinControls.UI.RadPanelElement) (this.radPanel1.GetChildAt(0))).ClipDrawing = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive) (this.radPanel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            // 
            // radGridOrden
            // 
            this.radGridOrden.Location = new System.Drawing.Point(36, 79);
            // 
            // 
            // 
            this.radGridOrden.MasterTemplate.AllowAddNewRow = false;
            this.radGridOrden.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridOrden.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridOrden.Name = "radGridOrden";
            this.radGridOrden.Size = new System.Drawing.Size(421, 690);
            this.radGridOrden.TabIndex = 9;
            this.radGridOrden.ThemeName = "Material";
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.Color.Gray;
            this.radButton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radButton2.Location = new System.Drawing.Point(105, 915);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(294, 40);
            this.radButton2.TabIndex = 8;
            this.radButton2.Text = "Cancelar Compra";
            this.radButton2.ThemeName = "Material";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            ((Telerik.WinControls.UI.RadButtonElement) (this.radButton2.GetChildAt(0))).Text = "Cancelar Compra";
            ((Telerik.WinControls.UI.RadButtonElement) (this.radButton2.GetChildAt(0))).ShadowDepth = 3;
            ((Telerik.WinControls.UI.RadButtonElement) (this.radButton2.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (122)))), ((int) (((byte) (122)))), ((int) (((byte) (122)))));
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel1.Location = new System.Drawing.Point(36, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(243, 41);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Orden de Compra";
            this.radLabel1.ThemeName = "Material";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Navy;
            this.radButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButton1.Location = new System.Drawing.Point(36, 861);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(421, 48);
            this.radButton1.TabIndex = 7;
            this.radButton1.Text = "Finalizar Compra";
            this.radButton1.ThemeName = "Material";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement) (this.radButton1.GetChildAt(0))).Text = "Finalizar Compra";
            ((Telerik.WinControls.UI.RadButtonElement) (this.radButton1.GetChildAt(0))).ShadowDepth = 3;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel2.Location = new System.Drawing.Point(95, 799);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(94, 41);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Total: ";
            this.radLabel2.ThemeName = "Material";
            // 
            // radLabelTotal
            // 
            this.radLabelTotal.BackColor = System.Drawing.Color.Transparent;
            this.radLabelTotal.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabelTotal.ForeColor = System.Drawing.Color.Black;
            this.radLabelTotal.Location = new System.Drawing.Point(237, 784);
            this.radLabelTotal.Name = "radLabelTotal";
            this.radLabelTotal.Size = new System.Drawing.Size(2, 2);
            this.radLabelTotal.TabIndex = 5;
            this.radLabelTotal.ThemeName = "Material";
            // 
            // radGridProductos
            // 
            this.radGridProductos.Location = new System.Drawing.Point(12, 91);
            // 
            // 
            // 
            this.radGridProductos.MasterTemplate.AllowAddNewRow = false;
            this.radGridProductos.MasterTemplate.AllowDeleteRow = false;
            this.radGridProductos.MasterTemplate.AllowSearchRow = true;
            this.radGridProductos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridProductos.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridProductos.Name = "radGridProductos";
            // 
            // 
            // 
            this.radGridProductos.RootElement.ShadowColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.radGridProductos.RootElement.ShadowDepth = 100;
            this.radGridProductos.Size = new System.Drawing.Size(642, 830);
            this.radGridProductos.TabIndex = 4;
            this.radGridProductos.ThemeName = "Material";
            this.radGridProductos.ValueChanged += new System.EventHandler(this.radGridProductos_ValueChanged);
            // 
            // radApplicationMenu1
            // 
            this.radApplicationMenu1.Location = new System.Drawing.Point(-23, -46);
            this.radApplicationMenu1.Name = "radApplicationMenu1";
            this.radApplicationMenu1.Size = new System.Drawing.Size(48, 48);
            this.radApplicationMenu1.TabIndex = 18;
            this.radApplicationMenu1.Text = "radApplicationMenu1";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel6.Location = new System.Drawing.Point(12, 962);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(104, 25);
            this.radLabel6.TabIndex = 19;
            this.radLabel6.Text = "Cerrar Sesion";
            this.radLabel6.ThemeName = "Material";
            this.radLabel6.Click += new System.EventHandler(this.radLabel6_Click);
            // 
            // radLabelFecha
            // 
            this.radLabelFecha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabelFecha.Location = new System.Drawing.Point(12, 44);
            this.radLabelFecha.Name = "radLabelFecha";
            this.radLabelFecha.Size = new System.Drawing.Size(2, 2);
            this.radLabelFecha.TabIndex = 20;
            // 
            // Punto_de_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 992);
            this.Controls.Add(this.radLabelFecha);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radApplicationMenu1);
            this.Controls.Add(this.radGridProductos);
            this.Controls.Add(this.radPanel1);
            this.Name = "Punto_de_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto_de_Venta";
            this.Load += new System.EventHandler(this.Punto_de_Venta_Load);
            ((System.ComponentModel.ISupportInitialize) (this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.radGridOrden.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabelTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radApplicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabelFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Telerik.WinControls.UI.RadLabel radLabelFecha;

        private Telerik.WinControls.UI.RadLabel radLabelTotal;

        private Telerik.WinControls.UI.RadGridView radGridOrden;

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;

        private Telerik.WinControls.UI.RadGridView radGridProductos;

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView radGridView3;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadApplicationMenu radApplicationMenu1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
    }
}