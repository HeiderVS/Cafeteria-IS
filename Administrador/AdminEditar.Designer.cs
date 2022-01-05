
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;

namespace Cafeteria_IS
{
    partial class AdminEditar
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.btnEditarUsuarioExistente = new Telerik.WinControls.UI.RadButton();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).BeginInit();
            this.radLabel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnEditarUsuarioExistente)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Controls.Add(this.radLabel4);
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel1.Location = new System.Drawing.Point(41, 29);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(169, 56);
            this.radLabel1.TabIndex = 8;
            this.radLabel1.Text = "Usuarios";
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
            // radLabel5
            // 
            this.radLabel5.BackColor = System.Drawing.Color.Transparent;
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel5.Location = new System.Drawing.Point(47, 91);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(494, 24);
            this.radLabel5.TabIndex = 10;
            this.radLabel5.Text = "Edite o reestablesca el accesos a los miembros de su equipo de trabajo.";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(41, 158);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowColumnResize = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowHeaderCellButtons = true;
            this.radGridView1.Size = new System.Drawing.Size(1033, 500);
            this.radGridView1.TabIndex = 11;
            this.radGridView1.ThemeName = "Material";
            this.radGridView1.CellValidating += new CellValidatingEventHandler(this.radGridView1_CellValidating);
            this.radGridView1.CellEndEdit += new GridViewCellEventHandler(this.radGridView1_CellEvent);
            this.radGridView1.RowsChanging += new GridViewCollectionChangingEventHandler(this.radGridView1_ValueChanging);
            this.radGridView1.RowsChanged +=
                new GridViewCollectionChangedEventHandler(this.radGridView1_CollectionChanged);
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.Color.Navy;
            this.radButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButton2.Location = new System.Drawing.Point(393, 680);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(165, 40);
            this.radButton2.TabIndex = 15;
            this.radButton2.Text = "Nueva Contraseña";
            this.radButton2.ThemeName = "Material";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // btnEditarUsuarioExistente
            // 
            this.btnEditarUsuarioExistente.BackColor = System.Drawing.Color.Navy;
            this.btnEditarUsuarioExistente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarUsuarioExistente.Location = new System.Drawing.Point(587, 680);
            this.btnEditarUsuarioExistente.Name = "btnEditarUsuarioExistente";
            this.btnEditarUsuarioExistente.Size = new System.Drawing.Size(165, 40);
            this.btnEditarUsuarioExistente.TabIndex = 16;
            this.btnEditarUsuarioExistente.Text = "Editar";
            this.btnEditarUsuarioExistente.ThemeName = "Material";
            this.btnEditarUsuarioExistente.Click += new System.EventHandler(this.btnEditarUsuarioExistente_Click);
            // 
            // AdminEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 845);
            this.Controls.Add(this.btnEditarUsuarioExistente);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel1);
            this.Name = "AdminEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditar";
            this.Load += new System.EventHandler(this.AdminEditar_Load);
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).EndInit();
            this.radLabel1.ResumeLayout(false);
            this.radLabel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnEditarUsuarioExistente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton btnEditarUsuarioExistente;
    }
}