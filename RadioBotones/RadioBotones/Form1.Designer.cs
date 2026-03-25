namespace RadioBotones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btncalcular = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.rbSinDescuento = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb20 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto de compra";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(257, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(257, 176);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(244, 26);
            this.txtMonto.TabIndex = 4;
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Location = new System.Drawing.Point(146, 262);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(78, 43);
            this.Btnlimpiar.TabIndex = 5;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Btncalcular
            // 
            this.Btncalcular.Location = new System.Drawing.Point(289, 262);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(78, 43);
            this.Btncalcular.TabIndex = 6;
            this.Btncalcular.Text = "Calcular";
            this.Btncalcular.UseVisualStyleBackColor = true;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(442, 262);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(78, 43);
            this.Btnsalir.TabIndex = 7;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // rbSinDescuento
            // 
            this.rbSinDescuento.AutoSize = true;
            this.rbSinDescuento.Location = new System.Drawing.Point(17, 36);
            this.rbSinDescuento.Name = "rbSinDescuento";
            this.rbSinDescuento.Size = new System.Drawing.Size(136, 24);
            this.rbSinDescuento.TabIndex = 8;
            this.rbSinDescuento.TabStop = true;
            this.rbSinDescuento.Text = "Sin descuento";
            this.rbSinDescuento.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(182, 34);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(167, 24);
            this.rb10.TabIndex = 9;
            this.rb10.TabStop = true;
            this.rb10.Text = "10% de descuento";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb20
            // 
            this.rb20.AutoSize = true;
            this.rb20.Location = new System.Drawing.Point(375, 33);
            this.rb20.Name = "rb20";
            this.rb20.Size = new System.Drawing.Size(167, 24);
            this.rb20.TabIndex = 10;
            this.rb20.TabStop = true;
            this.rb20.Text = "20% de descuento";
            this.rb20.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb20);
            this.groupBox1.Controls.Add(this.rb10);
            this.groupBox1.Controls.Add(this.rbSinDescuento);
            this.groupBox1.Location = new System.Drawing.Point(105, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 84);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btncalcular);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.Button Btncalcular;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.RadioButton rbSinDescuento;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb20;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

