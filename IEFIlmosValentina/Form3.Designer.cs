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
            this.LBLID = new System.Windows.Forms.Label();
            this.lblFechaDeVenta = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdConsulta = new System.Windows.Forms.Button();
            this.mcRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcRegistro
            // 
            this.mcRegistro.BackColor = System.Drawing.Color.White;
            this.mcRegistro.Controls.Add(this.monthCalendar1);
            this.mcRegistro.Controls.Add(this.txtCantidad);
            this.mcRegistro.Controls.Add(this.txtProducto);
            this.mcRegistro.Controls.Add(this.txtID);
            this.mcRegistro.Controls.Add(this.lblCantidad);
            this.mcRegistro.Controls.Add(this.lblProducto);
            this.mcRegistro.Controls.Add(this.lblFechaDeVenta);
            this.mcRegistro.Controls.Add(this.LBLID);
            this.mcRegistro.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcRegistro.Location = new System.Drawing.Point(12, 12);
            this.mcRegistro.Name = "mcRegistro";
            this.mcRegistro.Size = new System.Drawing.Size(392, 410);
            this.mcRegistro.TabIndex = 0;
            this.mcRegistro.TabStop = false;
            this.mcRegistro.Text = "Regristo";
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
            // lblFechaDeVenta
            // 
            this.lblFechaDeVenta.AutoSize = true;
            this.lblFechaDeVenta.Location = new System.Drawing.Point(22, 203);
            this.lblFechaDeVenta.Name = "lblFechaDeVenta";
            this.lblFechaDeVenta.Size = new System.Drawing.Size(126, 19);
            this.lblFechaDeVenta.TabIndex = 1;
            this.lblFechaDeVenta.Text = "Fecha de venta";
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
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 153);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(82, 19);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(123, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 26);
            this.txtID.TabIndex = 4;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(123, 93);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(126, 26);
            this.txtProducto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(123, 150);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(126, 26);
            this.txtCantidad.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(123, 226);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(321, 443);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(83, 28);
            this.cmdGuardar.TabIndex = 1;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsulta.Location = new System.Drawing.Point(39, 443);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(75, 28);
            this.cmdConsulta.TabIndex = 2;
            this.cmdConsulta.Text = "Consulta";
            this.cmdConsulta.UseVisualStyleBackColor = true;
            // 
            // frmCargaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(456, 511);
            this.Controls.Add(this.cmdConsulta);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mcRegistro);
            this.Name = "frmCargaDeVentas";
            this.Text = "Carga de ventas";
            this.mcRegistro.ResumeLayout(false);
            this.mcRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mcRegistro;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFechaDeVenta;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdConsulta;
    }
}