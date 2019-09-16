namespace SalarioHorasTrabajadas
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblmensaje1 = new System.Windows.Forms.Label();
            this.lblHorastrabajadas = new System.Windows.Forms.Label();
            this.txtHorastrabajadas = new System.Windows.Forms.TextBox();
            this.lblvalorhora = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lblincremento = new System.Windows.Forms.Label();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.lblporcentaje2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(92, 23);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(150, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Salario Empleado";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(271, 165);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(84, 23);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorhora.Location = new System.Drawing.Point(164, 167);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(100, 21);
            this.txtvalorhora.TabIndex = 2;
            this.txtvalorhora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorhora_KeyPress);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(271, 323);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblmensaje1
            // 
            this.lblmensaje1.AutoSize = true;
            this.lblmensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje1.Location = new System.Drawing.Point(79, 86);
            this.lblmensaje1.Name = "lblmensaje1";
            this.lblmensaje1.Size = new System.Drawing.Size(67, 16);
            this.lblmensaje1.TabIndex = 4;
            this.lblmensaje1.Text = "mensaje1";
            this.lblmensaje1.Visible = false;
            // 
            // lblHorastrabajadas
            // 
            this.lblHorastrabajadas.AutoSize = true;
            this.lblHorastrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorastrabajadas.Location = new System.Drawing.Point(12, 128);
            this.lblHorastrabajadas.Name = "lblHorastrabajadas";
            this.lblHorastrabajadas.Size = new System.Drawing.Size(130, 16);
            this.lblHorastrabajadas.TabIndex = 5;
            this.lblHorastrabajadas.Text = "Horas Trabajdas:";
            // 
            // txtHorastrabajadas
            // 
            this.txtHorastrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorastrabajadas.Location = new System.Drawing.Point(164, 128);
            this.txtHorastrabajadas.Name = "txtHorastrabajadas";
            this.txtHorastrabajadas.Size = new System.Drawing.Size(100, 21);
            this.txtHorastrabajadas.TabIndex = 6;
            this.txtHorastrabajadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorastrabajadas_KeyPress);
            // 
            // lblvalorhora
            // 
            this.lblvalorhora.AutoSize = true;
            this.lblvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorhora.Location = new System.Drawing.Point(55, 171);
            this.lblvalorhora.Name = "lblvalorhora";
            this.lblvalorhora.Size = new System.Drawing.Size(87, 16);
            this.lblvalorhora.TabIndex = 7;
            this.lblvalorhora.Text = "Valor Hora:";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalario.Location = new System.Drawing.Point(79, 312);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(62, 16);
            this.lblsalario.TabIndex = 8;
            this.lblsalario.Text = "Salario:";
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescuento.Location = new System.Drawing.Point(55, 218);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(86, 16);
            this.lbldescuento.TabIndex = 9;
            this.lbldescuento.Text = "Descuento:";
            // 
            // lblincremento
            // 
            this.lblincremento.AutoSize = true;
            this.lblincremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincremento.Location = new System.Drawing.Point(53, 260);
            this.lblincremento.Name = "lblincremento";
            this.lblincremento.Size = new System.Drawing.Size(88, 16);
            this.lblincremento.TabIndex = 10;
            this.lblincremento.Text = "Incremento:";
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje.Location = new System.Drawing.Point(162, 220);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(82, 16);
            this.lblporcentaje.TabIndex = 11;
            this.lblporcentaje.Text = "porcentaje";
            this.lblporcentaje.Visible = false;
            // 
            // lblporcentaje2
            // 
            this.lblporcentaje2.AutoSize = true;
            this.lblporcentaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje2.Location = new System.Drawing.Point(162, 263);
            this.lblporcentaje2.Name = "lblporcentaje2";
            this.lblporcentaje2.Size = new System.Drawing.Size(90, 16);
            this.lblporcentaje2.TabIndex = 12;
            this.lblporcentaje2.Text = "porcentaje2";
            this.lblporcentaje2.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(162, 312);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(44, 16);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "Total";
            this.lbltotal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 358);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblporcentaje2);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.lblincremento);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblvalorhora);
            this.Controls.Add(this.txtHorastrabajadas);
            this.Controls.Add(this.lblHorastrabajadas);
            this.Controls.Add(this.lblmensaje1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblmensaje1;
        private System.Windows.Forms.Label lblHorastrabajadas;
        private System.Windows.Forms.TextBox txtHorastrabajadas;
        private System.Windows.Forms.Label lblvalorhora;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lblincremento;
        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.Label lblporcentaje2;
        private System.Windows.Forms.Label lbltotal;
    }
}

