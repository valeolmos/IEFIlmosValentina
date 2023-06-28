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
            this.cboProductos = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargaDeProductos = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboRegistros = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboProductos.SuspendLayout();
            this.cboRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProductos
            // 
            this.cboProductos.BackColor = System.Drawing.Color.White;
            this.cboProductos.Controls.Add(this.dateTimePicker1);
            this.cboProductos.Controls.Add(this.textBox2);
            this.cboProductos.Controls.Add(this.lblID);
            this.cboProductos.Controls.Add(this.textBox1);
            this.cboProductos.Controls.Add(this.lblFechaRegistro);
            this.cboProductos.Controls.Add(this.lblNombre);
            this.cboProductos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductos.Location = new System.Drawing.Point(32, 110);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(369, 211);
            this.cboProductos.TabIndex = 0;
            this.cboProductos.TabStop = false;
            this.cboProductos.Text = "Productos";
            this.cboProductos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 19);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(12, 138);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(127, 19);
            this.lblFechaRegistro.TabIndex = 1;
            this.lblFechaRegistro.Text = "Fecha Registro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 46);
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
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 138);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cboRegistros
            // 
            this.cboRegistros.BackColor = System.Drawing.Color.White;
            this.cboRegistros.Controls.Add(this.comboBox1);
            this.cboRegistros.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegistros.Location = new System.Drawing.Point(459, 37);
            this.cboRegistros.Name = "cboRegistros";
            this.cboRegistros.Size = new System.Drawing.Size(328, 284);
            this.cboRegistros.TabIndex = 3;
            this.cboRegistros.TabStop = false;
            this.cboRegistros.Text = "Registros";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 27);
            this.comboBox1.TabIndex = 0;
            // 
            // frmCargaDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(this.cboRegistros);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblCargaDeProductos);
            this.Controls.Add(this.cboProductos);
            this.Name = "frmCargaDeProductos";
            this.Text = "Carga del producto";
            this.cboProductos.ResumeLayout(false);
            this.cboProductos.PerformLayout();
            this.cboRegistros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cboProductos;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargaDeProductos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox cboRegistros;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}