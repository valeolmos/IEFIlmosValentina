namespace IEFIlmosValentina
{
    partial class frmCargaDeVentas
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
            this.mcRegistro = new System.Windows.Forms.GroupBox();
            this.txtProductoV = new System.Windows.Forms.TextBox();
            this.txtIDV = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFechaDeVenta = new System.Windows.Forms.Label();
            this.LBLID = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdConsulta = new System.Windows.Forms.Button();
            this.dtpFechaV = new System.Windows.Forms.DateTimePicker();
            this.lblCargaDeVentas = new System.Windows.Forms.Label();
            this.nudCantidadV = new System.Windows.Forms.NumericUpDown();
            this.mcRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadV)).BeginInit();
            this.SuspendLayout();
            // 
            // mcRegistro
            // 
            this.mcRegistro.BackColor = System.Drawing.Color.White;
            this.mcRegistro.Controls.Add(this.nudCantidadV);
            this.mcRegistro.Controls.Add(this.dtpFechaV);
            this.mcRegistro.Controls.Add(this.txtProductoV);
            this.mcRegistro.Controls.Add(this.txtIDV);
            this.mcRegistro.Controls.Add(this.lblCantidad);
            this.mcRegistro.Controls.Add(this.lblProducto);
            this.mcRegistro.Controls.Add(this.lblFechaDeVenta);
            this.mcRegistro.Controls.Add(this.LBLID);
            this.mcRegistro.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcRegistro.Location = new System.Drawing.Point(26, 110);
            this.mcRegistro.Name = "mcRegistro";
            this.mcRegistro.Size = new System.Drawing.Size(392, 260);
            this.mcRegistro.TabIndex = 0;
            this.mcRegistro.TabStop = false;
            this.mcRegistro.Text = "Regristo";
            // 
            // txtProductoV
            // 
            this.txtProductoV.Location = new System.Drawing.Point(123, 93);
            this.txtProductoV.Name = "txtProductoV";
            this.txtProductoV.Size = new System.Drawing.Size(126, 26);
            this.txtProductoV.TabIndex = 5;
            // 
            // txtIDV
            // 
            this.txtIDV.Location = new System.Drawing.Point(123, 44);
            this.txtIDV.Name = "txtIDV";
            this.txtIDV.Size = new System.Drawing.Size(126, 26);
            this.txtIDV.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 153);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(82, 19);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(22, 100);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(80, 19);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // lblFechaDeVenta
            // 
            this.lblFechaDeVenta.AutoSize = true;
            this.lblFechaDeVenta.Location = new System.Drawing.Point(22, 203);
            this.lblFechaDeVenta.Name = "lblFechaDeVenta";
            this.lblFechaDeVenta.Size = new System.Drawing.Size(126, 19);
            this.lblFechaDeVenta.TabIndex = 1;
            this.lblFechaDeVenta.Text = "Fecha de venta";
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Location = new System.Drawing.Point(22, 44);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(28, 19);
            this.LBLID.TabIndex = 0;
            this.LBLID.Text = "ID";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(321, 393);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(97, 28);
            this.cmdGuardar.TabIndex = 1;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsulta.Location = new System.Drawing.Point(26, 393);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(88, 28);
            this.cmdConsulta.TabIndex = 2;
            this.cmdConsulta.Text = "Consulta";
            this.cmdConsulta.UseVisualStyleBackColor = true;
            this.cmdConsulta.Click += new System.EventHandler(this.cmdConsulta_Click);
            // 
            // dtpFechaV
            // 
            this.dtpFechaV.Location = new System.Drawing.Point(167, 201);
            this.dtpFechaV.Name = "dtpFechaV";
            this.dtpFechaV.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaV.TabIndex = 7;
            // 
            // lblCargaDeVentas
            // 
            this.lblCargaDeVentas.AutoSize = true;
            this.lblCargaDeVentas.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaDeVentas.Location = new System.Drawing.Point(144, 46);
            this.lblCargaDeVentas.Name = "lblCargaDeVentas";
            this.lblCargaDeVentas.Size = new System.Drawing.Size(176, 25);
            this.lblCargaDeVentas.TabIndex = 3;
            this.lblCargaDeVentas.Text = "Carga de ventas";
            // 
            // nudCantidadV
            // 
            this.nudCantidadV.Location = new System.Drawing.Point(144, 153);
            this.nudCantidadV.Name = "nudCantidadV";
            this.nudCantidadV.Size = new System.Drawing.Size(150, 26);
            this.nudCantidadV.TabIndex = 8;
            // 
            // frmCargaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(456, 511);
            this.Controls.Add(this.lblCargaDeVentas);
            this.Controls.Add(this.cmdConsulta);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mcRegistro);
            this.Name = "frmCargaDeVentas";
            this.Text = "Carga de ventas";
            this.Load += new System.EventHandler(this.frmCargaDeVentas_Load);
            this.mcRegistro.ResumeLayout(false);
            this.mcRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mcRegistro;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFechaDeVenta;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.TextBox txtProductoV;
        private System.Windows.Forms.TextBox txtIDV;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdConsulta;
        private System.Windows.Forms.DateTimePicker dtpFechaV;
        private System.Windows.Forms.Label lblCargaDeVentas;
        private System.Windows.Forms.NumericUpDown nudCantidadV;
    }
}