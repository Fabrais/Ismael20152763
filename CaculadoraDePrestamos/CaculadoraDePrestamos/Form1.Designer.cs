namespace CaculadoraDePrestamos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mmAnios = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mmAnios)).BeginInit();
            this.SuspendLayout();
            // 
            // mmAnios
            // 
            this.mmAnios.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mmAnios.Location = new System.Drawing.Point(245, 95);
            this.mmAnios.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.mmAnios.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mmAnios.Name = "mmAnios";
            this.mmAnios.Size = new System.Drawing.Size(155, 20);
            this.mmAnios.TabIndex = 0;
            this.mmAnios.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.mmAnios.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor De Prestamo";
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(245, 14);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(155, 20);
            this.txtPrestamo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPrestamo, "Digite el valor de su prestamo");
            this.txtPrestamo.TextChanged += new System.EventHandler(this.txtPrestamo_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(245, 53);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(155, 20);
            this.txtInteres.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtInteres, "Digite el valor de su prestamo");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interes%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de Año";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(16, 152);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(414, 126);
            this.txtResultado.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(245, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular Interes";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ISAMAEL ENRIQUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mmAnios);
            this.Name = "Form1";
            this.Text = "Calculaora De Interes";
            ((System.ComponentModel.ISupportInitialize)(this.mmAnios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown mmAnios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
    }
}

