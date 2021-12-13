
namespace Cafeteria_IS
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnIniciarSesion = new Telerik.WinControls.UI.RadButton();
            this.radTextBoxUsuario = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxContraseña = new Telerik.WinControls.UI.RadTextBox();
            this.btnMostrarContra = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize) (this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnIniciarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radTextBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.radTextBoxContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnMostrarContra)).BeginInit();
            this.SuspendLayout();
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.DefaultImage = ((System.Drawing.Image) (resources.GetObject("radPictureBox1.DefaultImage")));
            this.radPictureBox1.ForeColor = System.Drawing.Color.White;
            this.radPictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("radPictureBox1.Image")));
            this.radPictureBox1.ImageLayout = Telerik.WinControls.UI.RadImageLayout.Stretch;
            this.radPictureBox1.Location = new System.Drawing.Point(493, -2);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.ShowBackground = true;
            this.radPictureBox1.Size = new System.Drawing.Size(515, 864);
            this.radPictureBox1.TabIndex = 0;
            this.radPictureBox1.ImageLoaded += new System.EventHandler(this.radPictureBox1_ImageLoaded);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel1.Location = new System.Drawing.Point(94, 258);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(237, 56);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Inicia Sesion";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel2.Location = new System.Drawing.Point(94, 355);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(75, 30);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Usuario";
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radLabel3.Location = new System.Drawing.Point(94, 428);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(106, 30);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciarSesion.Location = new System.Drawing.Point(94, 546);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(237, 34);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            ((Telerik.WinControls.UI.RadButtonElement) (this.btnIniciarSesion.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            ((Telerik.WinControls.UI.RadButtonElement) (this.btnIniciarSesion.GetChildAt(0))).Text = "Iniciar Sesion";
            ((Telerik.WinControls.UI.RadButtonElement) (this.btnIniciarSesion.GetChildAt(0))).EnableBorderHighlight = true;
            ((Telerik.WinControls.UI.RadButtonElement) (this.btnIniciarSesion.GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (32)))), ((int) (((byte) (255)))));
            // 
            // radTextBoxUsuario
            // 
            this.radTextBoxUsuario.AutoSize = false;
            this.radTextBoxUsuario.BackColor = System.Drawing.Color.White;
            this.radTextBoxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.radTextBoxUsuario.Location = new System.Drawing.Point(94, 391);
            this.radTextBoxUsuario.Name = "radTextBoxUsuario";
            this.radTextBoxUsuario.Size = new System.Drawing.Size(172, 29);
            this.radTextBoxUsuario.TabIndex = 5;
            // 
            // radTextBoxContraseña
            // 
            this.radTextBoxContraseña.AutoSize = false;
            this.radTextBoxContraseña.BackColor = System.Drawing.Color.White;
            this.radTextBoxContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.radTextBoxContraseña.Location = new System.Drawing.Point(94, 464);
            this.radTextBoxContraseña.Name = "radTextBoxContraseña";
            this.radTextBoxContraseña.Size = new System.Drawing.Size(172, 29);
            this.radTextBoxContraseña.TabIndex = 6;
            this.radTextBoxContraseña.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // btnMostrarContra
            // 
            this.btnMostrarContra.Location = new System.Drawing.Point(116, 499);
            this.btnMostrarContra.Name = "btnMostrarContra";
            this.btnMostrarContra.Size = new System.Drawing.Size(119, 18);
            this.btnMostrarContra.TabIndex = 7;
            this.btnMostrarContra.Text = "Mostrar Contraseña";
            this.btnMostrarContra.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 845);
            this.Controls.Add(this.btnMostrarContra);
            this.Controls.Add(this.radTextBoxContraseña);
            this.Controls.Add(this.radTextBoxUsuario);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radPictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize) (this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnIniciarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radTextBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.radTextBoxContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnMostrarContra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnIniciarSesion;
        private Telerik.WinControls.UI.RadTextBox radTextBoxUsuario;
        private Telerik.WinControls.UI.RadTextBox radTextBoxContraseña;
        private Telerik.WinControls.UI.RadRadioButton btnMostrarContra;
    }
}

