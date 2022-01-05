using System.ComponentModel;

namespace Cafeteria_IS.Administrador
{
    partial class PanelAdministrador
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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radBtnReports = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize) (this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.radPanel1.Location = new System.Drawing.Point(-1, 32);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1135, 816);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "Material";
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
            this.radMenu1.TabIndex = 3;
            this.radMenu1.ThemeName = "Material";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {this.radMenuItem5, this.radMenuItem8});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Usuarios";
            this.radMenuItem2.UseCompatibleTextRendering = false;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Agregar usuario";
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {this.radMenuItem6, this.radMenuItem7});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Inventario";
            this.radMenuItem1.UseCompatibleTextRendering = false;
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Agregar producto";
            this.radMenuItem6.Click += new System.EventHandler(this.radMenuItem6_Click);
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Listado de productos";
            this.radMenuItem7.Click += new System.EventHandler(this.radMenuItem7_Click);
            // 
            // radBtnReports
            // 
            this.radBtnReports.Name = "radBtnReports";
            this.radBtnReports.Text = "Reportes";
            this.radBtnReports.UseCompatibleTextRendering = false;
            this.radBtnReports.Click += new System.EventHandler(this.radBtnReports_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Editar";
            this.radMenuItem4.UseCompatibleTextRendering = false;
            //this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radMenuSeparatorItem1.UseCompatibleTextRendering = false;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Agregar";
            this.radMenuItem3.UseCompatibleTextRendering = false;
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Lista de usuarios";
            this.radMenuItem8.Click += new System.EventHandler(this.radMenuItem8_Click);
            // 
            // PanelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 845);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radPanel1);
            this.Name = "PanelAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelAdministrador";
            this.Load += new System.EventHandler(this.PanelAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize) (this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;

        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;

        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;

        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;

        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radBtnReports;

        private Telerik.WinControls.UI.RadPanel radPanel1;

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;

        #endregion
    }
}