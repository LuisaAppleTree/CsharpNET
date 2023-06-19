namespace RegistroUsuarios
{
    partial class FormInicio
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.labelTitulo_Inicio = new System.Windows.Forms.Label();
            this.labelDescripcion_Inicio = new System.Windows.Forms.Label();
            this.buttonInicioSesion = new System.Windows.Forms.Button();
            this.buttonCrearCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo_Inicio
            // 
            this.labelTitulo_Inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitulo_Inicio.AutoSize = true;
            this.labelTitulo_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo_Inicio.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo_Inicio.Location = new System.Drawing.Point(400, 200);
            this.labelTitulo_Inicio.Name = "labelTitulo_Inicio";
            this.labelTitulo_Inicio.Size = new System.Drawing.Size(242, 48);
            this.labelTitulo_Inicio.TabIndex = 0;
            this.labelTitulo_Inicio.Text = "Bienvenido";
            this.labelTitulo_Inicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDescripcion_Inicio
            // 
            this.labelDescripcion_Inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDescripcion_Inicio.AutoSize = true;
            this.labelDescripcion_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.labelDescripcion_Inicio.Location = new System.Drawing.Point(250, 264);
            this.labelDescripcion_Inicio.Name = "labelDescripcion_Inicio";
            this.labelDescripcion_Inicio.Size = new System.Drawing.Size(537, 25);
            this.labelDescripcion_Inicio.TabIndex = 1;
            this.labelDescripcion_Inicio.Text = "Inicia sesión en tu cuenta o crea una nueva cuenta.";
            this.labelDescripcion_Inicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonInicioSesion
            // 
            this.buttonInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.buttonInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.buttonInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicioSesion.Location = new System.Drawing.Point(255, 326);
            this.buttonInicioSesion.Name = "buttonInicioSesion";
            this.buttonInicioSesion.Size = new System.Drawing.Size(186, 64);
            this.buttonInicioSesion.TabIndex = 2;
            this.buttonInicioSesion.Text = "Iniciar Sesión";
            this.buttonInicioSesion.UseVisualStyleBackColor = false;
            // 
            // buttonCrearCuenta
            // 
            this.buttonCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.buttonCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCrearCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.buttonCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearCuenta.Location = new System.Drawing.Point(601, 326);
            this.buttonCrearCuenta.Name = "buttonCrearCuenta";
            this.buttonCrearCuenta.Size = new System.Drawing.Size(186, 64);
            this.buttonCrearCuenta.TabIndex = 1;
            this.buttonCrearCuenta.Text = "Crear Cuenta";
            this.buttonCrearCuenta.UseVisualStyleBackColor = false;
            this.buttonCrearCuenta.Click += new System.EventHandler(this.buttonCrearCuenta_Click);
            this.buttonCrearCuenta.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCrearCuenta_Paint);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.buttonCrearCuenta);
            this.Controls.Add(this.buttonInicioSesion);
            this.Controls.Add(this.labelDescripcion_Inicio);
            this.Controls.Add(this.labelTitulo_Inicio);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo_Inicio;
        private System.Windows.Forms.Label labelDescripcion_Inicio;
        private System.Windows.Forms.Button buttonInicioSesion;
        private System.Windows.Forms.Button buttonCrearCuenta;
    }
}

