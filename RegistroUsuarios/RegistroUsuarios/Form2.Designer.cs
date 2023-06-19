namespace RegistroUsuarios
{
    partial class FormRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroUsuario));
            this.labelTituloRegistroUsuario = new System.Windows.Forms.Label();
            this.labelRUNombre = new System.Windows.Forms.Label();
            this.textBoxRUNombre = new System.Windows.Forms.TextBox();
            this.textBoxRUPassword = new System.Windows.Forms.TextBox();
            this.labelRUPassword = new System.Windows.Forms.Label();
            this.buttonRURegistrarse = new System.Windows.Forms.Button();
            this.labelRURegistroExito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTituloRegistroUsuario
            // 
            this.labelTituloRegistroUsuario.AutoSize = true;
            this.labelTituloRegistroUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloRegistroUsuario.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloRegistroUsuario.Location = new System.Drawing.Point(60, 80);
            this.labelTituloRegistroUsuario.Name = "labelTituloRegistroUsuario";
            this.labelTituloRegistroUsuario.Size = new System.Drawing.Size(314, 36);
            this.labelTituloRegistroUsuario.TabIndex = 0;
            this.labelTituloRegistroUsuario.Text = "Registro de Usuario";
            // 
            // labelRUNombre
            // 
            this.labelRUNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRUNombre.AutoSize = true;
            this.labelRUNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelRUNombre.Location = new System.Drawing.Point(61, 173);
            this.labelRUNombre.Name = "labelRUNombre";
            this.labelRUNombre.Size = new System.Drawing.Size(189, 25);
            this.labelRUNombre.TabIndex = 1;
            this.labelRUNombre.Text = "Nombre completo";
            this.labelRUNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRUNombre
            // 
            this.textBoxRUNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRUNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRUNombre.Location = new System.Drawing.Point(256, 173);
            this.textBoxRUNombre.Name = "textBoxRUNombre";
            this.textBoxRUNombre.Size = new System.Drawing.Size(455, 25);
            this.textBoxRUNombre.TabIndex = 1;
            this.textBoxRUNombre.TextChanged += new System.EventHandler(this.textBoxRUNombre_TextChanged);
            // 
            // textBoxRUPassword
            // 
            this.textBoxRUPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRUPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRUPassword.Location = new System.Drawing.Point(256, 279);
            this.textBoxRUPassword.Name = "textBoxRUPassword";
            this.textBoxRUPassword.Size = new System.Drawing.Size(455, 25);
            this.textBoxRUPassword.TabIndex = 2;
            // 
            // labelRUPassword
            // 
            this.labelRUPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRUPassword.AutoSize = true;
            this.labelRUPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelRUPassword.Location = new System.Drawing.Point(61, 279);
            this.labelRUPassword.Name = "labelRUPassword";
            this.labelRUPassword.Size = new System.Drawing.Size(127, 25);
            this.labelRUPassword.TabIndex = 3;
            this.labelRUPassword.Text = "Contraseña";
            this.labelRUPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRURegistrarse
            // 
            this.buttonRURegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.buttonRURegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRURegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRURegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRURegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.buttonRURegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRURegistrarse.ForeColor = System.Drawing.Color.Black;
            this.buttonRURegistrarse.Location = new System.Drawing.Point(574, 367);
            this.buttonRURegistrarse.Name = "buttonRURegistrarse";
            this.buttonRURegistrarse.Size = new System.Drawing.Size(137, 39);
            this.buttonRURegistrarse.TabIndex = 3;
            this.buttonRURegistrarse.Text = "Registrarse";
            this.buttonRURegistrarse.UseVisualStyleBackColor = false;
            this.buttonRURegistrarse.Click += new System.EventHandler(this.buttonRURegistrarse_Click);
            // 
            // labelRURegistroExito
            // 
            this.labelRURegistroExito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRURegistroExito.AutoSize = true;
            this.labelRURegistroExito.BackColor = System.Drawing.Color.Transparent;
            this.labelRURegistroExito.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRURegistroExito.Location = new System.Drawing.Point(61, 381);
            this.labelRURegistroExito.Name = "labelRURegistroExito";
            this.labelRURegistroExito.Size = new System.Drawing.Size(0, 20);
            this.labelRURegistroExito.TabIndex = 4;
            this.labelRURegistroExito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRURegistroExito.Click += new System.EventHandler(this.labelRURegistroExito_Click);
            // 
            // FormRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.labelRURegistroExito);
            this.Controls.Add(this.buttonRURegistrarse);
            this.Controls.Add(this.textBoxRUPassword);
            this.Controls.Add(this.labelRUPassword);
            this.Controls.Add(this.textBoxRUNombre);
            this.Controls.Add(this.labelRUNombre);
            this.Controls.Add(this.labelTituloRegistroUsuario);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloRegistroUsuario;
        private System.Windows.Forms.Label labelRUNombre;
        private System.Windows.Forms.TextBox textBoxRUNombre;
        private System.Windows.Forms.TextBox textBoxRUPassword;
        private System.Windows.Forms.Label labelRUPassword;
        private System.Windows.Forms.Button buttonRURegistrarse;
        private System.Windows.Forms.Label labelRURegistroExito;
    }
}