namespace CalculadorPropinas
{
    partial class FormCalculadoraPropinas
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelPorcentajeProps = new System.Windows.Forms.Label();
            this.labelMontoTotal = new System.Windows.Forms.Label();
            this.labelDinero = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.comboBoxPorcentajeProps = new System.Windows.Forms.ComboBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(150, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(273, 40);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Calcula tu propina";
            // 
            // labelMonto
            // 
            this.labelMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(27, 134);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(172, 28);
            this.labelMonto.TabIndex = 1;
            this.labelMonto.Text = "Monto de cuenta";
            this.labelMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPorcentajeProps
            // 
            this.labelPorcentajeProps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPorcentajeProps.AutoSize = true;
            this.labelPorcentajeProps.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorcentajeProps.Location = new System.Drawing.Point(27, 212);
            this.labelPorcentajeProps.Name = "labelPorcentajeProps";
            this.labelPorcentajeProps.Size = new System.Drawing.Size(218, 28);
            this.labelPorcentajeProps.TabIndex = 2;
            this.labelPorcentajeProps.Text = "Porcentaje de propina";
            this.labelPorcentajeProps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMontoTotal
            // 
            this.labelMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMontoTotal.AutoSize = true;
            this.labelMontoTotal.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoTotal.Location = new System.Drawing.Point(164, 371);
            this.labelMontoTotal.Name = "labelMontoTotal";
            this.labelMontoTotal.Size = new System.Drawing.Size(247, 28);
            this.labelMontoTotal.TabIndex = 3;
            this.labelMontoTotal.Text = "Monto Total de la Cuenta";
            this.labelMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDinero
            // 
            this.labelDinero.AutoSize = true;
            this.labelDinero.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDinero.Location = new System.Drawing.Point(245, 410);
            this.labelDinero.Name = "labelDinero";
            this.labelDinero.Size = new System.Drawing.Size(0, 22);
            this.labelDinero.TabIndex = 4;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonto.Location = new System.Drawing.Point(217, 134);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(289, 32);
            this.textBoxMonto.TabIndex = 1;
            this.textBoxMonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // comboBoxPorcentajeProps
            // 
            this.comboBoxPorcentajeProps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPorcentajeProps.FormattingEnabled = true;
            this.comboBoxPorcentajeProps.Location = new System.Drawing.Point(264, 212);
            this.comboBoxPorcentajeProps.Name = "comboBoxPorcentajeProps";
            this.comboBoxPorcentajeProps.Size = new System.Drawing.Size(242, 29);
            this.comboBoxPorcentajeProps.TabIndex = 2;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.Plum;
            this.buttonCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcular.FlatAppearance.BorderSize = 0;
            this.buttonCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(142, 311);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(281, 40);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "Calcular Cuenta";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // FormCalculadoraPropinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(586, 621);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.comboBoxPorcentajeProps);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.labelDinero);
            this.Controls.Add(this.labelMontoTotal);
            this.Controls.Add(this.labelPorcentajeProps);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCalculadoraPropinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Propinas";
            this.Load += new System.EventHandler(this.FormCalculadoraPropinas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label labelPorcentajeProps;
        private System.Windows.Forms.Label labelMontoTotal;
        private System.Windows.Forms.Label labelDinero;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.ComboBox comboBoxPorcentajeProps;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

