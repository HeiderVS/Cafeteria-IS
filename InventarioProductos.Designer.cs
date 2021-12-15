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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuLista = new Telerik.WinControls.UI.RadMenuItem();
            this.radBtnReports = new Telerik.WinControls.UI.RadMenuItem();
            this.radGridProductos = new Telerik.WinControls.UI.RadGridView();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radBtnImprimirInventario = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize) (this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridProductos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radBtnImprimirInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.BackColor = System.Drawing.Color.Gainsboro;
            this.radMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMenu1.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {this.radMenuItem2, this.radMenuItem1, this.radBtnReports});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1134, 37);
            this.radMenu1.TabIndex = 19;
            this.radMenu1.ThemeName = "Material";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {this.radMenuItem4, this.radMenuItem5, this.radMenuItem6});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Usuarios";
            this.radMenuItem2.UseCompatibleTextRendering = false;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Editar";
            this.radMenuItem4.UseCompatibleTextRendering = false;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Eliminar";
            this.radMenuItem5.UseCompatibleTextRendering = false;
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Agregar";
            this.radMenuItem6.UseCompatibleTextRendering = false;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {this.radMenuLista});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Inventario";
            this.radMenuItem1.UseCompatibleTextRendering = false;
            // 
            // radMenuLista
            // 
            this.radMenuLista.Name = "radMenuLista";
            this.radMenuLista.Text = "Lista de Productos";
            this.radMenuLista.UseCompatibleTextRendering = false;
            // 
            // radBtnReports
            // 
            this.radBtnReports.Name = "radBtnReports";
            this.radBtnReports.Text = "Reportes";
            this.radBtnReports.UseCompatibleTextRendering = false;
            // 
            // radGridProductos
            // 
            this.radGridProductos.Location = new System.Drawing.Point(12, 276);
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
            this.radLabel1.Location = new System.Drawing.Point(34, 99);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(199, 56);
            this.radLabel1.TabIndex = 21;
            this.radLabel1.Text = "Inventario";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(34, 161);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(267, 18);
            this.radLabel2.TabIndex = 22;
            this.radLabel2.Text = "Administre los productos disponibles en la cafeteria.";
            // 
            // radBtnImprimirInventario
            // 
            this.radBtnImprimirInventario.Image = global::Cafeteria_IS.Properties.Resources.printing__4_;
            this.radBtnImprimirInventario.Location = new System.Drawing.Point(12, 234);
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
            this.Controls.Add(this.radMenu1);
            this.Name = "InventarioProductos";
            this.Text = "InventarioProductos";
            this.Load += new System.EventHandler(this.InventarioProductos_Load);
            ((System.ComponentModel.ISupportInitialize) (this.radMenu1)).EndInit();
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

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuLista;
        private Telerik.WinControls.UI.RadMenuItem radBtnReports;

        #endregion
    }
}