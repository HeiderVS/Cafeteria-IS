using System.ComponentModel;

namespace Cafeteria_IS
{
    partial class AdminReportes
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radDateTimePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel1.Location = new System.Drawing.Point(78, 116);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(203, 65);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Reportes";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel2.Location = new System.Drawing.Point(78, 187);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(712, 30);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Obtenga la informacion de ordenes de ventas generadas en un rango de tiempo. ";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(78, 334);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(975, 471);
            this.radGridView1.TabIndex = 2;
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Location = new System.Drawing.Point(200, 307);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePicker1.TabIndex = 3;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "30 November 2021";
            this.radDateTimePicker1.Value = new System.DateTime(2021, 11, 30, 16, 26, 45, 572);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel3.Location = new System.Drawing.Point(78, 302);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(116, 25);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Fecha de inicio";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel4.Location = new System.Drawing.Point(412, 303);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(95, 23);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Fecha de fin";
            this.radLabel4.UseCompatibleTextRendering = false;
            // 
            // radDateTimePicker2
            // 
            this.radDateTimePicker2.Location = new System.Drawing.Point(534, 308);
            this.radDateTimePicker2.Name = "radDateTimePicker2";
            this.radDateTimePicker2.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePicker2.TabIndex = 5;
            this.radDateTimePicker2.TabStop = false;
            this.radDateTimePicker2.Text = "30 November 2021";
            this.radDateTimePicker2.Value = new System.DateTime(2021, 11, 30, 16, 26, 45, 572);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(778, 305);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(275, 24);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "Generar reporte";
            // 
            // AdminReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 890);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radDateTimePicker2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "AdminReportes";
            this.Text = "AdminReportes";
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radDateTimePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Telerik.WinControls.UI.RadButton radButton1;

        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker2;

        private Telerik.WinControls.UI.RadLabel radLabel3;

        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;

        private Telerik.WinControls.UI.RadGridView radGridView1;

        private Telerik.WinControls.UI.RadLabel radLabel2;

        private Telerik.WinControls.UI.RadLabel radLabel1;

        #endregion
    }
}