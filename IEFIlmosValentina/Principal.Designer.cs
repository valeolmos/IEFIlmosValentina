namespace IEFIlmosValentina
{
    partial class frmPrincipal
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.cmdCargaDeVentas = new System.Windows.Forms.Button();
            this.cmdCargaDeProducto = new System.Windows.Forms.Button();
            this.cmdListados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(121, 45);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(128, 25);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.Location = new System.Drawing.Point(33, 98);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(157, 15);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Usted desea ingresar a:";
            // 
            // cmdCargaDeVentas
            // 
            this.cmdCargaDeVentas.BackColor = System.Drawing.Color.Transparent;
            this.cmdCargaDeVentas.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargaDeVentas.Location = new System.Drawing.Point(36, 130);
            this.cmdCargaDeVentas.Name = "cmdCargaDeVentas";
            this.cmdCargaDeVentas.Size = new System.Drawing.Size(105, 26);
            this.cmdCargaDeVentas.TabIndex = 2;
            this.cmdCargaDeVentas.Text = "Carga de Ventas";
            this.cmdCargaDeVentas.UseVisualStyleBackColor = false;
            this.cmdCargaDeVentas.Click += new System.EventHandler(this.lblCargaDeVentas_Click);
            // 
            // cmdCargaDeProducto
            // 
            this.cmdCargaDeProducto.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargaDeProducto.Location = new System.Drawing.Point(189, 130);
            this.cmdCargaDeProducto.Name = "cmdCargaDeProducto";
            this.cmdCargaDeProducto.Size = new System.Drawing.Size(116, 26);
            this.cmdCargaDeProducto.TabIndex = 3;
            this.cmdCargaDeProducto.Text = "Carga de Producto";
            this.cmdCargaDeProducto.UseVisualStyleBackColor = true;
            this.cmdCargaDeProducto.Click += new System.EventHandler(this.cmdCargaDeProducto_Click);
            // 
            // cmdListados
            // 
            this.cmdListados.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListados.Location = new System.Drawing.Point(125, 173);
            this.cmdListados.Name = "cmdListados";
            this.cmdListados.Size = new System.Drawing.Size(96, 27);
            this.cmdListados.TabIndex = 4;
            this.cmdListados.Text = "Listados";
            this.cmdListados.UseVisualStyleBackColor = true;
            this.cmdListados.Click += new System.EventHandler(this.cmdListados_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(382, 260);
            this.Controls.Add(this.cmdListados);
            this.Controls.Add(this.cmdCargaDeProducto);
            this.Controls.Add(this.cmdCargaDeVentas);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.lblBienvenido);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button cmdCargaDeVentas;
        private System.Windows.Forms.Button cmdCargaDeProducto;
        private System.Windows.Forms.Button cmdListados;
    }
}

