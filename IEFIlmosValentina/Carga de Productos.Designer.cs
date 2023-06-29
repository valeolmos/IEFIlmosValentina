namespace IEFIlmosValentina
{
    partial class frmCargaDeProductos
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
            this.mrcProductos = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargaDeProductos = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdConsulta = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.mrcProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcProductos
            // 
            this.mrcProductos.BackColor = System.Drawing.Color.White;
            this.mrcProductos.Controls.Add(this.nudCantidad);
            this.mrcProductos.Controls.Add(this.dtpFecha);
            this.mrcProductos.Controls.Add(this.txtID);
            this.mrcProductos.Controls.Add(this.lblID);
            this.mrcProductos.Controls.Add(this.txtNombre);
            this.mrcProductos.Controls.Add(this.lblFechaRegistro);
            this.mrcProductos.Controls.Add(this.lblCantidad);
            this.mrcProductos.Controls.Add(this.lblNombre);
            this.mrcProductos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcProductos.Location = new System.Drawing.Point(32, 92);
            this.mrcProductos.Name = "mrcProductos";
            this.mrcProductos.Size = new System.Drawing.Size(369, 211);
            this.mrcProductos.TabIndex = 0;
            this.mrcProductos.TabStop = false;
            this.mrcProductos.Text = "Productos";
            this.mrcProductos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(163, 119);
            this.dtpFecha.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 86);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 19);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(13, 125);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(127, 19);
            this.lblFechaRegistro.TabIndex = 1;
            this.lblFechaRegistro.Text = "Fecha Registro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCargaDeProductos
            // 
            this.lblCargaDeProductos.AutoSize = true;
            this.lblCargaDeProductos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaDeProductos.Location = new System.Drawing.Point(100, 37);
            this.lblCargaDeProductos.Name = "lblCargaDeProductos";
            this.lblCargaDeProductos.Size = new System.Drawing.Size(246, 29);
            this.lblCargaDeProductos.TabIndex = 1;
            this.lblCargaDeProductos.Text = "Carga de Productos";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(325, 344);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(76, 25);
            this.cmdGuardar.TabIndex = 2;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsulta.Location = new System.Drawing.Point(32, 344);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(75, 23);
            this.cmdConsulta.TabIndex = 3;
            this.cmdConsulta.Text = "Consulta";
            this.cmdConsulta.UseVisualStyleBackColor = true;
            this.cmdConsulta.Click += new System.EventHandler(this.cmdConsulta_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(13, 167);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(82, 19);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(154, 165);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(170, 26);
            this.nudCantidad.TabIndex = 6;
            // 
            // frmCargaDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(444, 414);
            this.Controls.Add(this.cmdConsulta);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblCargaDeProductos);
            this.Controls.Add(this.mrcProductos);
            this.Name = "frmCargaDeProductos";
            this.Text = "Carga del producto";
            this.Load += new System.EventHandler(this.frmCargaDeProductos_Load);
            this.mrcProductos.ResumeLayout(false);
            this.mrcProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcProductos;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargaDeProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button cmdConsulta;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}