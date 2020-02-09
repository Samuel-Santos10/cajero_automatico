namespace cajero_automatico
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
            this.btnretirar = new System.Windows.Forms.Button();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.lblpago = new System.Windows.Forms.Label();
            this.txtpagar = new System.Windows.Forms.TextBox();
            this.lblresp = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnpagar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnretirar
            // 
            this.btnretirar.BackColor = System.Drawing.Color.Black;
            this.btnretirar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnretirar.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirar.ForeColor = System.Drawing.Color.White;
            this.btnretirar.Location = new System.Drawing.Point(389, 23);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(113, 39);
            this.btnretirar.TabIndex = 0;
            this.btnretirar.Text = "RETIRAR";
            this.btnretirar.UseVisualStyleBackColor = false;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(3, 36);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(157, 20);
            this.lblcantidad.TabIndex = 1;
            this.lblcantidad.Text = "CANTIDAD A RETIRAR:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(162, 30);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(75, 29);
            this.txtcantidad.TabIndex = 2;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(251, 28);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(106, 20);
            this.lblrespuesta.TabIndex = 3;
            this.lblrespuesta.Text = "RESPUESTA: ?";
            this.lblrespuesta.Visible = false;
            // 
            // lblpago
            // 
            this.lblpago.AutoSize = true;
            this.lblpago.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpago.Location = new System.Drawing.Point(2, 28);
            this.lblpago.Name = "lblpago";
            this.lblpago.Size = new System.Drawing.Size(118, 20);
            this.lblpago.TabIndex = 4;
            this.lblpago.Text = "TOTAL A PAGAR:";
            // 
            // txtpagar
            // 
            this.txtpagar.Location = new System.Drawing.Point(118, 24);
            this.txtpagar.Name = "txtpagar";
            this.txtpagar.Size = new System.Drawing.Size(100, 29);
            this.txtpagar.TabIndex = 5;
            // 
            // lblresp
            // 
            this.lblresp.AutoSize = true;
            this.lblresp.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresp.Location = new System.Drawing.Point(524, 29);
            this.lblresp.Name = "lblresp";
            this.lblresp.Size = new System.Drawing.Size(106, 20);
            this.lblresp.TabIndex = 6;
            this.lblresp.Text = "RESPUESTA: ?";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(416, 25);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(100, 29);
            this.txtpago.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "CANTIDAD CON QUE PAGA:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblrespuesta);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.lblcantidad);
            this.groupBox1.Controls.Add(this.btnretirar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 149);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajero Automatico";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnpagar);
            this.groupBox2.Controls.Add(this.txtpago);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblresp);
            this.groupBox2.Controls.Add(this.txtpagar);
            this.groupBox2.Controls.Add(this.lblpago);
            this.groupBox2.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 154);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cajero de Pago";
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.Black;
            this.btnpagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpagar.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.Color.White;
            this.btnpagar.Location = new System.Drawing.Point(263, 85);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(113, 43);
            this.btnpagar.TabIndex = 11;
            this.btnpagar.Text = "PAGAR";
            this.btnpagar.UseVisualStyleBackColor = false;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Label lblpago;
        private System.Windows.Forms.TextBox txtpagar;
        private System.Windows.Forms.Label lblresp;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnpagar;
    }
}

