namespace Descuentos
{
    partial class Descuento
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
            this.lblVventa = new System.Windows.Forms.Label();
            this.lblDescuento1 = new System.Windows.Forms.Label();
            this.lblDescuento2 = new System.Windows.Forms.Label();
            this.lblVfinal = new System.Windows.Forms.Label();
            this.txtVventa = new System.Windows.Forms.TextBox();
            this.txtDescuento1 = new System.Windows.Forms.TextBox();
            this.txtDescuento2 = new System.Windows.Forms.TextBox();
            this.txtVfinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVventa
            // 
            this.lblVventa.AutoSize = true;
            this.lblVventa.Location = new System.Drawing.Point(203, 76);
            this.lblVventa.Name = "lblVventa";
            this.lblVventa.Size = new System.Drawing.Size(75, 16);
            this.lblVventa.TabIndex = 0;
            this.lblVventa.Text = "Valor venta";
            this.lblVventa.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescuento1
            // 
            this.lblDescuento1.AutoSize = true;
            this.lblDescuento1.Location = new System.Drawing.Point(203, 159);
            this.lblDescuento1.Name = "lblDescuento1";
            this.lblDescuento1.Size = new System.Drawing.Size(82, 16);
            this.lblDescuento1.TabIndex = 1;
            this.lblDescuento1.Text = "Descuento $";
            // 
            // lblDescuento2
            // 
            this.lblDescuento2.AutoSize = true;
            this.lblDescuento2.Location = new System.Drawing.Point(203, 210);
            this.lblDescuento2.Name = "lblDescuento2";
            this.lblDescuento2.Size = new System.Drawing.Size(87, 16);
            this.lblDescuento2.TabIndex = 2;
            this.lblDescuento2.Text = "Descuento %";
            // 
            // lblVfinal
            // 
            this.lblVfinal.AutoSize = true;
            this.lblVfinal.Location = new System.Drawing.Point(203, 262);
            this.lblVfinal.Name = "lblVfinal";
            this.lblVfinal.Size = new System.Drawing.Size(69, 16);
            this.lblVfinal.TabIndex = 3;
            this.lblVfinal.Text = "Venta final";
            // 
            // txtVventa
            // 
            this.txtVventa.Location = new System.Drawing.Point(306, 76);
            this.txtVventa.Name = "txtVventa";
            this.txtVventa.Size = new System.Drawing.Size(100, 22);
            this.txtVventa.TabIndex = 4;
            // 
            // txtDescuento1
            // 
            this.txtDescuento1.Location = new System.Drawing.Point(306, 159);
            this.txtDescuento1.Name = "txtDescuento1";
            this.txtDescuento1.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento1.TabIndex = 5;
            // 
            // txtDescuento2
            // 
            this.txtDescuento2.Location = new System.Drawing.Point(306, 210);
            this.txtDescuento2.Name = "txtDescuento2";
            this.txtDescuento2.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento2.TabIndex = 6;
            // 
            // txtVfinal
            // 
            this.txtVfinal.Location = new System.Drawing.Point(306, 262);
            this.txtVfinal.Name = "txtVfinal";
            this.txtVfinal.Size = new System.Drawing.Size(100, 22);
            this.txtVfinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(458, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(458, 116);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(458, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVfinal);
            this.Controls.Add(this.txtDescuento2);
            this.Controls.Add(this.txtDescuento1);
            this.Controls.Add(this.txtVventa);
            this.Controls.Add(this.lblVfinal);
            this.Controls.Add(this.lblDescuento2);
            this.Controls.Add(this.lblDescuento1);
            this.Controls.Add(this.lblVventa);
            this.Name = "Descuento";
            this.Text = "Descuentos – Programado por: Greisy Coronado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVventa;
        private System.Windows.Forms.Label lblDescuento1;
        private System.Windows.Forms.Label lblDescuento2;
        private System.Windows.Forms.Label lblVfinal;
        private System.Windows.Forms.TextBox txtVventa;
        private System.Windows.Forms.TextBox txtDescuento1;
        private System.Windows.Forms.TextBox txtDescuento2;
        private System.Windows.Forms.TextBox txtVfinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

