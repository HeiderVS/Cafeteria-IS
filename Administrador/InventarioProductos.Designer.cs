using System.ComponentModel;

namespace Cafeteria_IS
{
    partial class InventarioProductos
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridProductos = new Telerik.WinControls.UI.RadGridView();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radBtnImprimirInventario = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radBtnImprimirInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridProductos
            // 
            this.radGridProductos.Location = new System.Drawing.Point(18, 229);
            // 
            // 
            // 
            this.radGridProductos.MasterTemplate.AllowAddNewRow = false;
            this.radGridProductos.MasterTemplate.AllowDragToGroup = false;
            this.radGridProductos.MasterTemplate.AllowSearchRow = true;
            this.radGridProductos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridProductos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridProductos.Name = "radGridProductos";
            this.radGridProductos.Size = new System.Drawing.Size(1110, 535);
            this.radGridProductos.TabIndex = 20;
            this.radGridProductos.ThemeName = "Material";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel1.Location = new System.Drawing.Point(29, 46);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(199, 56);
            this.radLabel1.TabIndex = 21;
            this.radLabel1.Text = "Inventario";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(29, 108);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(267, 18);
            this.radLabel2.TabIndex = 22;
            this.radLabel2.Text = "Administre los productos disponibles en la cafeteria.";
            // 
            // radBtnImprimirInventario
            // 
            this.radBtnImprimirInventario.Image = global::Cafeteria_IS.Properties.Resources.printing__4_;
            this.radBtnImprimirInventario.Location = new System.Drawing.Point(18, 187);
            this.radBtnImprimirInventario.Name = "radBtnImprimirInventario";
            this.radBtnImprimirInventario.Size = new System.Drawing.Size(120, 36);
            this.radBtnImprimirInventario.TabIndex = 23;
            this.radBtnImprimirInventario.Text = "Imprimir";
            this.radBtnImprimirInventario.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radBtnImprimirInventario.ThemeName = "Material";
            this.radBtnImprimirInventario.Click += new System.EventHandler(this.radBtnImprimirInventario_Click);
            // 
            // InventarioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 845);
            this.Controls.Add(this.radBtnImprimirInventario);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radGridProductos);
            this.Name = "InventarioProductos";
            this.Text = "InventarioProductos";
            this.Load += new System.EventHandler(this.InventarioProductos_Load);
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radBtnImprimirInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Telerik.WinControls.UI.RadButton radBtnImprimirInventario;

        private Telerik.WinControls.UI.RadLabel radLabel2;

        private Telerik.WinControls.UI.RadLabel radLabel1;

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;

        private Telerik.WinControls.UI.RadGridView radGridProductos;

        #endregion
    }
}